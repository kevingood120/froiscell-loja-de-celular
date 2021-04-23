using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using Apresentacao.Validacoes;
using MetroFramework;

namespace Apresentacao
{
    public partial class frmPrincipal : MetroForm
    {

        public frmPrincipal()
        {
            InitializeComponent();
            IniciarMetroContextMenu();
            Text = Properties.Settings.Default.Empresa.ToLower();
            components.SetDefaultStyle(this, MetroColorStyle.Purple);
        }

        public void IniciarMetroContextMenu()
        {
            metroContextMenu1.Items.Add("CEP").Click += (e, s) =>
            {
                frmConsultarCEP cep = new frmConsultarCEP();
                cep.ShowDialog();
                cep.Dispose();
            };
            metroContextMenu1.Items.Add("Aparelho").Click += (e, s) =>
            {
                frmConsultarAparelho aparelho = new frmConsultarAparelho();
                aparelho.ShowDialog();
                aparelho.Dispose();
            };
            metroContextMenu1.Items.Add("Adicionar ou remover dinheiro").Click += (e, s) =>
            {
                frmAdicionarDinheiroCaixa frmAdicionarDinheiroCaixa = new frmAdicionarDinheiroCaixa();
                frmAdicionarDinheiroCaixa.ShowDialog();
                frmAdicionarDinheiroCaixa.Dispose();
            };
        }

        private void tileCliente_Click(object sender, EventArgs e)
        {
            frmConsultarCliente cliente = new frmConsultarCliente();
            cliente.ShowDialog();
            cliente.Dispose();
        }

        private void tileOS_Click(object sender, EventArgs e)
        {
            frmConsultarOS frmConsultarOS = new frmConsultarOS();
            frmConsultarOS.ShowDialog();
            frmConsultarOS.Dispose();
        }

        private void tileVenda_Click(object sender, EventArgs e)
        {
            frmVenda venda = new frmVenda(new Modelo.Venda());
            venda.ShowDialog();
            venda.Dispose();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            FrmCaixa caixa = new FrmCaixa();
            caixa.ShowDialog();
            caixa.Dispose();
        }

        private void tileProdutos_Click(object sender, EventArgs e)
        {
            frmConsultarProduto frmConsultarProduto = new frmConsultarProduto();
            frmConsultarProduto.ShowDialog();
            frmConsultarProduto.Dispose();
        }

        private void metroSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tileOutros_Click(object sender, EventArgs e)
        {
            tileOutros.ContextMenuStrip = metroContextMenu1;
            Point ptLowerLeft = new Point(0, tileOutros.Height);
            ptLowerLeft = tileOutros.PointToScreen(ptLowerLeft);
            metroContextMenu1.Show(ptLowerLeft);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }
    }
}
