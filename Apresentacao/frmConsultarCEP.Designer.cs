namespace Apresentacao
{
    partial class frmConsultarCEP
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
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtLogradouro = new MetroFramework.Controls.MetroTextBox();
            this.dgvCEP = new Apresentacao.Controles.DataGridBinding();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtLogradouro);
            this.groupBox1.Controls.Add(this.dgvCEP);
            this.groupBox1.Location = new System.Drawing.Point(8, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(524, 38);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseSelectable = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(6, 285);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseSelectable = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            // 
            // 
            // 
            this.txtLogradouro.CustomButton.Image = null;
            this.txtLogradouro.CustomButton.Location = new System.Drawing.Point(490, 1);
            this.txtLogradouro.CustomButton.Name = "";
            this.txtLogradouro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLogradouro.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtLogradouro.CustomButton.TabIndex = 1;
            this.txtLogradouro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogradouro.CustomButton.UseSelectable = true;
            this.txtLogradouro.CustomButton.Visible = false;
            this.txtLogradouro.Lines = new string[0];
            this.txtLogradouro.Location = new System.Drawing.Point(6, 38);
            this.txtLogradouro.MaxLength = 32767;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.PasswordChar = '\0';
            this.txtLogradouro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogradouro.SelectedText = "";
            this.txtLogradouro.SelectionLength = 0;
            this.txtLogradouro.SelectionStart = 0;
            this.txtLogradouro.ShortcutsEnabled = true;
            this.txtLogradouro.Size = new System.Drawing.Size(512, 23);
            this.txtLogradouro.TabIndex = 1;
            this.txtLogradouro.UseSelectable = true;
            this.txtLogradouro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogradouro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLogradouro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogradouro_KeyDown);
            // 
            // dgvCEP
            // 
            this.dgvCEP.AllowUserToAddRows = false;
            this.dgvCEP.AllowUserToDeleteRows = false;
            this.dgvCEP.AllowUserToResizeRows = false;
            this.dgvCEP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCEP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCEP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCEP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCEP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCEP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCEP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodigo,
            this.cCep,
            this.cLogradouro,
            this.cBairro,
            this.cCidade,
            this.cUF});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCEP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCEP.EnableHeadersVisualStyles = false;
            this.dgvCEP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCEP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCEP.Location = new System.Drawing.Point(6, 67);
            this.dgvCEP.Name = "dgvCEP";
            this.dgvCEP.ReadOnly = true;
            this.dgvCEP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCEP.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCEP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCEP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCEP.Size = new System.Drawing.Size(593, 212);
            this.dgvCEP.TabIndex = 0;
            this.dgvCEP.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCEP_RowHeaderMouseDoubleClick);
            // 
            // cCodigo
            // 
            this.cCodigo.DataPropertyName = "Cod_cep";
            this.cCodigo.HeaderText = "Código";
            this.cCodigo.Name = "cCodigo";
            this.cCodigo.ReadOnly = true;
            // 
            // cCep
            // 
            this.cCep.DataPropertyName = "Cep";
            this.cCep.HeaderText = "CEP";
            this.cCep.Name = "cCep";
            this.cCep.ReadOnly = true;
            // 
            // cLogradouro
            // 
            this.cLogradouro.DataPropertyName = "Logra";
            this.cLogradouro.HeaderText = "Logradouro";
            this.cLogradouro.Name = "cLogradouro";
            this.cLogradouro.ReadOnly = true;
            this.cLogradouro.Width = 180;
            // 
            // cBairro
            // 
            this.cBairro.DataPropertyName = "Bairro";
            this.cBairro.HeaderText = "Bairro";
            this.cBairro.Name = "cBairro";
            this.cBairro.ReadOnly = true;
            // 
            // cCidade
            // 
            this.cCidade.DataPropertyName = "Cidade";
            this.cCidade.HeaderText = "Cidade";
            this.cCidade.Name = "cCidade";
            this.cCidade.ReadOnly = true;
            // 
            // cUF
            // 
            this.cUF.DataPropertyName = "Uf";
            this.cUF.HeaderText = "UF";
            this.cUF.Name = "cUF";
            this.cUF.ReadOnly = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(538, 382);
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
            // frmConsultarCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 416);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Movable = false;
            this.Name = "frmConsultarCEP";
            this.Resizable = false;
            this.Text = "CEP\'s";
            this.Load += new System.EventHandler(this.frmConsultarCEP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnNovo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtLogradouro;
        private Controles.DataGridBinding dgvCEP;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUF;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}