using ControleClientes.Entidades;
using ControleClientes.Forms;
using ControleClientes.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControleClientes
{
    public partial class PedidoForm : Form
    {
        private Pedido pedido = new Pedido();
        private readonly PedidoRepository _pedidoRepository;
        private readonly ProdutoRepository _produtoRepository;
        private readonly ClienteRepository _clienteRepository;

        public PedidoForm()
        {
            InitializeComponent();
            _pedidoRepository = new PedidoRepository(new ApplicationDBContext());
            _produtoRepository = new ProdutoRepository(new ApplicationDBContext());
            _clienteRepository = new ClienteRepository();
        }

        // Carrega a aba de consulta com os pedidos
        private void PedidoForm_Load(object sender, EventArgs e)
        {
            CarregarClientes();   // Carregar clientes no comboBox
            CarregarPedidos();    // Carregar pedidos existentes na grid
            CarregarStatus();     // Carregar status no comboBox
        }

        // Carregar os clientes na comboBox do pedido
        private void CarregarClientes()
        {
            cmbBoxCliente.DataSource = _clienteRepository.ReadAll();
            cmbBoxCliente.DisplayMember = "Nome";
            cmbBoxCliente.ValueMember = "Id";
        }

        // Carregar os status na comboBox do pedido
        private void CarregarStatus()
        {
            cmbBoxStatus.Items.Add("Pendente");
            cmbBoxStatus.Items.Add("Concluído");
            cmbBoxStatus.Items.Add("Cancelado");
        }

        // Carregar os pedidos na grid de consulta
        private void CarregarPedidos()
        {
            //gridPedidos.DataSource = _pedidoRepository.ReadAll().ToList();   // Consultar todos os pedidos
        }

        // Limpar os campos no formulário
        private void LimparCampos()
        {
            cmbBoxCliente.SelectedIndex = -1;
            cmbBoxStatus.SelectedIndex = -1;
            gridItensPedido.Rows.Clear();
            pedido = new Pedido();
        }

        // Atualizar a grid de itens no pedido
        private void AtualizarGridItens()
        {
            gridItensPedido.Rows.Clear();
            foreach (var item in pedido.Itens)
            {
                gridItensPedido.Rows.Add(item.Produto.Nome, item.Quantidade, item.PrecoUnitario, item.Total);
            }
        }

        private void btnNovoProd_Click(object sender, EventArgs e)
        {
            LimparCampos();  // Limpa os campos
            tabPedido.SelectTab(tabPedidoCadastro);  // Seleciona a aba de cadastro
        }

        //private void btnAddItem_Click_1(object sender, EventArgs e)
        //{
        //    // Carregar produtos disponíveis do banco de dados

        //    var produtos = _produtoRepository.ReadAll();  // Retorna a lista de produtos

        //    // Verificar se a lista de produtos está vazia ou nula
        //    if (produtos == null || !produtos.Any())
        //    {
        //        MessageBox.Show("Não há produtos disponíveis no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    // Abrir o formulário de item com os produtos carregados
        //    using (var itemForm = new ItemForm(produtos))  // Passa os produtos para o ItemForm
        //    {
        //        if (itemForm.ShowDialog() == DialogResult.OK)  // Se o item for salvo
        //        {
        //            var novoItem = itemForm.ItemSelecionado;  // Recupera o item selecionado
        //            pedido.Itens.Add(novoItem);  // Adiciona o item à lista do pedido
        //            AtualizarGridItens();  // Atualiza a grid de itens
        //        }
        //    }
        //}

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            // Carregar produtos disponíveis do banco de dados
            var produtos = _produtoRepository.ReadAll();  // Retorna a lista de produtos

            if (produtos == null || !produtos.Any())
            {
                MessageBox.Show("Não há produtos disponíveis no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Armazena a lista de produtos na variável estática
            ItemForm.ProdutosDisponiveis = produtos.ToList();  // Passa a lista estática de produtos

            using (var itemForm = new ItemForm())  // Não é necessário passar produtos como parâmetro
            {
                if (itemForm.ShowDialog() == DialogResult.OK)
                {
                    var novoItem = itemForm.ItemSelecionado;
                    pedido.Itens.Add(novoItem);
                    AtualizarGridItens();
                }
            }
        }


        private void btnCancelarPedido_Click_1(object sender, EventArgs e)
        {
            tabPedido.SelectTab(tabPedidoConsulta);  // Volta para a aba de consulta

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (gridPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido para visualizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pedidoSelecionado = (Pedido)gridPedidos.SelectedRows[0].DataBoundItem;
            pedido = pedidoSelecionado;
            AtualizarGridItens();  // Atualiza a grid de itens com os itens do pedido selecionado
            tabPedido.SelectTab(tabPedidoCadastro);  // Abre a aba de cadastro
        }

        private void btnSalvarPedido_Click_1(object sender, EventArgs e)
        {
            if (cmbBoxCliente.SelectedIndex == -1 || pedido.Itens.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um cliente e adicione ao menos um item ao pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Preenche as propriedades do pedido
            pedido.ClienteId = (int)cmbBoxCliente.SelectedValue;
            pedido.Status = cmbBoxStatus.SelectedItem.ToString();
            pedido.DataPedido = DateTime.Now;  // Atribui a data atual do pedido

            _pedidoRepository.Create(pedido);  // Salva o pedido no banco de dados
            MessageBox.Show("Pedido salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CarregarPedidos();  // Atualiza a grid com os pedidos
            tabPedido.SelectTab(tabPedidoConsulta);  // Volta para a aba de consulta
        }
    }
}
