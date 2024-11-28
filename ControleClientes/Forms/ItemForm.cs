using ControleClientes.Entidades;
using ControleClientes.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleClientes.Forms
{
    public partial class ItemForm : Form
    {
        private readonly ItemRepository _itemRepository;
        private readonly ProdutoRepository _produtoRepository;
        private Pedido _pedido = null;

        // Listas para armazenar os produtos e as quantidades no item
        private List<Produto> _produtosNoItem = new List<Produto>();
        private List<int> _quantidadesNoItem = new List<int>();

        public ItemForm(Pedido pedido)
        {
            InitializeComponent();
            _itemRepository = new ItemRepository(new ApplicationDBContext());
            _produtoRepository = new ProdutoRepository(new ApplicationDBContext());
            _pedido = pedido;
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            cmbBoxProduto.DataSource = _produtoRepository.ReadAll();
            cmbBoxProduto.DisplayMember = "Nome";
            cmbBoxProduto.ValueMember = "Id";
        }

        // Cancelar e fechar o form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            // Verifica se o produto foi selecionado
            if (cmbBoxProduto.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            var produtoSelecionado = (Produto)cmbBoxProduto.SelectedItem;

            // Verifica se a quantidade foi informada corretamente
            if (int.TryParse(numericUpDownQuantidade.Text, out int quantidadeSelecionada) && quantidadeSelecionada > 0)
            {
                // Adiciona o produto e a quantidade às listas
                _produtosNoItem.Add(produtoSelecionado);
                _quantidadesNoItem.Add(quantidadeSelecionada);

                // Atualiza a interface para exibir os produtos e quantidades
                ///AtualizarListaProdutosQuantidades();
            }
            else
            {
                MessageBox.Show("Informe uma quantidade válida.");
            }

            // Atualizar a exibição dos itens na grid
            //AtualizarGridItens();
        }

        private void btnSalvarItem_Click(object sender, EventArgs e)
        {
            // Verifica se o pedido foi selecionado
            if (_pedido == null)
            {
                MessageBox.Show("Selecione um pedido para adicionar o item.");
                return;
            }

            // Verifica se a lista de produtos e quantidades não está vazia
            if (_produtosNoItem.Count == 0 || _quantidadesNoItem.Count == 0)
            {
                MessageBox.Show("Adicione produtos ao item antes de salvar.");
                return;
            }

            // Criar o novo item para o pedido
            var item = new Item
            {
                PedidoId = _pedido.Id,  // Associando o item ao pedido existente
                Produtos = _produtosNoItem,  // Associando os produtos ao item
                Quantidades = _quantidadesNoItem  // Associando as quantidades aos produtos
            };

            // Salvar o item no banco de dados
            _itemRepository.Create(item);

            // Adicionar o item ao pedido
            _pedido.Itens.Add(item);  // Isso é opcional, pois o item já está salvo no banco

            // Exibir a mensagem de sucesso
            MessageBox.Show("Item salvo com sucesso!");

            // Limpar os dados das listas e atualizar a interface
            _produtosNoItem.Clear();
            _quantidadesNoItem.Clear();
            //AtualizarListaProdutosQuantidades();  // Atualizar a interface para refletir a mudança

        }
    }
}