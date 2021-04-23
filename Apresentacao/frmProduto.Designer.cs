namespace Apresentacao
{
    partial class frmProduto
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
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.btnGrupo = new MetroFramework.Controls.MetroButton();
            this.lblGrupo = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoBarras = new MetroFramework.Controls.MetroTextBox();
            this.lblCodigoBarras = new MetroFramework.Controls.MetroLabel();
            this.lblDescricao = new MetroFramework.Controls.MetroLabel();
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.lblEstoqueMin = new MetroFramework.Controls.MetroLabel();
            this.lblEstoque = new MetroFramework.Controls.MetroLabel();
            this.numericEstoqueMin = new System.Windows.Forms.NumericUpDown();
            this.numericEstoque = new System.Windows.Forms.NumericUpDown();
            this.txtValorCusto = new Apresentacao.Controles.CurrencyTextBox();
            this.lblValorCusto = new MetroFramework.Controls.MetroLabel();
            this.lblValor = new MetroFramework.Controls.MetroLabel();
            this.txtValor = new Apresentacao.Controles.CurrencyTextBox();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEstoqueMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(6, 38);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(148, 23);
            this.cboGrupo.TabIndex = 0;
            this.cboGrupo.Validating += new System.ComponentModel.CancelEventHandler(this.cboGrupo_Validating);
            // 
            // btnGrupo
            // 
            this.btnGrupo.CausesValidation = false;
            this.btnGrupo.Location = new System.Drawing.Point(160, 38);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(40, 23);
            this.btnGrupo.TabIndex = 1;
            this.btnGrupo.Text = ". . .";
            this.btnGrupo.UseSelectable = true;
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(6, 16);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(46, 19);
            this.lblGrupo.TabIndex = 14;
            this.lblGrupo.Text = "Grupo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoBarras);
            this.groupBox1.Controls.Add(this.lblCodigoBarras);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.lblEstoqueMin);
            this.groupBox1.Controls.Add(this.lblEstoque);
            this.groupBox1.Controls.Add(this.numericEstoqueMin);
            this.groupBox1.Controls.Add(this.numericEstoque);
            this.groupBox1.Controls.Add(this.txtValorCusto);
            this.groupBox1.Controls.Add(this.lblValorCusto);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.cboGrupo);
            this.groupBox1.Controls.Add(this.lblGrupo);
            this.groupBox1.Controls.Add(this.btnGrupo);
            this.groupBox1.Location = new System.Drawing.Point(9, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCodigoBarras.CustomButton.Image = null;
            this.txtCodigoBarras.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtCodigoBarras.CustomButton.Name = "";
            this.txtCodigoBarras.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigoBarras.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtCodigoBarras.CustomButton.TabIndex = 1;
            this.txtCodigoBarras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigoBarras.CustomButton.UseSelectable = true;
            this.txtCodigoBarras.CustomButton.Visible = false;
            this.txtCodigoBarras.Lines = new string[0];
            this.txtCodigoBarras.Location = new System.Drawing.Point(6, 229);
            this.txtCodigoBarras.MaxLength = 100;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.PasswordChar = '\0';
            this.txtCodigoBarras.ReadOnly = true;
            this.txtCodigoBarras.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoBarras.SelectedText = "";
            this.txtCodigoBarras.SelectionLength = 0;
            this.txtCodigoBarras.SelectionStart = 0;
            this.txtCodigoBarras.ShortcutsEnabled = true;
            this.txtCodigoBarras.Size = new System.Drawing.Size(194, 23);
            this.txtCodigoBarras.TabIndex = 7;
            this.txtCodigoBarras.UseSelectable = true;
            this.txtCodigoBarras.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigoBarras.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoBarras.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoBarras_Validating);
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new System.Drawing.Point(6, 207);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(113, 19);
            this.lblCodigoBarras.TabIndex = 17;
            this.lblCodigoBarras.Text = "Código de Barras";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 159);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(65, 19);
            this.lblDescricao.TabIndex = 25;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            // 
            // 
            // 
            this.txtDescricao.CustomButton.Image = null;
            this.txtDescricao.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtDescricao.CustomButton.Name = "";
            this.txtDescricao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtDescricao.CustomButton.TabIndex = 1;
            this.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricao.CustomButton.UseSelectable = true;
            this.txtDescricao.CustomButton.Visible = false;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(6, 181);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.Size = new System.Drawing.Size(194, 23);
            this.txtDescricao.TabIndex = 6;
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescricao.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescricao_Validating);
            // 
            // lblEstoqueMin
            // 
            this.lblEstoqueMin.AutoSize = true;
            this.lblEstoqueMin.Location = new System.Drawing.Point(106, 112);
            this.lblEstoqueMin.Name = "lblEstoqueMin";
            this.lblEstoqueMin.Size = new System.Drawing.Size(84, 19);
            this.lblEstoqueMin.TabIndex = 23;
            this.lblEstoqueMin.Text = "Estoque mín.";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(6, 112);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(55, 19);
            this.lblEstoque.TabIndex = 22;
            this.lblEstoque.Text = "Estoque";
            // 
            // numericEstoqueMin
            // 
            this.numericEstoqueMin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericEstoqueMin.Location = new System.Drawing.Point(106, 134);
            this.numericEstoqueMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericEstoqueMin.Name = "numericEstoqueMin";
            this.numericEstoqueMin.Size = new System.Drawing.Size(94, 22);
            this.numericEstoqueMin.TabIndex = 5;
            // 
            // numericEstoque
            // 
            this.numericEstoque.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericEstoque.Location = new System.Drawing.Point(6, 134);
            this.numericEstoque.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericEstoque.Name = "numericEstoque";
            this.numericEstoque.Size = new System.Drawing.Size(94, 22);
            this.numericEstoque.TabIndex = 4;
            // 
            // txtValorCusto
            // 
            // 
            // 
            // 
            this.txtValorCusto.CustomButton.Image = null;
            this.txtValorCusto.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtValorCusto.CustomButton.Name = "";
            this.txtValorCusto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValorCusto.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtValorCusto.CustomButton.TabIndex = 1;
            this.txtValorCusto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorCusto.CustomButton.UseSelectable = true;
            this.txtValorCusto.CustomButton.Visible = false;
            this.txtValorCusto.Lines = new string[] {
        "R$ 0,00"};
            this.txtValorCusto.Location = new System.Drawing.Point(106, 86);
            this.txtValorCusto.MaxLength = 32767;
            this.txtValorCusto.Name = "txtValorCusto";
            this.txtValorCusto.Numero = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtValorCusto.PasswordChar = '\0';
            this.txtValorCusto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorCusto.SelectedText = "";
            this.txtValorCusto.SelectionLength = 0;
            this.txtValorCusto.SelectionStart = 7;
            this.txtValorCusto.ShortcutsEnabled = true;
            this.txtValorCusto.Size = new System.Drawing.Size(94, 23);
            this.txtValorCusto.TabIndex = 3;
            this.txtValorCusto.Text = "R$ 0,00";
            this.txtValorCusto.UseSelectable = true;
            this.txtValorCusto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorCusto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblValorCusto
            // 
            this.lblValorCusto.AutoSize = true;
            this.lblValorCusto.Location = new System.Drawing.Point(106, 64);
            this.lblValorCusto.Name = "lblValorCusto";
            this.lblValorCusto.Size = new System.Drawing.Size(94, 19);
            this.lblValorCusto.TabIndex = 18;
            this.lblValorCusto.Text = "Valor de Custo";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(6, 64);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(38, 19);
            this.lblValor.TabIndex = 17;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.Lines = new string[] {
        "R$ 0,00"};
            this.txtValor.Location = new System.Drawing.Point(6, 86);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Name = "txtValor";
            this.txtValor.Numero = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtValor.PasswordChar = '\0';
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 7;
            this.txtValor.ShortcutsEnabled = true;
            this.txtValor.Size = new System.Drawing.Size(94, 23);
            this.txtValor.TabIndex = 2;
            this.txtValor.Text = "R$ 0,00";
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtValor.Validating += new System.ComponentModel.CancelEventHandler(this.txtValor_Validating);
            // 
            // btnVoltar
            // 
            this.btnVoltar.CausesValidation = false;
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(142, 327);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseSelectable = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(61, 327);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 371);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProduto";
            this.Resizable = false;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEstoqueMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboGrupo;
        private MetroFramework.Controls.MetroButton btnGrupo;
        private MetroFramework.Controls.MetroLabel lblGrupo;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtCodigoBarras;
        private MetroFramework.Controls.MetroLabel lblCodigoBarras;
        private MetroFramework.Controls.MetroLabel lblDescricao;
        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private MetroFramework.Controls.MetroLabel lblEstoqueMin;
        private MetroFramework.Controls.MetroLabel lblEstoque;
        private System.Windows.Forms.NumericUpDown numericEstoqueMin;
        private System.Windows.Forms.NumericUpDown numericEstoque;
        private Controles.CurrencyTextBox txtValorCusto;
        private MetroFramework.Controls.MetroLabel lblValorCusto;
        private MetroFramework.Controls.MetroLabel lblValor;
        private Controles.CurrencyTextBox txtValor;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}