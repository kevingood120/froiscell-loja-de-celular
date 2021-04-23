namespace Apresentacao
{
    partial class frmPrincipal
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
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.tileCliente = new MetroFramework.Controls.MetroTile();
            this.tileOS = new MetroFramework.Controls.MetroTile();
            this.tileVenda = new MetroFramework.Controls.MetroTile();
            this.tileProdutos = new MetroFramework.Controls.MetroTile();
            this.tileOutros = new MetroFramework.Controls.MetroTile();
            this.tileCaixa = new MetroFramework.Controls.MetroTile();
            this.metroSair = new MetroFramework.Controls.MetroTile();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.tileCliente);
            this.panelMenu.Controls.Add(this.tileOS);
            this.panelMenu.Controls.Add(this.tileVenda);
            this.panelMenu.Controls.Add(this.tileProdutos);
            this.panelMenu.Controls.Add(this.tileOutros);
            this.panelMenu.Controls.Add(this.tileCaixa);
            this.panelMenu.Controls.Add(this.metroSair);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(10, 60);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1168, 96);
            this.panelMenu.TabIndex = 0;
            // 
            // tileCliente
            // 
            this.tileCliente.ActiveControl = null;
            this.tileCliente.Location = new System.Drawing.Point(3, 3);
            this.tileCliente.Name = "tileCliente";
            this.tileCliente.Size = new System.Drawing.Size(112, 89);
            this.tileCliente.TabIndex = 0;
            this.tileCliente.Text = "Cliente";
            this.tileCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileCliente.TileImage = global::Apresentacao.Properties.Resources.appbar_user;
            this.tileCliente.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileCliente.UseSelectable = true;
            this.tileCliente.UseTileImage = true;
            this.tileCliente.Click += new System.EventHandler(this.tileCliente_Click);
            // 
            // tileOS
            // 
            this.tileOS.ActiveControl = null;
            this.tileOS.Location = new System.Drawing.Point(121, 3);
            this.tileOS.Name = "tileOS";
            this.tileOS.Size = new System.Drawing.Size(112, 89);
            this.tileOS.TabIndex = 1;
            this.tileOS.Text = "OS";
            this.tileOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileOS.TileImage = global::Apresentacao.Properties.Resources.appbar_paper;
            this.tileOS.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileOS.UseSelectable = true;
            this.tileOS.UseTileImage = true;
            this.tileOS.Click += new System.EventHandler(this.tileOS_Click);
            // 
            // tileVenda
            // 
            this.tileVenda.ActiveControl = null;
            this.tileVenda.Location = new System.Drawing.Point(239, 3);
            this.tileVenda.Name = "tileVenda";
            this.tileVenda.Size = new System.Drawing.Size(112, 89);
            this.tileVenda.TabIndex = 5;
            this.tileVenda.Text = "Venda";
            this.tileVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileVenda.TileImage = global::Apresentacao.Properties.Resources.appbar_cart;
            this.tileVenda.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileVenda.UseSelectable = true;
            this.tileVenda.UseTileImage = true;
            this.tileVenda.Click += new System.EventHandler(this.tileVenda_Click);
            // 
            // tileProdutos
            // 
            this.tileProdutos.ActiveControl = null;
            this.tileProdutos.Location = new System.Drawing.Point(357, 3);
            this.tileProdutos.Name = "tileProdutos";
            this.tileProdutos.Size = new System.Drawing.Size(112, 89);
            this.tileProdutos.TabIndex = 3;
            this.tileProdutos.Text = "Produtos";
            this.tileProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileProdutos.TileImage = global::Apresentacao.Properties.Resources.appbar_iphone;
            this.tileProdutos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileProdutos.UseSelectable = true;
            this.tileProdutos.UseTileImage = true;
            this.tileProdutos.Click += new System.EventHandler(this.tileProdutos_Click);
            // 
            // tileOutros
            // 
            this.tileOutros.ActiveControl = null;
            this.tileOutros.Location = new System.Drawing.Point(475, 3);
            this.tileOutros.Name = "tileOutros";
            this.tileOutros.Size = new System.Drawing.Size(112, 89);
            this.tileOutros.TabIndex = 6;
            this.tileOutros.Text = "Outros Cad.";
            this.tileOutros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileOutros.TileImage = global::Apresentacao.Properties.Resources.appbar_page_small;
            this.tileOutros.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileOutros.UseSelectable = true;
            this.tileOutros.UseTileImage = true;
            this.tileOutros.Click += new System.EventHandler(this.tileOutros_Click);
            // 
            // tileCaixa
            // 
            this.tileCaixa.ActiveControl = null;
            this.tileCaixa.Location = new System.Drawing.Point(593, 3);
            this.tileCaixa.Name = "tileCaixa";
            this.tileCaixa.Size = new System.Drawing.Size(112, 89);
            this.tileCaixa.TabIndex = 4;
            this.tileCaixa.Text = "Caixa";
            this.tileCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileCaixa.TileImage = global::Apresentacao.Properties.Resources.appbar_billing;
            this.tileCaixa.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileCaixa.UseSelectable = true;
            this.tileCaixa.UseTileImage = true;
            this.tileCaixa.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroSair
            // 
            this.metroSair.ActiveControl = null;
            this.metroSair.Location = new System.Drawing.Point(711, 3);
            this.metroSair.Name = "metroSair";
            this.metroSair.Size = new System.Drawing.Size(112, 89);
            this.metroSair.TabIndex = 5;
            this.metroSair.Text = "Sair";
            this.metroSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroSair.TileImage = global::Apresentacao.Properties.Resources.appbar_close;
            this.metroSair.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroSair.UseSelectable = true;
            this.metroSair.UseTileImage = true;
            this.metroSair.Click += new System.EventHandler(this.metroSair_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Apresentacao.Properties.Resources.logo_froiscell;
            this.pictureBox1.Location = new System.Drawing.Point(10, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(1168, 501);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 667);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMenu);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "frmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Resizable = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private MetroFramework.Controls.MetroTile tileCliente;
        private MetroFramework.Controls.MetroTile tileOS;
        private MetroFramework.Controls.MetroTile tileVenda;
        private MetroFramework.Controls.MetroTile tileCaixa;
        private MetroFramework.Controls.MetroTile tileProdutos;
        private MetroFramework.Controls.MetroTile metroSair;
        private MetroFramework.Controls.MetroTile tileOutros;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}