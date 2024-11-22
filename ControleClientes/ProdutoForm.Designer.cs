namespace ControleClientes
{
    partial class ProdutoForm
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
            gridProduto = new DataGridView();
            pnlPesquisa = new Panel();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            pnlAcao = new Panel();
            btnVisualizar = new Button();
            btnNovo = new Button();
            tpCidadeConsulta = new TabPage();
            btnCancelar = new Button();
            pnlAcaoCadastro = new Panel();
            btnExcluir = new Button();
            btnSalvar = new Button();
            textBoxNomeProd = new TextBox();
            NameProdLbl = new Label();
            tpCidadeCadastro = new TabPage();
            textBoxCatProd = new TextBox();
            CatProdLbl = new Label();
            textBoxQtdeProd = new TextBox();
            QtdeProdLbl = new Label();
            textBoxPrecoProd = new TextBox();
            PrecoProdLbl = new Label();
            textBoxDescProd = new TextBox();
            DescProdLbl = new Label();
            tabCidade = new TabControl();
            GridProdID = new DataGridViewTextBoxColumn();
            GridProdNome = new DataGridViewTextBoxColumn();
            GridProdDesc = new DataGridViewTextBoxColumn();
            GridProdPreco = new DataGridViewTextBoxColumn();
            GridProdQuantidade = new DataGridViewTextBoxColumn();
            GridProdCat = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridProduto).BeginInit();
            pnlPesquisa.SuspendLayout();
            pnlAcao.SuspendLayout();
            tpCidadeConsulta.SuspendLayout();
            pnlAcaoCadastro.SuspendLayout();
            tpCidadeCadastro.SuspendLayout();
            tabCidade.SuspendLayout();
            SuspendLayout();
            // 
            // gridProduto
            // 
            gridProduto.AllowUserToOrderColumns = true;
            gridProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProduto.Columns.AddRange(new DataGridViewColumn[] { GridProdID, GridProdNome, GridProdDesc, GridProdPreco, GridProdQuantidade, GridProdCat });
            gridProduto.Dock = DockStyle.Fill;
            gridProduto.Location = new Point(3, 45);
            gridProduto.Margin = new Padding(3, 4, 3, 4);
            gridProduto.Name = "gridProduto";
            gridProduto.RowHeadersWidth = 20;
            gridProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridProduto.Size = new Size(889, 355);
            gridProduto.TabIndex = 7;
            // 
            // pnlPesquisa
            // 
            pnlPesquisa.Controls.Add(btnPesquisar);
            pnlPesquisa.Controls.Add(txtPesquisa);
            pnlPesquisa.Dock = DockStyle.Top;
            pnlPesquisa.Location = new Point(3, 4);
            pnlPesquisa.Margin = new Padding(3, 4, 3, 4);
            pnlPesquisa.Name = "pnlPesquisa";
            pnlPesquisa.Size = new Size(889, 41);
            pnlPesquisa.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(753, 4);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(129, 31);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(5, 6);
            txtPesquisa.Margin = new Padding(3, 4, 3, 4);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar por nome";
            txtPesquisa.Size = new Size(746, 27);
            txtPesquisa.TabIndex = 2;
            // 
            // pnlAcao
            // 
            pnlAcao.Controls.Add(btnVisualizar);
            pnlAcao.Controls.Add(btnNovo);
            pnlAcao.Dock = DockStyle.Bottom;
            pnlAcao.Location = new Point(3, 400);
            pnlAcao.Margin = new Padding(3, 4, 3, 4);
            pnlAcao.Name = "pnlAcao";
            pnlAcao.Size = new Size(889, 41);
            pnlAcao.TabIndex = 6;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Location = new Point(702, 7);
            btnVisualizar.Margin = new Padding(3, 4, 3, 4);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(86, 31);
            btnVisualizar.TabIndex = 0;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(794, 7);
            btnNovo.Margin = new Padding(3, 4, 3, 4);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(86, 31);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // tpCidadeConsulta
            // 
            tpCidadeConsulta.Controls.Add(gridProduto);
            tpCidadeConsulta.Controls.Add(pnlAcao);
            tpCidadeConsulta.Controls.Add(pnlPesquisa);
            tpCidadeConsulta.Location = new Point(4, 29);
            tpCidadeConsulta.Margin = new Padding(3, 4, 3, 4);
            tpCidadeConsulta.Name = "tpCidadeConsulta";
            tpCidadeConsulta.Padding = new Padding(3, 4, 3, 4);
            tpCidadeConsulta.Size = new Size(895, 445);
            tpCidadeConsulta.TabIndex = 0;
            tpCidadeConsulta.Text = "Consulta";
            tpCidadeConsulta.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(794, 3);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pnlAcaoCadastro
            // 
            pnlAcaoCadastro.Controls.Add(btnExcluir);
            pnlAcaoCadastro.Controls.Add(btnCancelar);
            pnlAcaoCadastro.Controls.Add(btnSalvar);
            pnlAcaoCadastro.Dock = DockStyle.Bottom;
            pnlAcaoCadastro.Location = new Point(3, 404);
            pnlAcaoCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlAcaoCadastro.Name = "pnlAcaoCadastro";
            pnlAcaoCadastro.Size = new Size(889, 37);
            pnlAcaoCadastro.TabIndex = 5;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(6, 4);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(86, 31);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(702, 3);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 31);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvarProd_Click;
            // 
            // textBoxNomeProd
            // 
            textBoxNomeProd.Location = new Point(29, 60);
            textBoxNomeProd.Margin = new Padding(3, 4, 3, 4);
            textBoxNomeProd.Name = "textBoxNomeProd";
            textBoxNomeProd.Size = new Size(250, 27);
            textBoxNomeProd.TabIndex = 7;
            // 
            // NameProdLbl
            // 
            NameProdLbl.AutoSize = true;
            NameProdLbl.Location = new Point(29, 36);
            NameProdLbl.Name = "NameProdLbl";
            NameProdLbl.Size = new Size(131, 20);
            NameProdLbl.TabIndex = 6;
            NameProdLbl.Text = "Nome Do Produto";
            // 
            // tpCidadeCadastro
            // 
            tpCidadeCadastro.Controls.Add(textBoxCatProd);
            tpCidadeCadastro.Controls.Add(CatProdLbl);
            tpCidadeCadastro.Controls.Add(textBoxQtdeProd);
            tpCidadeCadastro.Controls.Add(QtdeProdLbl);
            tpCidadeCadastro.Controls.Add(textBoxPrecoProd);
            tpCidadeCadastro.Controls.Add(PrecoProdLbl);
            tpCidadeCadastro.Controls.Add(textBoxDescProd);
            tpCidadeCadastro.Controls.Add(DescProdLbl);
            tpCidadeCadastro.Controls.Add(textBoxNomeProd);
            tpCidadeCadastro.Controls.Add(NameProdLbl);
            tpCidadeCadastro.Controls.Add(pnlAcaoCadastro);
            tpCidadeCadastro.Location = new Point(4, 29);
            tpCidadeCadastro.Margin = new Padding(3, 4, 3, 4);
            tpCidadeCadastro.Name = "tpCidadeCadastro";
            tpCidadeCadastro.Padding = new Padding(3, 4, 3, 4);
            tpCidadeCadastro.Size = new Size(895, 445);
            tpCidadeCadastro.TabIndex = 1;
            tpCidadeCadastro.Text = "Cadastro";
            tpCidadeCadastro.UseVisualStyleBackColor = true;
            // 
            // textBoxCatProd
            // 
            textBoxCatProd.Location = new Point(35, 284);
            textBoxCatProd.Margin = new Padding(3, 4, 3, 4);
            textBoxCatProd.Name = "textBoxCatProd";
            textBoxCatProd.Size = new Size(250, 27);
            textBoxCatProd.TabIndex = 17;
            // 
            // CatProdLbl
            // 
            CatProdLbl.AutoSize = true;
            CatProdLbl.Location = new Point(35, 260);
            CatProdLbl.Name = "CatProdLbl";
            CatProdLbl.Size = new Size(153, 20);
            CatProdLbl.TabIndex = 16;
            CatProdLbl.Text = "Categoria do Produto";
            // 
            // textBoxQtdeProd
            // 
            textBoxQtdeProd.Location = new Point(340, 170);
            textBoxQtdeProd.Margin = new Padding(3, 4, 3, 4);
            textBoxQtdeProd.Name = "textBoxQtdeProd";
            textBoxQtdeProd.Size = new Size(250, 27);
            textBoxQtdeProd.TabIndex = 15;
            // 
            // QtdeProdLbl
            // 
            QtdeProdLbl.AutoSize = true;
            QtdeProdLbl.Location = new Point(340, 146);
            QtdeProdLbl.Name = "QtdeProdLbl";
            QtdeProdLbl.Size = new Size(166, 20);
            QtdeProdLbl.TabIndex = 14;
            QtdeProdLbl.Text = "Quantidade do Produto";
            // 
            // textBoxPrecoProd
            // 
            textBoxPrecoProd.Location = new Point(35, 170);
            textBoxPrecoProd.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecoProd.Name = "textBoxPrecoProd";
            textBoxPrecoProd.Size = new Size(250, 27);
            textBoxPrecoProd.TabIndex = 13;
            // 
            // PrecoProdLbl
            // 
            PrecoProdLbl.AutoSize = true;
            PrecoProdLbl.Location = new Point(35, 146);
            PrecoProdLbl.Name = "PrecoProdLbl";
            PrecoProdLbl.Size = new Size(125, 20);
            PrecoProdLbl.TabIndex = 12;
            PrecoProdLbl.Text = "Preço do Produto";
            // 
            // textBoxDescProd
            // 
            textBoxDescProd.Location = new Point(340, 60);
            textBoxDescProd.Margin = new Padding(3, 4, 3, 4);
            textBoxDescProd.Name = "textBoxDescProd";
            textBoxDescProd.Size = new Size(250, 27);
            textBoxDescProd.TabIndex = 11;
            // 
            // DescProdLbl
            // 
            DescProdLbl.AutoSize = true;
            DescProdLbl.Location = new Point(340, 36);
            DescProdLbl.Name = "DescProdLbl";
            DescProdLbl.Size = new Size(153, 20);
            DescProdLbl.TabIndex = 10;
            DescProdLbl.Text = "Descrição do Produto";
            // 
            // tabCidade
            // 
            tabCidade.Controls.Add(tpCidadeConsulta);
            tabCidade.Controls.Add(tpCidadeCadastro);
            tabCidade.Dock = DockStyle.Fill;
            tabCidade.Location = new Point(0, 0);
            tabCidade.Margin = new Padding(3, 4, 3, 4);
            tabCidade.Name = "tabCidade";
            tabCidade.SelectedIndex = 0;
            tabCidade.Size = new Size(903, 478);
            tabCidade.TabIndex = 2;
            // 
            // GridProdID
            // 
            GridProdID.HeaderText = "ID";
            GridProdID.MinimumWidth = 6;
            GridProdID.Name = "GridProdID";
            // 
            // GridProdNome
            // 
            GridProdNome.HeaderText = "Nome";
            GridProdNome.MinimumWidth = 6;
            GridProdNome.Name = "GridProdNome";
            // 
            // GridProdDesc
            // 
            GridProdDesc.HeaderText = "Descrição";
            GridProdDesc.MinimumWidth = 6;
            GridProdDesc.Name = "GridProdDesc";
            // 
            // GridProdPreco
            // 
            GridProdPreco.HeaderText = "Preco";
            GridProdPreco.MinimumWidth = 6;
            GridProdPreco.Name = "GridProdPreco";
            // 
            // GridProdQuantidade
            // 
            GridProdQuantidade.HeaderText = "Quantidade";
            GridProdQuantidade.MinimumWidth = 6;
            GridProdQuantidade.Name = "GridProdQuantidade";
            // 
            // GridProdCat
            // 
            GridProdCat.HeaderText = "Categoria";
            GridProdCat.MinimumWidth = 6;
            GridProdCat.Name = "GridProdCat";
            // 
            // ProdutoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 478);
            Controls.Add(tabCidade);
            Name = "ProdutoForm";
            Text = "ProdutoForm";
            ((System.ComponentModel.ISupportInitialize)gridProduto).EndInit();
            pnlPesquisa.ResumeLayout(false);
            pnlPesquisa.PerformLayout();
            pnlAcao.ResumeLayout(false);
            tpCidadeConsulta.ResumeLayout(false);
            pnlAcaoCadastro.ResumeLayout(false);
            tpCidadeCadastro.ResumeLayout(false);
            tpCidadeCadastro.PerformLayout();
            tabCidade.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridProduto;
        private Panel pnlPesquisa;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private Panel pnlAcao;
        private Button btnVisualizar;
        private Button btnNovo;
        private TabPage tpCidadeConsulta;
        private Button btnCancelar;
        private Panel pnlAcaoCadastro;
        private Button btnExcluir;
        private Button btnSalvar;
        private TextBox textBoxNomeProd;
        private Label NameProdLbl;
        private TabPage tpCidadeCadastro;
        private TabControl tabCidade;
        private TextBox textBoxPrecoProd;
        private Label PrecoProdLbl;
        private TextBox textBoxDescProd;
        private Label DescProdLbl;
        private TextBox textBoxQtdeProd;
        private Label QtdeProdLbl;
        private TextBox textBoxCatProd;
        private Label CatProdLbl;
        private DataGridViewTextBoxColumn GridProdID;
        private DataGridViewTextBoxColumn GridProdNome;
        private DataGridViewTextBoxColumn GridProdDesc;
        private DataGridViewTextBoxColumn GridProdPreco;
        private DataGridViewTextBoxColumn GridProdQuantidade;
        private DataGridViewTextBoxColumn GridProdCat;
    }
}