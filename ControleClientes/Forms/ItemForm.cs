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

        #region Carregar Dados

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

        #endregion

        #region Botões

        private void btnSalvarItem_Click(object sender, EventArgs e)
        {
            if (cmbBoxProduto.SelectedValue != null && numericUpDownQuantidade.Value > 0)
            {
                Produto produtoSelecionado = (Produto)cmbBoxProduto.SelectedItem;

                ItemPedido item = new ItemPedido
                {
                    ProdutoId = produtoSelecionado.Id,
                    Produto = null, // Produto não é carregado diretamente, pode ser necessário carregar os detalhes de produto
                    Quantidade = (int)numericUpDownQuantidade.Value,
                    PrecoUnitario = produtoSelecionado.Preco
                };

                this.Tag = item; // Passando o item para o form principal
                this.DialogResult = DialogResult.OK; // Fechando o form com sucesso
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um produto e uma quantidade válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Métodos de Controle de Interface

        private void cmbBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aqui você pode adicionar lógica adicional para quando o produto for alterado, 
            // caso queira atualizar os preços ou outros campos do item.
        }

        #endregion
    }

}