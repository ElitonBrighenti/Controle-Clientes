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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm cliente = new ClienteForm();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void ladoALadoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ladoALadoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void íconesMinimizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CidadeForm cidade = new CidadeForm();
            cidade.MdiParent = this;
            cidade.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoForm pedido = new PedidoForm();
            pedido.MdiParent = this;
            pedido.Show();
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProdutoForm produto = new ProdutoForm();
            produto.MdiParent = this;
            produto.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
