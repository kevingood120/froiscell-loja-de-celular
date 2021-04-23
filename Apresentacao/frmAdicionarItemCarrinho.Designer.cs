namespace Apresentacao
{
    partial class frmAdicionarItemCarrinho
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgvProdutos = new Apresentacao.Controles.DataGridBinding();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtProdutoGrupo = new MetroFramework.Controls.MetroTextBox();
            this.numericQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnSelecionar = new MetroFramework.Controls.MetroButton();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.btnNovoAparelho = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.dgvProdutos);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtProdutoGrupo);
            this.groupBox1.Controls.Add(this.numericQuantidade);
            this.groupBox1.Location = new System.Drawing.Point(8, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 381);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(673, 38);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseSelectable = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(573, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Quantidade: ";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodigo,
            this.cGrupo,
            this.cDescricao,
            this.cPreco,
            this.cEstoque});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProdutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProdutos.Location = new System.Drawing.Point(6, 67);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(742, 308);
            this.dgvProdutos.TabIndex = 2;
            this.dgvProdutos.Enter += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Produto ou Grupo";
            // 
            // txtProdutoGrupo
            // 
            // 
            // 
            // 
            this.txtProdutoGrupo.CustomButton.Image = null;
            this.txtProdutoGrupo.CustomButton.Location = new System.Drawing.Point(539, 1);
            this.txtProdutoGrupo.CustomButton.Name = "";
            this.txtProdutoGrupo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProdutoGrupo.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtProdutoGrupo.CustomButton.TabIndex = 1;
            this.txtProdutoGrupo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProdutoGrupo.CustomButton.UseSelectable = true;
            this.txtProdutoGrupo.CustomButton.Visible = false;
            this.txtProdutoGrupo.Lines = new string[0];
            this.txtProdutoGrupo.Location = new System.Drawing.Point(6, 38);
            this.txtProdutoGrupo.MaxLength = 32767;
            this.txtProdutoGrupo.Name = "txtProdutoGrupo";
            this.txtProdutoGrupo.PasswordChar = '\0';
            this.txtProdutoGrupo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProdutoGrupo.SelectedText = "";
            this.txtProdutoGrupo.SelectionLength = 0;
            this.txtProdutoGrupo.SelectionStart = 0;
            this.txtProdutoGrupo.ShortcutsEnabled = true;
            this.txtProdutoGrupo.Size = new System.Drawing.Size(561, 23);
            this.txtProdutoGrupo.TabIndex = 0;
            this.txtProdutoGrupo.UseSelectable = true;
            this.txtProdutoGrupo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProdutoGrupo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProdutoGrupo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdutoGrupo_KeyDown);
            // 
            // numericQuantidade
            // 
            this.numericQuantidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericQuantidade.Location = new System.Drawing.Point(573, 38);
            this.numericQuantidade.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantidade.Name = "numericQuantidade";
            this.numericQuantidade.Size = new System.Drawing.Size(94, 23);
            this.numericQuantidade.TabIndex = 21;
            this.numericQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericQuantidade_KeyDown);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(606, 437);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 23;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseSelectable = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.CausesValidation = false;
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(687, 436);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseSelectable = true;
            // 
            // btnNovoAparelho
            // 
            this.btnNovoAparelho.Location = new System.Drawing.Point(8, 436);
            this.btnNovoAparelho.Name = "btnNovoAparelho";
            this.btnNovoAparelho.Size = new System.Drawing.Size(90, 23);
            this.btnNovoAparelho.TabIndex = 25;
            this.btnNovoAparelho.Text = "Novo Produto";
            this.btnNovoAparelho.UseSelectable = true;
            this.btnNovoAparelho.Click += new System.EventHandler(this.btnNovoAparelho_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // cCodigo
            // 
            this.cCodigo.DataPropertyName = "Cod_produto";
            this.cCodigo.HeaderText = "Código";
            this.cCodigo.Name = "cCodigo";
            this.cCodigo.ReadOnly = true;
            // 
            // cGrupo
            // 
            this.cGrupo.DataPropertyName = "GrupoSelecionado.Nome_grupo";
            this.cGrupo.HeaderText = "Grupo";
            this.cGrupo.Name = "cGrupo";
            this.cGrupo.ReadOnly = true;
            // 
            // cDescricao
            // 
            this.cDescricao.DataPropertyName = "Desc_produto";
            this.cDescricao.HeaderText = "Descrição";
            this.cDescricao.Name = "cDescricao";
            this.cDescricao.ReadOnly = true;
            // 
            // cPreco
            // 
            this.cPreco.DataPropertyName = "Preco_produto";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.cPreco.DefaultCellStyle = dataGridViewCellStyle2;
            this.cPreco.HeaderText = "Preço";
            this.cPreco.Name = "cPreco";
            this.cPreco.ReadOnly = true;
            // 
            // cEstoque
            // 
            this.cEstoque.DataPropertyName = "Qtd_produto";
            this.cEstoque.HeaderText = "Estoque";
            this.cEstoque.Name = "cEstoque";
            this.cEstoque.ReadOnly = true;
            // 
            // frmAdicionarItemCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 470);
            this.Controls.Add(this.btnNovoAparelho);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdicionarItemCarrinho";
            this.Resizable = false;
            this.Text = "Adicionar Item";
            this.Load += new System.EventHandler(this.frmAdicionarItemCarrinho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Controles.DataGridBinding dgvProdutos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtProdutoGrupo;
        private System.Windows.Forms.NumericUpDown numericQuantidade;
        private MetroFramework.Controls.MetroButton btnSelecionar;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnNovoAparelho;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEstoque;
    }
}