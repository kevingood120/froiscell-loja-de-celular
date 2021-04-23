namespace Apresentacao
{
    partial class frmProcurarAparelho
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
            this.dgvAparelhos = new Apresentacao.Controles.DataGridBinding();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAparelho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtAparelho = new MetroFramework.Controls.MetroTextBox();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.btnNovoAparelho = new MetroFramework.Controls.MetroButton();
            this.btnSelecionar = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAparelhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.dgvAparelhos);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtAparelho);
            this.groupBox1.Location = new System.Drawing.Point(8, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 381);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(673, 38);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseSelectable = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvAparelhos
            // 
            this.dgvAparelhos.AllowUserToAddRows = false;
            this.dgvAparelhos.AllowUserToDeleteRows = false;
            this.dgvAparelhos.AllowUserToResizeRows = false;
            this.dgvAparelhos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAparelhos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAparelhos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAparelhos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAparelhos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAparelhos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAparelhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAparelhos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodigo,
            this.cMarca,
            this.cModelo,
            this.cAparelho});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAparelhos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAparelhos.EnableHeadersVisualStyles = false;
            this.dgvAparelhos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAparelhos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAparelhos.Location = new System.Drawing.Point(6, 67);
            this.dgvAparelhos.MultiSelect = false;
            this.dgvAparelhos.Name = "dgvAparelhos";
            this.dgvAparelhos.ReadOnly = true;
            this.dgvAparelhos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAparelhos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAparelhos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAparelhos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAparelhos.Size = new System.Drawing.Size(742, 308);
            this.dgvAparelhos.TabIndex = 2;
            // 
            // cCodigo
            // 
            this.cCodigo.DataPropertyName = "Cod_aparelho";
            this.cCodigo.HeaderText = "Código";
            this.cCodigo.Name = "cCodigo";
            this.cCodigo.ReadOnly = true;
            // 
            // cMarca
            // 
            this.cMarca.DataPropertyName = "MarcaSelecionada.Nome_marca";
            this.cMarca.HeaderText = "Marca";
            this.cMarca.Name = "cMarca";
            this.cMarca.ReadOnly = true;
            // 
            // cModelo
            // 
            this.cModelo.DataPropertyName = "Modelo_aparelho";
            this.cModelo.HeaderText = "Modelo";
            this.cModelo.Name = "cModelo";
            this.cModelo.ReadOnly = true;
            // 
            // cAparelho
            // 
            this.cAparelho.DataPropertyName = "TipoSelecionado";
            this.cAparelho.HeaderText = "Aparelho";
            this.cAparelho.Name = "cAparelho";
            this.cAparelho.ReadOnly = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Aparelho ou Marca";
            // 
            // txtAparelho
            // 
            // 
            // 
            // 
            this.txtAparelho.CustomButton.Image = null;
            this.txtAparelho.CustomButton.Location = new System.Drawing.Point(639, 1);
            this.txtAparelho.CustomButton.Name = "";
            this.txtAparelho.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAparelho.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtAparelho.CustomButton.TabIndex = 1;
            this.txtAparelho.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAparelho.CustomButton.UseSelectable = true;
            this.txtAparelho.CustomButton.Visible = false;
            this.txtAparelho.Lines = new string[0];
            this.txtAparelho.Location = new System.Drawing.Point(6, 38);
            this.txtAparelho.MaxLength = 32767;
            this.txtAparelho.Name = "txtAparelho";
            this.txtAparelho.PasswordChar = '\0';
            this.txtAparelho.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAparelho.SelectedText = "";
            this.txtAparelho.SelectionLength = 0;
            this.txtAparelho.SelectionStart = 0;
            this.txtAparelho.ShortcutsEnabled = true;
            this.txtAparelho.Size = new System.Drawing.Size(661, 23);
            this.txtAparelho.TabIndex = 0;
            this.txtAparelho.UseSelectable = true;
            this.txtAparelho.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAparelho.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAparelho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAparelho_KeyDown);
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(687, 450);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseSelectable = true;
            // 
            // btnNovoAparelho
            // 
            this.btnNovoAparelho.Location = new System.Drawing.Point(8, 450);
            this.btnNovoAparelho.Name = "btnNovoAparelho";
            this.btnNovoAparelho.Size = new System.Drawing.Size(92, 23);
            this.btnNovoAparelho.TabIndex = 6;
            this.btnNovoAparelho.Text = "Novo Aparelho";
            this.btnNovoAparelho.UseSelectable = true;
            this.btnNovoAparelho.Click += new System.EventHandler(this.btnNovoAparelho_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(606, 450);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 5;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseSelectable = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // frmProcurarAparelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnNovoAparelho);
            this.Controls.Add(this.btnSelecionar);
            this.Name = "frmProcurarAparelho";
            this.Resizable = false;
            this.Text = "Procurar Aparelho";
            this.Load += new System.EventHandler(this.frmProcurarAparelho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAparelhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Controles.DataGridBinding dgvAparelhos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtAparelho;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private MetroFramework.Controls.MetroButton btnNovoAparelho;
        private MetroFramework.Controls.MetroButton btnSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAparelho;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}