namespace Apresentacao
{
    partial class frmConsultarProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.btnEstoqueMinimo = new MetroFramework.Controls.MetroButton();
            this.btnAdicionar = new MetroFramework.Controls.MetroButton();
            this.txtProduto = new MetroFramework.Controls.MetroTextBox();
            this.lblProduto = new MetroFramework.Controls.MetroLabel();
            this.dgvProdutos = new Apresentacao.Controles.DataGridBinding();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPreçoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuantidadeMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.btnEstoqueMinimo);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.lblProduto);
            this.groupBox1.Controls.Add(this.dgvProdutos);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(8, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(544, 38);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseSelectable = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnEstoqueMinimo
            // 
            this.btnEstoqueMinimo.Location = new System.Drawing.Point(511, 325);
            this.btnEstoqueMinimo.Name = "btnEstoqueMinimo";
            this.btnEstoqueMinimo.Size = new System.Drawing.Size(114, 23);
            this.btnEstoqueMinimo.TabIndex = 4;
            this.btnEstoqueMinimo.Text = "Estoque Mínimo";
            this.btnEstoqueMinimo.UseSelectable = true;
            this.btnEstoqueMinimo.Click += new System.EventHandler(this.btnEstoqueMinimo_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(6, 325);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseSelectable = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtProduto
            // 
            // 
            // 
            // 
            this.txtProduto.CustomButton.Image = null;
            this.txtProduto.CustomButton.Location = new System.Drawing.Point(510, 1);
            this.txtProduto.CustomButton.Name = "";
            this.txtProduto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProduto.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtProduto.CustomButton.TabIndex = 1;
            this.txtProduto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProduto.CustomButton.UseSelectable = true;
            this.txtProduto.CustomButton.Visible = false;
            this.txtProduto.Lines = new string[0];
            this.txtProduto.Location = new System.Drawing.Point(6, 38);
            this.txtProduto.MaxLength = 32767;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.PasswordChar = '\0';
            this.txtProduto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProduto.SelectedText = "";
            this.txtProduto.SelectionLength = 0;
            this.txtProduto.SelectionStart = 0;
            this.txtProduto.ShortcutsEnabled = true;
            this.txtProduto.Size = new System.Drawing.Size(532, 23);
            this.txtProduto.TabIndex = 2;
            this.txtProduto.UseSelectable = true;
            this.txtProduto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProduto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduto_KeyDown);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(6, 16);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(57, 19);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
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
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodigo,
            this.cGrupo,
            this.cDescProduto,
            this.cPreco,
            this.cPreçoCusto,
            this.cQuantidade,
            this.cQuantidadeMinima});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProdutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProdutos.Location = new System.Drawing.Point(6, 64);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(613, 255);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProdutos_RowHeaderMouseDoubleClick);
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
            // cDescProduto
            // 
            this.cDescProduto.DataPropertyName = "Desc_produto";
            this.cDescProduto.HeaderText = "Descrição";
            this.cDescProduto.Name = "cDescProduto";
            this.cDescProduto.ReadOnly = true;
            // 
            // cPreco
            // 
            this.cPreco.DataPropertyName = "Preco_produto";
            this.cPreco.HeaderText = "Preço";
            this.cPreco.Name = "cPreco";
            this.cPreco.ReadOnly = true;
            // 
            // cPreçoCusto
            // 
            this.cPreçoCusto.DataPropertyName = "Precocusto_produto";
            this.cPreçoCusto.HeaderText = "Preço de Custo";
            this.cPreçoCusto.Name = "cPreçoCusto";
            this.cPreçoCusto.ReadOnly = true;
            // 
            // cQuantidade
            // 
            this.cQuantidade.DataPropertyName = "Qtd_produto";
            this.cQuantidade.HeaderText = "Quantidade";
            this.cQuantidade.Name = "cQuantidade";
            this.cQuantidade.ReadOnly = true;
            // 
            // cQuantidadeMinima
            // 
            this.cQuantidadeMinima.DataPropertyName = "Qtdmin_produto";
            this.cQuantidadeMinima.HeaderText = "Qtd. Mínima";
            this.cQuantidadeMinima.Name = "cQuantidadeMinima";
            this.cQuantidadeMinima.ReadOnly = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(558, 417);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseSelectable = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // frmConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Movable = false;
            this.Name = "frmConsultarProduto";
            this.Resizable = false;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.frmConsultarProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnAdicionar;
        private MetroFramework.Controls.MetroTextBox txtProduto;
        private MetroFramework.Controls.MetroLabel lblProduto;
        private Controles.DataGridBinding dgvProdutos;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPreçoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuantidadeMinima;
        private MetroFramework.Controls.MetroButton btnEstoqueMinimo;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}