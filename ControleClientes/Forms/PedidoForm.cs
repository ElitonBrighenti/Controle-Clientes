using ControleClientes.Entidades;
using ControleClientes.Forms;
using ControleClientes.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ControleClientes
{
    public partial class PedidoForm : Form
    {
        private readonly ClienteRepository _clienteRepository;
        private readonly PedidoRepository _pedidoRepository;
        private readonly ItemPedidoRepository _itemRepository;

        private Pedido pedidoSelecionado;  // Variável global para o pedido selecionado

        public PedidoForm()
        {
            _pedidoRepository = new PedidoRepository(new ApplicationDBContext());
            _itemRepository = new ItemPedidoRepository(new ApplicationDBContext());
            _clienteRepository = new ClienteRepository();
            InitializeComponent();
            CarregarDados();
            LoadPedidos();
        }

        private void PedidoForm_Load(object sender, EventArgs e)
        {
            gridItensPedido.DataSource = new BindingList<ItemPedido>();  // Inicializa a grid de itens vazia
        }

        private void CarregarDados()
        {
            cmbBoxCliente.DataSource = _clienteRepository.ReadAll();
            cmbBoxCliente.DisplayMember = "Nome";
            cmbBoxCliente.ValueMember = "Id";
            cmbBoxStatus.DataSource = new List<string> { "Pendente", "Concluído", "Cancelado" };
        }

        private void LoadPedidos()
        {
            gridPedidos.Rows.Clear();
            foreach (var pedido in _pedidoRepository.ReadAll())
            {
                gridPedidos.Rows.Add(pedido.Id, pedido.Cliente.Nome, pedido.Data, pedido.Status);
            }
        }

        private void btnVisualizar_Click_1(object sender, EventArgs e)
        {
            if (gridPedidos.SelectedRows.Count > 0)
            {
                int pedidoId = (int)gridPedidos.SelectedRows[0].Cells["Id"].Value;
                CarregarPedidoParaEdicao(pedidoId);
            }
        }

        private void CarregarPedidoParaEdicao(int pedidoId)
        {
            using (var db = new ApplicationDBContext())
            {
                pedidoSelecionado = new PedidoRepository(db).GetById(pedidoId);
                if (pedidoSelecionado != null)
                {
                    cmbBoxCliente.SelectedValue = pedidoSelecionado.ClienteId;
                    dateTimePickerDataPedido.Value = pedidoSelecionado.Data.ToLocalTime();
                    cmbBoxStatus.SelectedItem = pedidoSelecionado.Status;

                    // Carrega os itens do pedido na grid
                    //gridItensPedido.DataSource = new BindingList<ItemPedido>(pedidoSelecionado.Itens);
                    tabPedido.SelectTab(tabPedidoCadastro);
                }
                else
                {
                    MessageBox.Show("Pedido não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNovoProd_Click(object sender, EventArgs e)
        {
            tabPedido.SelectTab(tabPedidoCadastro);
            // Limpar os campos ou preparar o formulário
            pedidoSelecionado = new Pedido(); // Cria um novo pedido ao clicar em "Novo"
            gridItensPedido.DataSource = new BindingList<ItemPedido>(); // Limpa os itens
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using (ItemForm itemForm = new ItemForm())
            {
                if (itemForm.ShowDialog() == DialogResult.OK)
                {
                    ItemPedido novoItem = (ItemPedido)itemForm.Tag;
                    var itens = (BindingList<ItemPedido>)gridItensPedido.DataSource;
                    itens.Add(novoItem); // Adiciona o novo item
                    gridItensPedido.DataSource = null;
                    gridItensPedido.DataSource = itens; // Atualiza a grid de itens
                }
            }
        }

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationDBContext())
            {
                var pedidoRepo = new PedidoRepository(db);

                // Se o pedidoSelecionado não estiver instanciado (é nulo), criamos um novo
                if (pedidoSelecionado == null)
                {
                    pedidoSelecionado = new Pedido();
                }

                // Atualiza os dados do pedido
                pedidoSelecionado.Data = dateTimePickerDataPedido.Value.ToUniversalTime();
                pedidoSelecionado.Status = cmbBoxStatus.SelectedItem.ToString();
                pedidoSelecionado.ClienteId = (int)cmbBoxCliente.SelectedValue;
                pedidoSelecionado.Itens = ((BindingList<ItemPedido>)gridItensPedido.DataSource).ToList();

                // Salva ou atualiza o pedido
                if (pedidoSelecionado.Id > 0)
                {
                    pedidoRepo.Update(pedidoSelecionado); // Atualiza pedido existente
                }
                else
                {
                    pedidoRepo.Create(pedidoSelecionado); // Cria um novo pedido
                }
            }

            // Recarrega a lista de pedidos e volta para a aba de consulta
            LoadPedidos();
            tabPedido.SelectTab(tabPedidoConsulta);
            MessageBox.Show("Pedido salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluirPedido_Click(object sender, EventArgs e)
        {
            if (gridPedidos.SelectedRows.Count > 0)
            {
                int pedidoId = (int)gridPedidos.SelectedRows[0].Cells["Id"].Value;

                try
                {
                    // Exclui o pedido
                    _pedidoRepository.Delete(pedidoId);
                    LoadPedidos();
                    tabPedido.SelectTab(tabPedidoConsulta);
                    MessageBox.Show("Pedido excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o pedido: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um pedido para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
