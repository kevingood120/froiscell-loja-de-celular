namespace Apresentacao
{
    partial class frmFinalizarItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCupom = new MetroFramework.Controls.MetroCheckBox();
            this.btnRemover = new MetroFramework.Controls.MetroButton();
            this.btnAdicionar = new MetroFramework.Controls.MetroButton();
            this.numericVezes = new System.Windows.Forms.NumericUpDown();
            this.cboPagamento = new System.Windows.Forms.ComboBox();
            this.txtValor = new Apresentacao.Controles.CurrencyTextBox();
            this.lblVezes = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvPagamentos = new Apresentacao.Controles.DataGridBinding();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtValorPendente = new Apresentacao.Controles.CurrencyTextBox();
            this.txtValorVariavel = new Apresentacao.Controles.CurrencyTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.cValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericVezes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCupom);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.numericVezes);
            this.groupBox1.Controls.Add(this.cboPagamento);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.lblVezes);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.dgvPagamentos);
            this.groupBox1.Location = new System.Drawing.Point(7, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkCupom
            // 
            this.chkCupom.AutoSize = true;
            this.chkCupom.Location = new System.Drawing.Point(417, 222);
            this.chkCupom.Name = "chkCupom";
            this.chkCupom.Size = new System.Drawing.Size(63, 15);
            this.chkCupom.TabIndex = 24;
            this.chkCupom.Text = "Cupom";
            this.chkCupom.UseSelectable = true;
            this.chkCupom.CheckedChanged += new System.EventHandler(this.chkCupom_CheckedChanged);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(87, 222);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 23;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseSelectable = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(6, 222);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 22;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseSelectable = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // numericVezes
            // 
            this.numericVezes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericVezes.Location = new System.Drawing.Point(242, 37);
            this.numericVezes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericVezes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericVezes.Name = "numericVezes";
            this.numericVezes.Size = new System.Drawing.Size(94, 22);
            this.numericVezes.TabIndex = 21;
            this.numericVezes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboPagamento
            // 
            this.cboPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPagamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPagamento.FormattingEnabled = true;
            this.cboPagamento.Location = new System.Drawing.Point(101, 37);
            this.cboPagamento.Name = "cboPagamento";
            this.cboPagamento.Size = new System.Drawing.Size(135, 23);
            this.cboPagamento.TabIndex = 12;
            this.cboPagamento.SelectedValueChanged += new System.EventHandler(this.cboPagamento_SelectedValueChanged);
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(67, 1);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.Lines = new string[] {
        "R$ 0,00"};
            this.txtValor.Location = new System.Drawing.Point(6, 37);
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
            this.txtValor.Size = new System.Drawing.Size(89, 23);
            this.txtValor.TabIndex = 4;
            this.txtValor.Text = "R$ 0,00";
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblVezes
            // 
            this.lblVezes.AutoSize = true;
            this.lblVezes.Location = new System.Drawing.Point(242, 15);
            this.lblVezes.Name = "lblVezes";
            this.lblVezes.Size = new System.Drawing.Size(41, 19);
            this.lblVezes.TabIndex = 3;
            this.lblVezes.Text = "Vezes";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(101, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Pagamento";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Valor";
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.AllowUserToAddRows = false;
            this.dgvPagamentos.AllowUserToDeleteRows = false;
            this.dgvPagamentos.AllowUserToResizeRows = false;
            this.dgvPagamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPagamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPagamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPagamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cValor,
            this.cFormaPagamento,
            this.cVezes});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagamentos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPagamentos.EnableHeadersVisualStyles = false;
            this.dgvPagamentos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPagamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPagamentos.Location = new System.Drawing.Point(6, 66);
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.ReadOnly = true;
            this.dgvPagamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPagamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPagamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagamentos.Size = new System.Drawing.Size(474, 150);
            this.dgvPagamentos.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(337, 324);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(418, 324);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(108, 327);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(24, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "de";
            // 
            // txtValorPendente
            // 
            // 
            // 
            // 
            this.txtValorPendente.CustomButton.Image = null;
            this.txtValorPendente.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtValorPendente.CustomButton.Name = "";
            this.txtValorPendente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValorPendente.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtValorPendente.CustomButton.TabIndex = 1;
            this.txtValorPendente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorPendente.CustomButton.UseSelectable = true;
            this.txtValorPendente.CustomButton.Visible = false;
            this.txtValorPendente.Lines = new string[] {
        "R$ 0,00"};
            this.txtValorPendente.Location = new System.Drawing.Point(138, 323);
            this.txtValorPendente.MaxLength = 32767;
            this.txtValorPendente.Name = "txtValorPendente";
            this.txtValorPendente.Numero = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtValorPendente.PasswordChar = '\0';
            this.txtValorPendente.ReadOnly = true;
            this.txtValorPendente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorPendente.SelectedText = "";
            this.txtValorPendente.SelectionLength = 0;
            this.txtValorPendente.SelectionStart = 7;
            this.txtValorPendente.ShortcutsEnabled = true;
            this.txtValorPendente.Size = new System.Drawing.Size(95, 23);
            this.txtValorPendente.TabIndex = 27;
            this.txtValorPendente.Text = "R$ 0,00";
            this.txtValorPendente.UseSelectable = true;
            this.txtValorPendente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorPendente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtValorVariavel
            // 
            // 
            // 
            // 
            this.txtValorVariavel.CustomButton.Image = null;
            this.txtValorVariavel.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtValorVariavel.CustomButton.Name = "";
            this.txtValorVariavel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValorVariavel.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtValorVariavel.CustomButton.TabIndex = 1;
            this.txtValorVariavel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorVariavel.CustomButton.UseSelectable = true;
            this.txtValorVariavel.CustomButton.Visible = false;
            this.txtValorVariavel.Lines = new string[] {
        "R$ 0,00"};
            this.txtValorVariavel.Location = new System.Drawing.Point(7, 323);
            this.txtValorVariavel.MaxLength = 32767;
            this.txtValorVariavel.Name = "txtValorVariavel";
            this.txtValorVariavel.Numero = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtValorVariavel.PasswordChar = '\0';
            this.txtValorVariavel.ReadOnly = true;
            this.txtValorVariavel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorVariavel.SelectedText = "";
            this.txtValorVariavel.SelectionLength = 0;
            this.txtValorVariavel.SelectionStart = 7;
            this.txtValorVariavel.ShortcutsEnabled = true;
            this.txtValorVariavel.Size = new System.Drawing.Size(95, 23);
            this.txtValorVariavel.TabIndex = 25;
            this.txtValorVariavel.Text = "R$ 0,00";
            this.txtValorVariavel.UseSelectable = true;
            this.txtValorVariavel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorVariavel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // cValor
            // 
            this.cValor.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Format = "C2";
            this.cValor.DefaultCellStyle = dataGridViewCellStyle2;
            this.cValor.HeaderText = "Valor";
            this.cValor.Name = "cValor";
            this.cValor.ReadOnly = true;
            this.cValor.Width = 130;
            // 
            // cFormaPagamento
            // 
            this.cFormaPagamento.DataPropertyName = "PagamentoSelecionado";
            this.cFormaPagamento.HeaderText = "Pagamento";
            this.cFormaPagamento.Name = "cFormaPagamento";
            this.cFormaPagamento.ReadOnly = true;
            this.cFormaPagamento.Width = 200;
            // 
            // cVezes
            // 
            this.cVezes.DataPropertyName = "Vezes";
            dataGridViewCellStyle3.NullValue = "1";
            this.cVezes.DefaultCellStyle = dataGridViewCellStyle3;
            this.cVezes.HeaderText = "Vezes";
            this.cVezes.Name = "cVezes";
            this.cVezes.ReadOnly = true;
            // 
            // frmFinalizarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 359);
            this.ControlBox = false;
            this.Controls.Add(this.txtValorPendente);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtValorVariavel);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFinalizarItem";
            this.Resizable = false;
            this.Text = "Finalizar";
            this.Load += new System.EventHandler(this.frmFinalizarItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericVezes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Controles.CurrencyTextBox txtValor;
        private MetroFramework.Controls.MetroLabel lblVezes;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Controles.DataGridBinding dgvPagamentos;
        private System.Windows.Forms.ComboBox cboPagamento;
        private MetroFramework.Controls.MetroButton btnRemover;
        private MetroFramework.Controls.MetroButton btnAdicionar;
        private System.Windows.Forms.NumericUpDown numericVezes;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private Controles.CurrencyTextBox txtValorVariavel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private Controles.CurrencyTextBox txtValorPendente;
        private MetroFramework.Controls.MetroCheckBox chkCupom;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVezes;
    }
}