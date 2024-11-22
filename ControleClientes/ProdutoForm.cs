using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleClientes
{
    // ProdutoForm.cs
    public partial class ProdutoForm : Form
    {
        private ProdutoRepository _produtoRepository;

        public ProdutoForm()
        {
            InitializeComponent();
            _produtoRepository = new ProdutoRepository(new ApplicationDBContext());
            //AtualizarGridProdutos();
        }

        // Método para salvar o produto
        private void SalvarProduto()
        {
            if (string.IsNullOrEmpty(textBoxNomeProd.Text) || string.IsNullOrEmpty(textBoxDescProd.Text) ||
                string.IsNullOrEmpty(textBoxPrecoProd.Text) || string.IsNullOrEmpty(textBoxQtdeProd.Text) ||
                string.IsNullOrEmpty(textBoxCatProd.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            var produto = new Produto
            {
                Nome = textBoxNomeProd.Text,
                Descricao = textBoxDescProd.Text,
                Preco = decimal.Parse(textBoxPrecoProd.Text),
                QuantidadeEstoque = int.Parse(textBoxQtdeProd.Text),
                Categoria = textBoxCatProd.Text
            };

            _produtoRepository.AdicionarProduto(produto);  // Chama o método do repositório para adicionar o produto

            MessageBox.Show("Produto cadastrado com sucesso!");
            //AtualizarGridProdutos(); // Atualiza a grid de consulta de produtos
        }

        //// Método para excluir o produto
        //private void ExcluirProduto()
        //{
        //    if (gridConsultaProdutos.SelectedRows.Count == 0)
        //    {
        //        MessageBox.Show("Selecione um produto para excluir.");
        //        return;
        //    }

        //    var produtoId = (int)gridConsultaProdutos.SelectedRows[0].Cells["ProdutoId"].Value;

        //    _produtoRepository.ExcluirProduto(produtoId);  // Chama o método do repositório para excluir o produto

        //    MessageBox.Show("Produto excluído com sucesso!");
        //    AtualizarGridProdutos(); // Atualiza a grid após a exclusão
        //}

        // Método para atualizar a grid de produtos
        //private void AtualizarGridProdutos()
        //{
        //    var produtos = _produtoRepository.ListarProdutos();  // Chama o método do repositório para listar os produtos
        //    gridProduto.DataSource = produtos;
        //}

        // Método do botão Salvar

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            SalvarProduto();
        }

        //private void gridProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    gridProduto.Rows.Clear();
        //    foreach (var produto in _produtoRepository.ReadAll())
        //    {
        //        gridProduto.Rows.Add(produto.Id, produto.Nome, produto.Descricao, produto.Preco, 
        //            produto.QuantidadeEstoque, produto.Categoria);
        //    }
        //}

        // Método do botão Excluir
        //private void btnExcluir_Click(object sender, EventArgs e)
        //{
        //    ExcluirProduto();
        //}
    }

}
