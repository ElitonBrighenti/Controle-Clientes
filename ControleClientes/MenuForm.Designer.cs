namespace ControleClientes
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            cidadesToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem1 = new ToolStripMenuItem();
            janelaToolStripMenuItem = new ToolStripMenuItem();
            cascataToolStripMenuItem = new ToolStripMenuItem();
            ladoALadoHorizontalToolStripMenuItem = new ToolStripMenuItem();
            ladoALadoVerticalToolStripMenuItem = new ToolStripMenuItem();
            íconesMinimizadosToolStripMenuItem = new ToolStripMenuItem();
            gerenciarToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, janelaToolStripMenuItem, gerenciarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(947, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, cidadesToolStripMenuItem, pedidosToolStripMenuItem1 });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(82, 24);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(224, 26);
            clienteToolStripMenuItem.Text = "Clientes";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // cidadesToolStripMenuItem
            // 
            cidadesToolStripMenuItem.Name = "cidadesToolStripMenuItem";
            cidadesToolStripMenuItem.Size = new Size(224, 26);
            cidadesToolStripMenuItem.Text = "Cidades";
            cidadesToolStripMenuItem.Click += cidadesToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem1
            // 
            pedidosToolStripMenuItem1.Name = "pedidosToolStripMenuItem1";
            pedidosToolStripMenuItem1.Size = new Size(224, 26);
            pedidosToolStripMenuItem1.Text = "Pedidos";
            pedidosToolStripMenuItem1.Click += pedidosToolStripMenuItem1_Click;
            // 
            // janelaToolStripMenuItem
            // 
            janelaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascataToolStripMenuItem, ladoALadoHorizontalToolStripMenuItem, ladoALadoVerticalToolStripMenuItem, íconesMinimizadosToolStripMenuItem });
            janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            janelaToolStripMenuItem.Size = new Size(64, 24);
            janelaToolStripMenuItem.Text = "Janela";
            // 
            // cascataToolStripMenuItem
            // 
            cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            cascataToolStripMenuItem.Size = new Size(242, 26);
            cascataToolStripMenuItem.Text = "Cascata";
            cascataToolStripMenuItem.Click += cascataToolStripMenuItem_Click;
            // 
            // ladoALadoHorizontalToolStripMenuItem
            // 
            ladoALadoHorizontalToolStripMenuItem.Name = "ladoALadoHorizontalToolStripMenuItem";
            ladoALadoHorizontalToolStripMenuItem.Size = new Size(242, 26);
            ladoALadoHorizontalToolStripMenuItem.Text = "Lado a lado horizontal";
            ladoALadoHorizontalToolStripMenuItem.Click += ladoALadoHorizontalToolStripMenuItem_Click;
            // 
            // ladoALadoVerticalToolStripMenuItem
            // 
            ladoALadoVerticalToolStripMenuItem.Name = "ladoALadoVerticalToolStripMenuItem";
            ladoALadoVerticalToolStripMenuItem.Size = new Size(242, 26);
            ladoALadoVerticalToolStripMenuItem.Text = "Lado a lado vertical";
            ladoALadoVerticalToolStripMenuItem.Click += ladoALadoVerticalToolStripMenuItem_Click;
            // 
            // íconesMinimizadosToolStripMenuItem
            // 
            íconesMinimizadosToolStripMenuItem.Name = "íconesMinimizadosToolStripMenuItem";
            íconesMinimizadosToolStripMenuItem.Size = new Size(242, 26);
            íconesMinimizadosToolStripMenuItem.Text = " Ícones minimizados";
            íconesMinimizadosToolStripMenuItem.Click += íconesMinimizadosToolStripMenuItem_Click;
            // 
            // gerenciarToolStripMenuItem
            // 
            gerenciarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pedidosToolStripMenuItem });
            gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            gerenciarToolStripMenuItem.Size = new Size(86, 24);
            gerenciarToolStripMenuItem.Text = "Gerenciar";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(144, 26);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 615);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuForm";
            Text = "MenuForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem janelaToolStripMenuItem;
        private ToolStripMenuItem cascataToolStripMenuItem;
        private ToolStripMenuItem ladoALadoHorizontalToolStripMenuItem;
        private ToolStripMenuItem ladoALadoVerticalToolStripMenuItem;
        private ToolStripMenuItem íconesMinimizadosToolStripMenuItem;
        private ToolStripMenuItem cidadesToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem1;
        private ToolStripMenuItem gerenciarToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
    }
}