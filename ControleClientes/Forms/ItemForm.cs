using ControleClientes.Entidades;
using ControleClientes.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleClientes.Forms
{
    public partial class ItemForm : Form
    {
        public static List<Produto> ProdutosDisponiveis { get; set; }


        private ProdutoRepository _produtoRepository;
        private Produto produtoSelecionado;
        public Item ItemSelecionado { get; set; }

        // Construtor
        //public ItemForm(IQueryable<Produto> produtos)
        //{
        //    InitializeComponent();
        //    _produtoRepository = new ProdutoRepository(new ApplicationDBContext());
        //    cmbBoxProduto.DataSource = produtos.ToList();  // Passa a lista de produtos para o comboBox
        //    cmbBoxProduto.DisplayMember = "Nome";
        //    cmbBoxProduto.ValueMember = "Id";
        //}
        public ItemForm()
        {
            InitializeComponent();
            // A lista de produtos pode ser acessada diretamente de ProdutosDisponiveis
            cmbBoxProduto.DataSource = ProdutosDisponiveis;
            cmbBoxProduto.DisplayMember = "Nome";  // Exibe o nome do produto no comboBox
            cmbBoxProduto.ValueMember = "Id";  // Usa o ID do produto como valor para o banco
        }


        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            this.Close();  // Fecha o ItemForm sem salvar
        }

        private void btnSalvarItem_Click_1(object sender, EventArgs e)
        {
            //if (cmbBoxProduto.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtQuantidade.Text))
            //{
            //    MessageBox.Show("Por favor, selecione um produto e informe a quantidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Cria o item com base nos dados preenchidos
            //produtoSelecionado = (Produto)cmbBoxProduto.SelectedItem;
            //var quantidade = int.Parse(txtQuantidade.Text);
            //var precoUnitario = produtoSelecionado.Preco;  // Preço do produto
            //var item = new Item
            //{
            //    ProdutoId = produtoSelecionado.Id,
            //    Quantidade = quantidade,
            //    PrecoUnitario = precoUnitario
            //};

            // Verifica se o produto foi selecionado
            var produtoSelecionado = cmbBoxProduto.SelectedItem as Produto;
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione um produto válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criação do item
            var item = new Item
            {
                Produto = produtoSelecionado,  // Atribui o produto ao item
                Quantidade = Convert.ToInt32(txtQuantidade.Text),  // Obtém a quantidade do textbox
                PrecoUnitario = produtoSelecionado.Preco,  // Supondo que o preço esteja no produto
            };

            ItemSelecionado = item;  // Atribui o item à propriedade

            this.DialogResult = DialogResult.OK;  // Retorna OK para o PedidoForm
            this.Close();  // Fecha o ItemForm
        }
    }
}
