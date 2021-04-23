namespace Apresentacao
{
    partial class frmOS
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
            this.groupOrcamento = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboCor = new System.Windows.Forms.ComboBox();
            this.txtImeiSegundario = new MetroFramework.Controls.MetroTextBox();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.txtPreco = new Apresentacao.Controles.CurrencyTextBox();
            this.lblPreco = new MetroFramework.Controls.MetroLabel();
            this.txtDescricaoOrcamento = new MetroFramework.Controls.MetroTextBox();
            this.lblDescricaoOrcamento = new MetroFramework.Controls.MetroLabel();
            this.lblAcessorios = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkTampa = new MetroFramework.Controls.MetroCheckBox();
            this.chkBateria = new MetroFramework.Controls.MetroCheckBox();
            this.chkCartaoSD = new MetroFramework.Controls.MetroCheckBox();
            this.chkCapa = new MetroFramework.Controls.MetroCheckBox();
            this.chkCartaoSIM = new MetroFramework.Controls.MetroCheckBox();
            this.lblObservacao = new MetroFramework.Controls.MetroLabel();
            this.txtObservacoes = new MetroFramework.Controls.MetroTextBox();
            this.lblReclamacao = new MetroFramework.Controls.MetroLabel();
            this.lblIMEI = new MetroFramework.Controls.MetroLabel();
            this.btnCor = new MetroFramework.Controls.MetroButton();
            this.lblIMEI2 = new MetroFramework.Controls.MetroLabel();
            this.lblCor = new MetroFramework.Controls.MetroLabel();
            this.lblAparelho = new MetroFramework.Controls.MetroLabel();
            this.lblMarca = new MetroFramework.Controls.MetroLabel();
            this.txtReclamacao = new MetroFramework.Controls.MetroTextBox();
            this.txtImeiPrimario = new MetroFramework.Controls.MetroTextBox();
            this.txtAparelho = new MetroFramework.Controls.MetroTextBox();
            this.txtMarca = new MetroFramework.Controls.MetroTextBox();
            this.btnAparelho = new MetroFramework.Controls.MetroButton();
            this.txtModeloAparelho = new MetroFramework.Controls.MetroTextBox();
            this.lblModeloAparelho = new MetroFramework.Controls.MetroLabel();
            this.btnCliente = new MetroFramework.Controls.MetroButton();
            this.txtCliente = new MetroFramework.Controls.MetroTextBox();
            this.lblCliente = new MetroFramework.Controls.MetroLabel();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnImprimirOS = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.groupOrcamento.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupOrcamento
            // 
            this.groupOrcamento.Controls.Add(this.cboStatus);
            this.groupOrcamento.Controls.Add(this.cboCor);
            this.groupOrcamento.Controls.Add(this.txtImeiSegundario);
            this.groupOrcamento.Controls.Add(this.lblStatus);
            this.groupOrcamento.Controls.Add(this.txtPreco);
            this.groupOrcamento.Controls.Add(this.lblPreco);
            this.groupOrcamento.Controls.Add(this.txtDescricaoOrcamento);
            this.groupOrcamento.Controls.Add(this.lblDescricaoOrcamento);
            this.groupOrcamento.Controls.Add(this.lblAcessorios);
            this.groupOrcamento.Controls.Add(this.flowLayoutPanel1);
            this.groupOrcamento.Controls.Add(this.lblObservacao);
            this.groupOrcamento.Controls.Add(this.txtObservacoes);
            this.groupOrcamento.Controls.Add(this.lblReclamacao);
            this.groupOrcamento.Controls.Add(this.lblIMEI);
            this.groupOrcamento.Controls.Add(this.btnCor);
            this.groupOrcamento.Controls.Add(this.lblIMEI2);
            this.groupOrcamento.Controls.Add(this.lblCor);
            this.groupOrcamento.Controls.Add(this.lblAparelho);
            this.groupOrcamento.Controls.Add(this.lblMarca);
            this.groupOrcamento.Controls.Add(this.txtReclamacao);
            this.groupOrcamento.Controls.Add(this.txtImeiPrimario);
            this.groupOrcamento.Controls.Add(this.txtAparelho);
            this.groupOrcamento.Controls.Add(this.txtMarca);
            this.groupOrcamento.Controls.Add(this.btnAparelho);
            this.groupOrcamento.Controls.Add(this.txtModeloAparelho);
            this.groupOrcamento.Controls.Add(this.lblModeloAparelho);
            this.groupOrcamento.Controls.Add(this.btnCliente);
            this.groupOrcamento.Controls.Add(this.txtCliente);
            this.groupOrcamento.Controls.Add(this.lblCliente);
            this.groupOrcamento.Location = new System.Drawing.Point(7, 63);
            this.groupOrcamento.Name = "groupOrcamento";
            this.groupOrcamento.Size = new System.Drawing.Size(372, 455);
            this.groupOrcamento.TabIndex = 0;
            this.groupOrcamento.TabStop = false;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(140, 422);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(143, 23);
            this.cboStatus.TabIndex = 27;
            // 
            // cboCor
            // 
            this.cboCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCor.FormattingEnabled = true;
            this.cboCor.Location = new System.Drawing.Point(199, 134);
            this.cboCor.Name = "cboCor";
            this.cboCor.Size = new System.Drawing.Size(121, 23);
            this.cboCor.TabIndex = 11;
            this.cboCor.Validating += new System.ComponentModel.CancelEventHandler(this.cboCor_Validating);
            // 
            // txtImeiSegundario
            // 
            // 
            // 
            // 
            this.txtImeiSegundario.CustomButton.Image = null;
            this.txtImeiSegundario.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtImeiSegundario.CustomButton.Name = "";
            this.txtImeiSegundario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtImeiSegundario.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtImeiSegundario.CustomButton.TabIndex = 1;
            this.txtImeiSegundario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtImeiSegundario.CustomButton.UseSelectable = true;
            this.txtImeiSegundario.CustomButton.Visible = false;
            this.txtImeiSegundario.Lines = new string[0];
            this.txtImeiSegundario.Location = new System.Drawing.Point(189, 182);
            this.txtImeiSegundario.MaxLength = 15;
            this.txtImeiSegundario.Name = "txtImeiSegundario";
            this.txtImeiSegundario.PasswordChar = '\0';
            this.txtImeiSegundario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtImeiSegundario.SelectedText = "";
            this.txtImeiSegundario.SelectionLength = 0;
            this.txtImeiSegundario.SelectionStart = 0;
            this.txtImeiSegundario.ShortcutsEnabled = true;
            this.txtImeiSegundario.Size = new System.Drawing.Size(177, 23);
            this.txtImeiSegundario.TabIndex = 16;
            this.txtImeiSegundario.UseSelectable = true;
            this.txtImeiSegundario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtImeiSegundario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtImeiSegundario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImeiPrimario_KeyPress);
            this.txtImeiSegundario.Validating += new System.ComponentModel.CancelEventHandler(this.txtImeiSegundario_Validating);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(140, 400);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 19);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status";
            // 
            // txtPreco
            // 
            // 
            // 
            // 
            this.txtPreco.CustomButton.Image = null;
            this.txtPreco.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtPreco.CustomButton.Name = "";
            this.txtPreco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPreco.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtPreco.CustomButton.TabIndex = 1;
            this.txtPreco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPreco.CustomButton.UseSelectable = true;
            this.txtPreco.CustomButton.Visible = false;
            this.txtPreco.Lines = new string[] {
        "R$ 0,00"};
            this.txtPreco.Location = new System.Drawing.Point(6, 422);
            this.txtPreco.MaxLength = 30;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Numero = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPreco.SelectedText = "";
            this.txtPreco.SelectionLength = 0;
            this.txtPreco.SelectionStart = 0;
            this.txtPreco.ShortcutsEnabled = true;
            this.txtPreco.Size = new System.Drawing.Size(128, 23);
            this.txtPreco.TabIndex = 25;
            this.txtPreco.Text = "R$ 0,00";
            this.txtPreco.UseSelectable = true;
            this.txtPreco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPreco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPreco.Validating += new System.ComponentModel.CancelEventHandler(this.txtPreco_Validating);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(6, 400);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(43, 19);
            this.lblPreco.TabIndex = 24;
            this.lblPreco.Text = "Preço";
            // 
            // txtDescricaoOrcamento
            // 
            // 
            // 
            // 
            this.txtDescricaoOrcamento.CustomButton.Image = null;
            this.txtDescricaoOrcamento.CustomButton.Location = new System.Drawing.Point(338, 1);
            this.txtDescricaoOrcamento.CustomButton.Name = "";
            this.txtDescricaoOrcamento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescricaoOrcamento.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtDescricaoOrcamento.CustomButton.TabIndex = 1;
            this.txtDescricaoOrcamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricaoOrcamento.CustomButton.UseSelectable = true;
            this.txtDescricaoOrcamento.CustomButton.Visible = false;
            this.txtDescricaoOrcamento.Lines = new string[0];
            this.txtDescricaoOrcamento.Location = new System.Drawing.Point(6, 374);
            this.txtDescricaoOrcamento.MaxLength = 70;
            this.txtDescricaoOrcamento.Name = "txtDescricaoOrcamento";
            this.txtDescricaoOrcamento.PasswordChar = '\0';
            this.txtDescricaoOrcamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricaoOrcamento.SelectedText = "";
            this.txtDescricaoOrcamento.SelectionLength = 0;
            this.txtDescricaoOrcamento.SelectionStart = 0;
            this.txtDescricaoOrcamento.ShortcutsEnabled = true;
            this.txtDescricaoOrcamento.Size = new System.Drawing.Size(360, 23);
            this.txtDescricaoOrcamento.TabIndex = 23;
            this.txtDescricaoOrcamento.UseSelectable = true;
            this.txtDescricaoOrcamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricaoOrcamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescricaoOrcamento.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescricaoOrcamento_Validating);
            // 
            // lblDescricaoOrcamento
            // 
            this.lblDescricaoOrcamento.AutoSize = true;
            this.lblDescricaoOrcamento.Location = new System.Drawing.Point(6, 352);
            this.lblDescricaoOrcamento.Name = "lblDescricaoOrcamento";
            this.lblDescricaoOrcamento.Size = new System.Drawing.Size(156, 19);
            this.lblDescricaoOrcamento.TabIndex = 22;
            this.lblDescricaoOrcamento.Text = "Descrição do Orçamento";
            // 
            // lblAcessorios
            // 
            this.lblAcessorios.AutoSize = true;
            this.lblAcessorios.Location = new System.Drawing.Point(6, 304);
            this.lblAcessorios.Name = "lblAcessorios";
            this.lblAcessorios.Size = new System.Drawing.Size(70, 19);
            this.lblAcessorios.TabIndex = 21;
            this.lblAcessorios.Text = "Acessórios";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chkTampa);
            this.flowLayoutPanel1.Controls.Add(this.chkBateria);
            this.flowLayoutPanel1.Controls.Add(this.chkCartaoSD);
            this.flowLayoutPanel1.Controls.Add(this.chkCapa);
            this.flowLayoutPanel1.Controls.Add(this.chkCartaoSIM);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 326);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(360, 23);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // chkTampa
            // 
            this.chkTampa.AutoSize = true;
            this.chkTampa.Location = new System.Drawing.Point(3, 3);
            this.chkTampa.Name = "chkTampa";
            this.chkTampa.Size = new System.Drawing.Size(59, 15);
            this.chkTampa.TabIndex = 0;
            this.chkTampa.Text = "Tampa";
            this.chkTampa.UseSelectable = true;
            // 
            // chkBateria
            // 
            this.chkBateria.AutoSize = true;
            this.chkBateria.Location = new System.Drawing.Point(68, 3);
            this.chkBateria.Name = "chkBateria";
            this.chkBateria.Size = new System.Drawing.Size(59, 15);
            this.chkBateria.TabIndex = 1;
            this.chkBateria.Text = "Bateria";
            this.chkBateria.UseSelectable = true;
            // 
            // chkCartaoSD
            // 
            this.chkCartaoSD.AutoSize = true;
            this.chkCartaoSD.Location = new System.Drawing.Point(133, 3);
            this.chkCartaoSD.Name = "chkCartaoSD";
            this.chkCartaoSD.Size = new System.Drawing.Size(75, 15);
            this.chkCartaoSD.TabIndex = 2;
            this.chkCartaoSD.Text = "Cartão SD";
            this.chkCartaoSD.UseSelectable = true;
            // 
            // chkCapa
            // 
            this.chkCapa.AutoSize = true;
            this.chkCapa.Location = new System.Drawing.Point(214, 3);
            this.chkCapa.Name = "chkCapa";
            this.chkCapa.Size = new System.Drawing.Size(50, 15);
            this.chkCapa.TabIndex = 3;
            this.chkCapa.Text = "Capa";
            this.chkCapa.UseSelectable = true;
            // 
            // chkCartaoSIM
            // 
            this.chkCartaoSIM.AutoSize = true;
            this.chkCartaoSIM.Location = new System.Drawing.Point(270, 3);
            this.chkCartaoSIM.Name = "chkCartaoSIM";
            this.chkCartaoSIM.Size = new System.Drawing.Size(81, 15);
            this.chkCartaoSIM.TabIndex = 4;
            this.chkCartaoSIM.Text = "Cartão SIM";
            this.chkCartaoSIM.UseSelectable = true;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(6, 256);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(85, 19);
            this.lblObservacao.TabIndex = 19;
            this.lblObservacao.Text = "Observações";
            // 
            // txtObservacoes
            // 
            // 
            // 
            // 
            this.txtObservacoes.CustomButton.Image = null;
            this.txtObservacoes.CustomButton.Location = new System.Drawing.Point(338, 1);
            this.txtObservacoes.CustomButton.Name = "";
            this.txtObservacoes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtObservacoes.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtObservacoes.CustomButton.TabIndex = 1;
            this.txtObservacoes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObservacoes.CustomButton.UseSelectable = true;
            this.txtObservacoes.CustomButton.Visible = false;
            this.txtObservacoes.Lines = new string[0];
            this.txtObservacoes.Location = new System.Drawing.Point(6, 278);
            this.txtObservacoes.MaxLength = 100;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.PasswordChar = '\0';
            this.txtObservacoes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacoes.SelectedText = "";
            this.txtObservacoes.SelectionLength = 0;
            this.txtObservacoes.SelectionStart = 0;
            this.txtObservacoes.ShortcutsEnabled = true;
            this.txtObservacoes.Size = new System.Drawing.Size(360, 23);
            this.txtObservacoes.TabIndex = 20;
            this.txtObservacoes.UseSelectable = true;
            this.txtObservacoes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservacoes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblReclamacao
            // 
            this.lblReclamacao.AutoSize = true;
            this.lblReclamacao.Location = new System.Drawing.Point(6, 208);
            this.lblReclamacao.Name = "lblReclamacao";
            this.lblReclamacao.Size = new System.Drawing.Size(80, 19);
            this.lblReclamacao.TabIndex = 17;
            this.lblReclamacao.Text = "Reclamação";
            // 
            // lblIMEI
            // 
            this.lblIMEI.AutoSize = true;
            this.lblIMEI.Location = new System.Drawing.Point(6, 160);
            this.lblIMEI.Name = "lblIMEI";
            this.lblIMEI.Size = new System.Drawing.Size(89, 19);
            this.lblIMEI.TabIndex = 13;
            this.lblIMEI.Text = "IMEI Primário";
            // 
            // btnCor
            // 
            this.btnCor.CausesValidation = false;
            this.btnCor.Location = new System.Drawing.Point(326, 134);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(40, 23);
            this.btnCor.TabIndex = 12;
            this.btnCor.Text = ". . .";
            this.btnCor.UseSelectable = true;
            this.btnCor.Click += new System.EventHandler(this.btnCor_Click);
            // 
            // lblIMEI2
            // 
            this.lblIMEI2.AutoSize = true;
            this.lblIMEI2.Location = new System.Drawing.Point(189, 160);
            this.lblIMEI2.Name = "lblIMEI2";
            this.lblIMEI2.Size = new System.Drawing.Size(103, 19);
            this.lblIMEI2.TabIndex = 15;
            this.lblIMEI2.Text = "IMEI Secundário";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(199, 112);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(31, 19);
            this.lblCor.TabIndex = 10;
            this.lblCor.Text = "Cor";
            // 
            // lblAparelho
            // 
            this.lblAparelho.AutoSize = true;
            this.lblAparelho.Location = new System.Drawing.Point(6, 64);
            this.lblAparelho.Name = "lblAparelho";
            this.lblAparelho.Size = new System.Drawing.Size(63, 19);
            this.lblAparelho.TabIndex = 3;
            this.lblAparelho.Text = "Aparelho";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 112);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 19);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca";
            // 
            // txtReclamacao
            // 
            // 
            // 
            // 
            this.txtReclamacao.CustomButton.Image = null;
            this.txtReclamacao.CustomButton.Location = new System.Drawing.Point(338, 1);
            this.txtReclamacao.CustomButton.Name = "";
            this.txtReclamacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReclamacao.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtReclamacao.CustomButton.TabIndex = 1;
            this.txtReclamacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReclamacao.CustomButton.UseSelectable = true;
            this.txtReclamacao.CustomButton.Visible = false;
            this.txtReclamacao.Lines = new string[0];
            this.txtReclamacao.Location = new System.Drawing.Point(6, 230);
            this.txtReclamacao.MaxLength = 70;
            this.txtReclamacao.Name = "txtReclamacao";
            this.txtReclamacao.PasswordChar = '\0';
            this.txtReclamacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReclamacao.SelectedText = "";
            this.txtReclamacao.SelectionLength = 0;
            this.txtReclamacao.SelectionStart = 0;
            this.txtReclamacao.ShortcutsEnabled = true;
            this.txtReclamacao.Size = new System.Drawing.Size(360, 23);
            this.txtReclamacao.TabIndex = 18;
            this.txtReclamacao.UseSelectable = true;
            this.txtReclamacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReclamacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtReclamacao.Validating += new System.ComponentModel.CancelEventHandler(this.txtReclamacao_Validating);
            // 
            // txtImeiPrimario
            // 
            // 
            // 
            // 
            this.txtImeiPrimario.CustomButton.Image = null;
            this.txtImeiPrimario.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtImeiPrimario.CustomButton.Name = "";
            this.txtImeiPrimario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtImeiPrimario.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtImeiPrimario.CustomButton.TabIndex = 1;
            this.txtImeiPrimario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtImeiPrimario.CustomButton.UseSelectable = true;
            this.txtImeiPrimario.CustomButton.Visible = false;
            this.txtImeiPrimario.Lines = new string[0];
            this.txtImeiPrimario.Location = new System.Drawing.Point(6, 182);
            this.txtImeiPrimario.MaxLength = 15;
            this.txtImeiPrimario.Name = "txtImeiPrimario";
            this.txtImeiPrimario.PasswordChar = '\0';
            this.txtImeiPrimario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtImeiPrimario.SelectedText = "";
            this.txtImeiPrimario.SelectionLength = 0;
            this.txtImeiPrimario.SelectionStart = 0;
            this.txtImeiPrimario.ShortcutsEnabled = true;
            this.txtImeiPrimario.Size = new System.Drawing.Size(177, 23);
            this.txtImeiPrimario.TabIndex = 14;
            this.txtImeiPrimario.UseSelectable = true;
            this.txtImeiPrimario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtImeiPrimario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtImeiPrimario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImeiPrimario_KeyPress);
            this.txtImeiPrimario.Validating += new System.ComponentModel.CancelEventHandler(this.txtImeiPrimario_Validating);
            // 
            // txtAparelho
            // 
            // 
            // 
            // 
            this.txtAparelho.CustomButton.Image = null;
            this.txtAparelho.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtAparelho.CustomButton.Name = "";
            this.txtAparelho.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAparelho.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtAparelho.CustomButton.TabIndex = 1;
            this.txtAparelho.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAparelho.CustomButton.UseSelectable = true;
            this.txtAparelho.CustomButton.Visible = false;
            this.txtAparelho.Lines = new string[0];
            this.txtAparelho.Location = new System.Drawing.Point(6, 86);
            this.txtAparelho.MaxLength = 32767;
            this.txtAparelho.Name = "txtAparelho";
            this.txtAparelho.PasswordChar = '\0';
            this.txtAparelho.ReadOnly = true;
            this.txtAparelho.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAparelho.SelectedText = "";
            this.txtAparelho.SelectionLength = 0;
            this.txtAparelho.SelectionStart = 0;
            this.txtAparelho.ShortcutsEnabled = true;
            this.txtAparelho.Size = new System.Drawing.Size(94, 23);
            this.txtAparelho.TabIndex = 4;
            this.txtAparelho.UseSelectable = true;
            this.txtAparelho.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAparelho.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMarca
            // 
            // 
            // 
            // 
            this.txtMarca.CustomButton.Image = null;
            this.txtMarca.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtMarca.CustomButton.Name = "";
            this.txtMarca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMarca.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtMarca.CustomButton.TabIndex = 1;
            this.txtMarca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMarca.CustomButton.UseSelectable = true;
            this.txtMarca.CustomButton.Visible = false;
            this.txtMarca.Lines = new string[0];
            this.txtMarca.Location = new System.Drawing.Point(6, 134);
            this.txtMarca.MaxLength = 32767;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.ReadOnly = true;
            this.txtMarca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMarca.SelectedText = "";
            this.txtMarca.SelectionLength = 0;
            this.txtMarca.SelectionStart = 0;
            this.txtMarca.ShortcutsEnabled = true;
            this.txtMarca.Size = new System.Drawing.Size(187, 23);
            this.txtMarca.TabIndex = 9;
            this.txtMarca.UseSelectable = true;
            this.txtMarca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMarca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAparelho
            // 
            this.btnAparelho.CausesValidation = false;
            this.btnAparelho.Location = new System.Drawing.Point(326, 86);
            this.btnAparelho.Name = "btnAparelho";
            this.btnAparelho.Size = new System.Drawing.Size(40, 23);
            this.btnAparelho.TabIndex = 7;
            this.btnAparelho.Text = ". . .";
            this.btnAparelho.UseSelectable = true;
            this.btnAparelho.Click += new System.EventHandler(this.btnAparelho_Click);
            // 
            // txtModeloAparelho
            // 
            // 
            // 
            // 
            this.txtModeloAparelho.CustomButton.Image = null;
            this.txtModeloAparelho.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtModeloAparelho.CustomButton.Name = "";
            this.txtModeloAparelho.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModeloAparelho.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtModeloAparelho.CustomButton.TabIndex = 1;
            this.txtModeloAparelho.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModeloAparelho.CustomButton.UseSelectable = true;
            this.txtModeloAparelho.CustomButton.Visible = false;
            this.txtModeloAparelho.Lines = new string[0];
            this.txtModeloAparelho.Location = new System.Drawing.Point(106, 86);
            this.txtModeloAparelho.MaxLength = 32767;
            this.txtModeloAparelho.Name = "txtModeloAparelho";
            this.txtModeloAparelho.PasswordChar = '\0';
            this.txtModeloAparelho.ReadOnly = true;
            this.txtModeloAparelho.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModeloAparelho.SelectedText = "";
            this.txtModeloAparelho.SelectionLength = 0;
            this.txtModeloAparelho.SelectionStart = 0;
            this.txtModeloAparelho.ShortcutsEnabled = true;
            this.txtModeloAparelho.Size = new System.Drawing.Size(214, 23);
            this.txtModeloAparelho.TabIndex = 6;
            this.txtModeloAparelho.UseSelectable = true;
            this.txtModeloAparelho.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModeloAparelho.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtModeloAparelho.Validating += new System.ComponentModel.CancelEventHandler(this.txtModeloAparelho_Validating);
            // 
            // lblModeloAparelho
            // 
            this.lblModeloAparelho.AutoSize = true;
            this.lblModeloAparelho.Location = new System.Drawing.Point(106, 64);
            this.lblModeloAparelho.Name = "lblModeloAparelho";
            this.lblModeloAparelho.Size = new System.Drawing.Size(133, 19);
            this.lblModeloAparelho.TabIndex = 5;
            this.lblModeloAparelho.Text = "Modelo do Aparelho";
            // 
            // btnCliente
            // 
            this.btnCliente.CausesValidation = false;
            this.btnCliente.Location = new System.Drawing.Point(326, 38);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(40, 23);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = ". . .";
            this.btnCliente.UseSelectable = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // txtCliente
            // 
            // 
            // 
            // 
            this.txtCliente.CustomButton.Image = null;
            this.txtCliente.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtCliente.CustomButton.Name = "";
            this.txtCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtCliente.CustomButton.TabIndex = 1;
            this.txtCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCliente.CustomButton.UseSelectable = true;
            this.txtCliente.CustomButton.Visible = false;
            this.txtCliente.Lines = new string[0];
            this.txtCliente.Location = new System.Drawing.Point(6, 38);
            this.txtCliente.MaxLength = 32767;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.ReadOnly = true;
            this.txtCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCliente.SelectedText = "";
            this.txtCliente.SelectionLength = 0;
            this.txtCliente.SelectionStart = 0;
            this.txtCliente.ShortcutsEnabled = true;
            this.txtCliente.Size = new System.Drawing.Size(314, 23);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.UseSelectable = true;
            this.txtCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtCliente_Validating);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 16);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 19);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(223, 524);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.CausesValidation = false;
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(304, 524);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseSelectable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnImprimirOS
            // 
            this.btnImprimirOS.Location = new System.Drawing.Point(7, 524);
            this.btnImprimirOS.Name = "btnImprimirOS";
            this.btnImprimirOS.Size = new System.Drawing.Size(81, 23);
            this.btnImprimirOS.TabIndex = 5;
            this.btnImprimirOS.Text = "Imprimir OS";
            this.btnImprimirOS.UseSelectable = true;
            this.btnImprimirOS.Click += new System.EventHandler(this.btnImprimirOS_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // frmOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 555);
            this.Controls.Add(this.btnImprimirOS);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupOrcamento);
            this.Name = "frmOS";
            this.Resizable = false;
            this.Text = "Ordem de Serviço";
            this.Load += new System.EventHandler(this.frmOS_Load);
            this.groupOrcamento.ResumeLayout(false);
            this.groupOrcamento.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupOrcamento;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroCheckBox chkTampa;
        private MetroFramework.Controls.MetroCheckBox chkBateria;
        private MetroFramework.Controls.MetroCheckBox chkCartaoSD;
        private MetroFramework.Controls.MetroCheckBox chkCapa;
        private MetroFramework.Controls.MetroCheckBox chkCartaoSIM;
        private MetroFramework.Controls.MetroLabel lblObservacao;
        private MetroFramework.Controls.MetroTextBox txtObservacoes;
        private MetroFramework.Controls.MetroLabel lblReclamacao;
        private MetroFramework.Controls.MetroLabel lblIMEI;
        private MetroFramework.Controls.MetroButton btnCor;
        private MetroFramework.Controls.MetroLabel lblIMEI2;
        private MetroFramework.Controls.MetroLabel lblCor;
        private MetroFramework.Controls.MetroLabel lblAparelho;
        private MetroFramework.Controls.MetroLabel lblMarca;
        private MetroFramework.Controls.MetroTextBox txtReclamacao;
        private MetroFramework.Controls.MetroTextBox txtImeiPrimario;
        private MetroFramework.Controls.MetroTextBox txtAparelho;
        private MetroFramework.Controls.MetroTextBox txtMarca;
        private MetroFramework.Controls.MetroButton btnAparelho;
        private MetroFramework.Controls.MetroTextBox txtModeloAparelho;
        private MetroFramework.Controls.MetroLabel lblModeloAparelho;
        private MetroFramework.Controls.MetroButton btnCliente;
        private MetroFramework.Controls.MetroTextBox txtCliente;
        private MetroFramework.Controls.MetroLabel lblCliente;
        private MetroFramework.Controls.MetroTextBox txtDescricaoOrcamento;
        private MetroFramework.Controls.MetroLabel lblDescricaoOrcamento;
        private MetroFramework.Controls.MetroLabel lblAcessorios;
        private MetroFramework.Controls.MetroLabel lblPreco;
        private Controles.CurrencyTextBox txtPreco;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboCor;
        private MetroFramework.Controls.MetroTextBox txtImeiSegundario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroButton btnImprimirOS;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}