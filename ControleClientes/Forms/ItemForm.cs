using ControleClientes.Entidades;
using ControleClientes.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleClientes.Forms
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            LoadProdutos();
        }

        private void LoadProdutos()
        {
            using (var db = new ApplicationDBContext())
            {
                cmbBoxProduto.DataSource = new ProdutoRepository(db).ReadAll();
                cmbBoxProduto.DisplayMember = "Nome";
                cmbBoxProduto.ValueMember = "Id";
            }
        }

        private void btnSalvarItem_Click(object sender, EventArgs e)
        {
            if (cmbBoxProduto.SelectedValue != null && numericUpDownQuantidade.Value > 0)
            {
                Produto produtoSelecionado = (Produto)cmbBoxProduto.SelectedItem;

                ItemPedido item = new ItemPedido
                {
                    ProdutoId = produtoSelecionado.Id,
                    Produto = null, //produtoSelecionado,
                    Quantidade = (int)numericUpDownQuantidade.Value,
                    PrecoUnitario = produtoSelecionado.Preco
                };

                this.Tag = item;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um produto e uma quantidade válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}