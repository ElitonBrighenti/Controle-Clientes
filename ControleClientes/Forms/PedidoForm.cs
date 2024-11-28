using ControleClientes.Entidades;
using ControleClientes.Forms;
using ControleClientes.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ControleClientes
{
    public partial class PedidoForm : Form
    {
        private readonly ClienteRepository _clienteRepository;
        private readonly PedidoRepository _pedidoRepository;
        private readonly ItemRepository _itemRepository;
        private Pedido _pedido;

        public PedidoForm()
        {
            InitializeComponent();
            _pedidoRepository = new PedidoRepository(new ApplicationDBContext());
            _itemRepository = new ItemRepository(new ApplicationDBContext());
            _clienteRepository = new ClienteRepository();
            _pedido = new Pedido();
            CarregarDados();
        }

        private void CarregarDados()
        {
            cmbBoxCliente.DataSource = _clienteRepository.ReadAll(); // Assumindo que o ClienteRepository está implementado corretamente
            cmbBoxCliente.DisplayMember = "Nome";
            cmbBoxCliente.ValueMember = "Id";
            cmbBoxStatus.DataSource = new List<string> { "Pendente", "Concluído", "Cancelado" };
        }
        // Método para limpar os campos de cadastro
        private void LimparCamposCadastro()
        {
            cmbBoxCliente.SelectedIndex = -1;
            dateTimePickerDataPedido.Value = DateTime.Now;
            cmbBoxStatus.SelectedIndex = -1;
            gridItensPedido.DataSource = null;
        }

        // Método para preencher os campos do pedido na tela de cadastro
        private void PreencherCamposCadastro()
        {
            cmbBoxCliente.SelectedValue = _pedido.ClienteId;
            dateTimePickerDataPedido.Value = _pedido.DataPedido;
            cmbBoxStatus.SelectedItem = _pedido.Status;

            // Carregar os itens do pedido no grid
            //gridItensPedido.DataSource = _pedido.Item?.Produtos;
        }
        //FIRST
        private void btnNovoProd_Click(object sender, EventArgs e)
        {
            _pedido = new Pedido(); // Limpar a seleção para um novo pedido
            LimparCamposCadastro();
            tabPedido.SelectTab(tabPedidoCadastro);
        }

        private void btnVisualizar_Click_1(object sender, EventArgs e)
        {
            //var pedidoId = Convert.ToInt32(gridPedidos.SelectedRows[0].Cells[0].Value);
            //_pedido = _pedidoRepository.GetById(pedidoId);
            //PreencherCamposCadastro();
            //tabPedido.SelectTab(tabPedidoCadastro);
        }


        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            _pedido.ClienteId = Convert.ToInt32(cmbBoxCliente.SelectedValue);
            _pedido.DataPedido = dateTimePickerDataPedido.Value;
            _pedido.Status = cmbBoxStatus.SelectedItem.ToString();

            if (_pedido.Id == 0)  // Se o pedido não tem ID, é novo
            {
                _pedidoRepository.Create(_pedido);
            }
            else
            {
                _pedidoRepository.Update(_pedido);
            }
        }
        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
                    // Abrir o formulário de Item, passando o pedido
            ItemForm itemForm = new ItemForm(_pedido);
            itemForm.ShowDialog();

            // Atualizar os itens na DataGridView após adicionar um novo item
            gridItensPedido.DataSource = null;
            gridItensPedido.DataSource = _pedido.Itens;
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            tabPedido.SelectTab(tabPedidoConsulta);
        }
    }
}
