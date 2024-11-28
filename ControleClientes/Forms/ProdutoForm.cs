using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleClientes.Entidades;
using ControleClientes.Repository;

namespace ControleClientes
{
    // ProdutoForm.cs
    public partial class ProdutoForm : Form
    {
        private Produto produtoSelecionado;
        private ProdutoRepository _produtoRepository;
        public ProdutoForm()
        {
            InitializeComponent();
            _produtoRepository = new ProdutoRepository(new ApplicationDBContext());
            LoadData();
        }
        private void LoadData()
        {
            gridProduto.Rows.Clear();
            foreach (var produto in _produtoRepository.ReadAll())
            {
                gridProduto.Rows.Add(produto.Id, produto.Nome, produto.Descricao, produto.Preco,
                    produto.QuantidadeEstoque, produto.Categoria);
            }
        }

        // Método para salvar o produto
        private void SalvarProduto()
        {
            if (!ValidarCampos())
                return;

            if (produtoSelecionado == null)
            {
                var produto = new Produto
                {
                    Nome = textBoxNomeProd.Text,
                    Descricao = textBoxDescProd.Text,
                    Preco = decimal.Parse(textBoxPrecoProd.Text),
                    QuantidadeEstoque = int.Parse(textBoxQtdeProd.Text),
                    Categoria = textBoxCatProd.Text,
                };
                _produtoRepository.Create(produto);
            }
            else
            {
                produtoSelecionado.Nome = textBoxNomeProd.Text;
                produtoSelecionado.Descricao = textBoxDescProd.Text;
                produtoSelecionado.Preco = decimal.Parse(textBoxPrecoProd.Text);
                produtoSelecionado.QuantidadeEstoque = int.Parse(textBoxQtdeProd.Text);
                produtoSelecionado.Categoria = textBoxCatProd.Text;

                _produtoRepository.Update(produtoSelecionado);
            }

            LoadData();
            MessageBox.Show("Produto cadastrado com sucesso!");
            LimparCampos();
            tabProduto.SelectTab(tabProdutoConsulta);
        }
        private void ExcluirProduto()
        {
            if (produtoSelecionado != null)
            {
                var confirmacao = MessageBox.Show(
                    $"Deseja realmente excluir o produto '{produtoSelecionado.Nome}'?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    _produtoRepository.Delete(produtoSelecionado);
                    LoadData();
                    MessageBox.Show("Produto excluído com sucesso!");
                    tabProduto.SelectTab(tabProdutoConsulta);
                }
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado para exclusão.");
            }
        }

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            SalvarProduto();
        }

        private void btnNovoProd_Click(object sender, EventArgs e)
        {
            produtoSelecionado = null;
            tabProduto.SelectTab(tabProdutoCadastro);
        }

        private void btnVisualizar_Click_1(object sender, EventArgs e)
        {
            if (gridProduto.SelectedRows.Count > 0)
            {
                int id = (int)gridProduto.SelectedRows[0].Cells[0].Value;
                produtoSelecionado = _produtoRepository.GetById(id);
                textBoxNomeProd.Text = produtoSelecionado.Nome;
                textBoxDescProd.Text = produtoSelecionado.Descricao;
                textBoxPrecoProd.Text = produtoSelecionado.Preco.ToString();
                textBoxQtdeProd.Text = produtoSelecionado.QuantidadeEstoque.ToString();
                textBoxCatProd.Text = produtoSelecionado.Categoria.ToString();
                tabProduto.SelectTab(tabProdutoCadastro);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabProduto.SelectTab(tabProdutoConsulta);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirProduto();
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBoxNomeProd.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescProd.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrecoProd.Text) ||
                string.IsNullOrWhiteSpace(textBoxQtdeProd.Text) ||
                string.IsNullOrWhiteSpace(textBoxCatProd.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios.");
                return false;
            }

            if (!decimal.TryParse(textBoxPrecoProd.Text, out _))
            {
                MessageBox.Show("Preço deve ser um valor decimal válido.");
                return false;
            }

            if (!int.TryParse(textBoxQtdeProd.Text, out _))
            {
                MessageBox.Show("Quantidade deve ser um número inteiro válido.");
                return false;
            }

            return true;
        }
        private void LimparCampos()
        {
            textBoxNomeProd.Clear();
            textBoxDescProd.Clear();
            textBoxPrecoProd.Clear();
            textBoxQtdeProd.Clear();
            textBoxCatProd.Clear();
        }

        private void ProdutoForm_Load(object sender, EventArgs e)
        {

        }
    }

}
