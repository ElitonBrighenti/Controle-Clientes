namespace ControleClientes.Forms
{
    partial class ItemForm
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
            ProdItemLbl = new Label();
            QtdeItemLbl = new Label();
            cmbBoxProduto = new ComboBox();
            pnlAcaoPedido = new Panel();
            btnSalvarItem = new Button();
            numericUpDownQuantidade = new NumericUpDown();
            pnlAcaoPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            SuspendLayout();
            // 
            // ProdItemLbl
            // 
            ProdItemLbl.AutoSize = true;
            ProdItemLbl.Location = new Point(23, 28);
            ProdItemLbl.Name = "ProdItemLbl";
            ProdItemLbl.Size = new Size(129, 20);
            ProdItemLbl.TabIndex = 0;
            ProdItemLbl.Text = "Nome do Produto";
            // 
            // QtdeItemLbl
            // 
            QtdeItemLbl.AutoSize = true;
            QtdeItemLbl.Location = new Point(285, 28);
            QtdeItemLbl.Name = "QtdeItemLbl";
            QtdeItemLbl.Size = new Size(87, 20);
            QtdeItemLbl.TabIndex = 1;
            QtdeItemLbl.Text = "Quantidade";
            // 
            // cmbBoxProduto
            // 
            cmbBoxProduto.FormattingEnabled = true;
            cmbBoxProduto.Location = new Point(23, 62);
            cmbBoxProduto.Name = "cmbBoxProduto";
            cmbBoxProduto.Size = new Size(214, 28);
            cmbBoxProduto.TabIndex = 2;
            cmbBoxProduto.SelectedIndexChanged += cmbBoxProduto_SelectedIndexChanged;
            // 
            // pnlAcaoPedido
            // 
            pnlAcaoPedido.AutoSize = true;
            pnlAcaoPedido.Controls.Add(btnSalvarItem);
            pnlAcaoPedido.Dock = DockStyle.Bottom;
            pnlAcaoPedido.Location = new Point(0, 200);
            pnlAcaoPedido.Margin = new Padding(3, 4, 3, 4);
            pnlAcaoPedido.Name = "pnlAcaoPedido";
            pnlAcaoPedido.Size = new Size(487, 39);
            pnlAcaoPedido.TabIndex = 6;
            // 
            // btnSalvarItem
            // 
            btnSalvarItem.Location = new Point(381, 4);
            btnSalvarItem.Margin = new Padding(3, 4, 3, 4);
            btnSalvarItem.Name = "btnSalvarItem";
            btnSalvarItem.Size = new Size(103, 31);
            btnSalvarItem.TabIndex = 0;
            btnSalvarItem.Text = "Adicionar";
            btnSalvarItem.UseVisualStyleBackColor = true;
            btnSalvarItem.Click += btnSalvarItem_Click;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(285, 59);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(150, 27);
            numericUpDownQuantidade.TabIndex = 7;
            // 
            // ItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 239);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(pnlAcaoPedido);
            Controls.Add(cmbBoxProduto);
            Controls.Add(QtdeItemLbl);
            Controls.Add(ProdItemLbl);
            Name = "ItemForm";
            Text = "ItemForm";
            Load += ItemForm_Load;
            pnlAcaoPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProdItemLbl;
        private Label QtdeItemLbl;
        private ComboBox cmbBoxProduto;
        private Panel pnlAcaoPedido;
        private NumericUpDown numericUpDownQuantidade;
        private Button btnSalvarItem;
    }
}