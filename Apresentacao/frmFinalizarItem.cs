using Apresentacao.Validacoes;
using MetroFramework.Forms;
using Modelo;
using Modelo.Enums;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmFinalizarItem : MetroForm
    {
        IPendente modelo;
        public frmFinalizarItem(IPendente item)
        {
            InitializeComponent();
            Text = Text + " " + item.GetType().Name;
            modelo = item;
            Construtor();
        }

        public void Construtor()
        {
            dgvPagamentos.DataSource = modelo.PagamentosColecao;
            txtValorPendente.Numero = modelo.Valor;
            cboPagamento.DataSource = Enum.GetValues(typeof(Pagamentos));
            numericVezes.Visible = lblVezes.Visible = false;
        }

        public bool Cupom => chkCupom.Checked;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Pagamentos pagamentoSelecionado = (Pagamentos)cboPagamento.SelectedItem;
            if (txtValor.Numero == decimal.Zero)
                MessageBox.Show("Valor nulo inválido");
            else if (modelo.PagamentosColecao.Any(a => a.PagamentoSelecionado == pagamentoSelecionado))
                MessageBox.Show("Pagamento já incluso na lista");
            else if (txtValorPendente.Numero < (txtValor.Numero + txtValorVariavel.Numero))
                MessageBox.Show("Pagamento ultrapassou o valor do produto");
            else
            {
                modelo.PagamentosColecao.Add(new Pagamento()
                {
                    PagamentoSelecionado = pagamentoSelecionado,
                    Valor = txtValor.Numero,
                    Vezes = pagamentoSelecionado != Pagamentos.Crédito ? (byte?)null : (byte)numericVezes.Value
                });
                if (pagamentoSelecionado == Pagamentos.Desconto)
                    txtValorPendente.Numero = txtValorPendente.Numero - txtValor.Numero;
                else
                    txtValorVariavel.Numero = txtValorVariavel.Numero + txtValor.Numero;
                txtValor.Numero = 0;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvPagamentos.CurrentRow == null)
                MessageBox.Show("Selecione uma linha para remover pagamento");
            else
            {
                Pagamento pgto = dgvPagamentos.CurrentRow.DataBoundItem as Pagamento;
                if (pgto.PagamentoSelecionado == Pagamentos.Desconto)
                    txtValorPendente.Numero = txtValorPendente.Numero + pgto.Valor;
                else
                    txtValorVariavel.Numero = txtValorVariavel.Numero - pgto.Valor;
                modelo.PagamentosColecao.Remove(pgto);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtValorPendente.Numero == txtValorVariavel.Numero)
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Valor atual e valor pendente nãõ são iguais");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja cancelar o item atual?","Tem certeza",MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                modelo.PagamentosColecao.Clear();
                DialogResult = DialogResult.Cancel;
            }
        }

        private void chkCupom_CheckedChanged(object sender, EventArgs e)
        {           
            if (chkCupom.Checked == true)
            {
                string impressora = Properties.Settings.Default.ImpressoraCupom;
                ImpressoraStatus status = Validacoes.Validacoes.VerificarImpressora(impressora);
                if (status == ImpressoraStatus.Desconectada)
                    MessageBox.Show("Impressora " + impressora + " não encontrada no sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (status == ImpressoraStatus.Ocupada)
                    MessageBox.Show("Impressora " + impressora + " se encontra ocupada");
                else if(status == ImpressoraStatus.Offline)
                    MessageBox.Show("Impressora " + impressora + " se encontra offline");
                chkCupom.Checked = status == ImpressoraStatus.Online;
            }
        }

        private void frmFinalizarItem_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }

        private void cboPagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            Pagamentos pagamento = (Pagamentos)cboPagamento.SelectedItem;
            if (pagamento == Pagamentos.Crédito) numericVezes.Visible = lblVezes.Visible = true;
            else numericVezes.Visible = lblVezes.Visible = false;
        }
    }
}
