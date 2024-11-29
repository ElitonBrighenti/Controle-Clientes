using ControleClientes.Entidades;
using ControleClientes.Forms;
using ControleClientes.Repository;
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
            // Configurar grid de itens
            ConfigurarGridItens();

            // Inicializar grid com lista vazia
            gridItensPedido.DataSource = new BindingList<ItemPedido>();
        }
        private void CarregarDados()
        {
            cmbBoxCliente.DataSource = _clienteRepository.ReadAll(); // Assumindo que o ClienteRepository está implementado corretamente
            cmbBoxCliente.DisplayMember = "Nome";
            cmbBoxCliente.ValueMember = "Id";
            cmbBoxStatus.DataSource = new List<string> { "Pendente", "Concluído", "Cancelado" };
        }

        private void LoadPedidos()
        {
            using (var db = new ApplicationDBContext())
            {
                gridPedidos.DataSource = new PedidoRepository(db).ReadAll();
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (gridPedidos.SelectedRows.Count > 0)
            {
                int pedidoId = (int)gridPedidos.SelectedRows[0].Cells["Id"].Value;
                CarregarPedidoParaEdicao(pedidoId);
            }
        }
        private void CarregarPedidoParaEdicao(int pedidoId)
        {
            //using (var db = new ApplicationDBContext())
            //{
            //    Pedido pedido = new PedidoRepository(db).GetById(pedidoId);
            //    if (pedido != null)
            //    {
            //        cmbCliente.SelectedValue = pedido.ClienteId;
            //        dtpData.Value = pedido.Data;
            //        cmbStatus.SelectedItem = pedido.Status;

            //        gridItens.DataSource = pedido.Itens;
            //        tabControl1.SelectTab("tabCadastro");
            //    }
            //}
        }
        private void btnNovoProd_Click(object sender, EventArgs e)
        {
            tabPedido.SelectTab(tabPedidoCadastro);
            //ClearCadastro();
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using (ItemForm itemForm = new ItemForm())
            {
                if (itemForm.ShowDialog() == DialogResult.OK)
                {
                    ItemPedido novoItem = (ItemPedido)itemForm.Tag;

                    // Obter a lista atual de itens do pedido
                    var itens = (BindingList<ItemPedido>)gridItensPedido.DataSource;

                    // Adicionar o novo item à lista
                    itens.Add(novoItem);

                    // Atualizar a grid
                    gridItensPedido.DataSource = null;
                    gridItensPedido.DataSource = itens;
                }
            }
        }
        private void ConfigurarGridItens()
        {
            gridItensPedido.AutoGenerateColumns = false;

            gridItensPedido.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Produto",
                DataPropertyName = "Produto.Nome"
            });

            gridItensPedido.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantidade",
                DataPropertyName = "Quantidade"
            });

            gridItensPedido.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Preço Unitário",
                DataPropertyName = "PrecoUnitario",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            gridItensPedido.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Subtotal",
                DataPropertyName = "Subtotal",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
        }
        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationDBContext())
            {
                PedidoRepository pedidoRepo = new PedidoRepository(db);

                Pedido pedido = new Pedido
                {
                    Data = dateTimePickerDataPedido.Value.ToUniversalTime(),
                    Status = cmbBoxStatus.SelectedItem.ToString(),
                    ClienteId = (int)cmbBoxCliente.SelectedValue,
                    Itens = (BindingList<ItemPedido>)gridItensPedido.DataSource
                };

                if (pedido.Id == 0)
                {
                    // Criação de novo pedido
                    pedidoRepo.Create(pedido);
                }
                else
                {
                    // Atualização de pedido existente
                    pedidoRepo.Update(pedido);
                }
            }

            LoadPedidos();
            tabPedido.SelectTab(tabPedidoConsulta);
        }
        private void btnVisualizar_Click_1(object sender, EventArgs e)
        {
            if (gridPedidos.SelectedRows.Count > 0)
            {
                int pedidoId = (int)gridPedidos.SelectedRows[0].Cells["Id"].Value;

                using (var db = new ApplicationDBContext())
                {
                    Pedido pedido = new PedidoRepository(db).GetById(pedidoId);

                    if (pedido != null)
                    {
                        // Preenche os campos da aba Cadastro

                        cmbBoxCliente.SelectedValue = pedido.ClienteId;
                        dateTimePickerDataPedido.Value = pedido.Data.ToLocalTime();
                        cmbBoxStatus.SelectedItem = pedido.Status;

                        // Preenche a grid de itens
                        //gridItensPedido.DataSource = new BindingList<ItemPedido>(pedido.Itens);

                        // Navega para a aba de Cadastro
                        tabPedido.SelectTab(tabPedidoCadastro);
                    }
                    else
                    {
                        MessageBox.Show("Pedido não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um pedido para visualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
