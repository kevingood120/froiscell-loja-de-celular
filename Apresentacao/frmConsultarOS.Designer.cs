namespace Apresentacao
{
    partial class frmConsultarOS
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
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.btnNovaOSExistente = new MetroFramework.Controls.MetroButton();
            this.dgvOS = new Apresentacao.Controles.DataGridBinding();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRegistroEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRegistroSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAparelho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cImei1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cImei2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cReclamacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cObservacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOrcamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovoOS = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnVolta = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.chkStatus = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkStatus);
            this.groupBox1.Controls.Add(this.cboStatus);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.btnNovaOSExistente);
            this.groupBox1.Controls.Add(this.dgvOS);
            this.groupBox1.Controls.Add(this.btnNovoOS);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(5, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(512, 38);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(169, 23);
            this.cboStatus.TabIndex = 29;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(512, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 19);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Status";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(687, 38);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(78, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseSelectable = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(478, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(6, 38);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(500, 23);
            this.txtNome.TabIndex = 2;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // btnNovaOSExistente
            // 
            this.btnNovaOSExistente.Location = new System.Drawing.Point(87, 406);
            this.btnNovaOSExistente.Name = "btnNovaOSExistente";
            this.btnNovaOSExistente.Size = new System.Drawing.Size(183, 23);
            this.btnNovaOSExistente.TabIndex = 2;
            this.btnNovaOSExistente.Text = "Nova OS (a partir da existente)";
            this.btnNovaOSExistente.UseSelectable = true;
            this.btnNovaOSExistente.Click += new System.EventHandler(this.btnNovaOSExistente_Click);
            // 
            // dgvOS
            // 
            this.dgvOS.AllowUserToAddRows = false;
            this.dgvOS.AllowUserToDeleteRows = false;
            this.dgvOS.AllowUserToResizeRows = false;
            this.dgvOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodigo,
            this.cNome,
            this.cRegistroEntrada,
            this.cRegistroSaida,
            this.cAparelho,
            this.cModelo,
            this.cMarca,
            this.cImei1,
            this.cImei2,
            this.cCor,
            this.cReclamacao,
            this.cObservacao,
            this.cOrcamento,
            this.cValor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOS.EnableHeadersVisualStyles = false;
            this.dgvOS.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvOS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOS.Location = new System.Drawing.Point(6, 67);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.ReadOnly = true;
            this.dgvOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOS.Size = new System.Drawing.Size(759, 333);
            this.dgvOS.TabIndex = 1;
            this.dgvOS.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOS_RowHeaderMouseDoubleClick);
            // 
            // cCodigo
            // 
            this.cCodigo.DataPropertyName = "Cod_ordem";
            this.cCodigo.HeaderText = "Código";
            this.cCodigo.Name = "cCodigo";
            this.cCodigo.ReadOnly = true;
            // 
            // cNome
            // 
            this.cNome.DataPropertyName = "ClienteSelecionado.Nome_cliente";
            this.cNome.HeaderText = "Nome";
            this.cNome.Name = "cNome";
            this.cNome.ReadOnly = true;
            // 
            // cRegistroEntrada
            // 
            this.cRegistroEntrada.DataPropertyName = "Reg_entrada";
            this.cRegistroEntrada.HeaderText = "Entrada";
            this.cRegistroEntrada.Name = "cRegistroEntrada";
            this.cRegistroEntrada.ReadOnly = true;
            // 
            // cRegistroSaida
            // 
            this.cRegistroSaida.DataPropertyName = "Reg_saida";
            this.cRegistroSaida.HeaderText = "Saída";
            this.cRegistroSaida.Name = "cRegistroSaida";
            this.cRegistroSaida.ReadOnly = true;
            // 
            // cAparelho
            // 
            this.cAparelho.DataPropertyName = "AparelhoSelecionado.TipoSelecionado";
            this.cAparelho.HeaderText = "Aparelho";
            this.cAparelho.Name = "cAparelho";
            this.cAparelho.ReadOnly = true;
            // 
            // cModelo
            // 
            this.cModelo.DataPropertyName = "AparelhoSelecionado.Modelo_aparelho";
            this.cModelo.HeaderText = "Modelo";
            this.cModelo.Name = "cModelo";
            this.cModelo.ReadOnly = true;
            // 
            // cMarca
            // 
            this.cMarca.DataPropertyName = "AparelhoSelecionado.MarcaSelecionada.Nome_marca";
            this.cMarca.HeaderText = "Marca";
            this.cMarca.Name = "cMarca";
            this.cMarca.ReadOnly = true;
            // 
            // cImei1
            // 
            this.cImei1.DataPropertyName = "Imei1_aparelho";
            this.cImei1.HeaderText = "IMEI Primário";
            this.cImei1.Name = "cImei1";
            this.cImei1.ReadOnly = true;
            // 
            // cImei2
            // 
            this.cImei2.DataPropertyName = "Imei2_aparelho";
            this.cImei2.HeaderText = "IMEI Secundário";
            this.cImei2.Name = "cImei2";
            this.cImei2.ReadOnly = true;
            // 
            // cCor
            // 
            this.cCor.DataPropertyName = "CorSelecionada.Nome_cor";
            this.cCor.HeaderText = "Cor";
            this.cCor.Name = "cCor";
            this.cCor.ReadOnly = true;
            // 
            // cReclamacao
            // 
            this.cReclamacao.DataPropertyName = "Rec_aparelho";
            this.cReclamacao.HeaderText = "Reclamação";
            this.cReclamacao.Name = "cReclamacao";
            this.cReclamacao.ReadOnly = true;
            // 
            // cObservacao
            // 
            this.cObservacao.DataPropertyName = "Obs_aparelho";
            this.cObservacao.HeaderText = "Observação";
            this.cObservacao.Name = "cObservacao";
            this.cObservacao.ReadOnly = true;
            // 
            // cOrcamento
            // 
            this.cOrcamento.DataPropertyName = "Orc_descricao";
            this.cOrcamento.HeaderText = "Orçamento";
            this.cOrcamento.Name = "cOrcamento";
            this.cOrcamento.ReadOnly = true;
            // 
            // cValor
            // 
            this.cValor.DataPropertyName = "Orc_preco";
            this.cValor.HeaderText = "Valor";
            this.cValor.Name = "cValor";
            this.cValor.ReadOnly = true;
            // 
            // btnNovoOS
            // 
            this.btnNovoOS.Location = new System.Drawing.Point(6, 406);
            this.btnNovoOS.Name = "btnNovoOS";
            this.btnNovoOS.Size = new System.Drawing.Size(75, 23);
            this.btnNovoOS.TabIndex = 1;
            this.btnNovoOS.Text = "Nova OS";
            this.btnNovoOS.UseSelectable = true;
            this.btnNovoOS.Click += new System.EventHandler(this.btnNovoOS_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Cliente | Código";
            // 
            // btnVolta
            // 
            this.btnVolta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolta.Location = new System.Drawing.Point(701, 503);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(75, 23);
            this.btnVolta.TabIndex = 3;
            this.btnVolta.Text = "Voltar";
            this.btnVolta.UseSelectable = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(637, 16);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(128, 15);
            this.chkStatus.TabIndex = 30;
            this.chkStatus.Text = "Pesquisar por status";
            this.chkStatus.UseSelectable = true;
            // 
            // frmConsultarOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 532);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultarOS";
            this.Resizable = false;
            this.Text = "Consultar OS";
            this.Load += new System.EventHandler(this.frmConsultarOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Controles.DataGridBinding dgvOS;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroButton btnNovoOS;
        private MetroFramework.Controls.MetroButton btnNovaOSExistente;
        private MetroFramework.Controls.MetroButton btnVolta;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRegistroEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRegistroSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAparelho;
        private System.Windows.Forms.DataGridViewTextBoxColumn cModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cImei1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cImei2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cReclamacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cObservacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOrcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValor;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.ComboBox cboStatus;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroCheckBox chkStatus;
    }
}