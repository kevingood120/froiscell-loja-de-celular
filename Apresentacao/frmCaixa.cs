using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Modelo;
using MySql;
using Microsoft.Reporting.WinForms;
using Apresentacao.Validacoes;

namespace Apresentacao
{
    public partial class FrmCaixa : MetroForm
    {
        CaixaBanco caixaBanco = new CaixaBanco();
        public FrmCaixa()
        {
            InitializeComponent();
            reportCaixa.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
            reportCaixa.ZoomMode = ZoomMode.PageWidth;
        }

        private void LocalReport_SubreportProcessing(object sender, Microsoft.Reporting.WinForms.SubreportProcessingEventArgs e)
        {
            LocalReport report = sender as LocalReport;
            uint codigo;
            if (e.ReportPath.Contains("RelatorioPagamento.rdlc"))
            {
                bool retorno = Convert.ToBoolean(e.Parameters["Tipo"].Values.FirstOrDefault());
                codigo = Convert.ToUInt32(e.Parameters["Codigo"].Values.FirstOrDefault());
                if (retorno)
                {
                    OSColecao colecaoOS = report.DataSources["dsOrdem"].Value as OSColecao;
                    OS os = colecaoOS.FirstOrDefault(p => p.Cod_ordem == codigo);
                    e.DataSources.Add(new ReportDataSource("dsPagamentos", os.PagamentoColecao));
                }
                else
                {
                    VendaColecao colecaoVenda = report.DataSources["dsVenda"].Value as VendaColecao;
                    Venda venda = colecaoVenda.FirstOrDefault(o => o.Cod_venda == codigo);
                    e.DataSources.Add(new ReportDataSource("dsPagamentos", venda.PagamentoColecao));
                }
            }
            else
            {
                codigo = Convert.ToUInt32(e.Parameters["CodigoVenda"].Values.FirstOrDefault());
                VendaColecao colecaoVenda = report.DataSources["dsVenda"].Value as VendaColecao;
                Venda venda = colecaoVenda.FirstOrDefault(o => o.Cod_venda == codigo);
                e.DataSources.Add(new ReportDataSource("dsItensVenda", venda.Itens));
            }                    
        }

        private void PesquisarCaixa(DateTime dataInicial, DateTime? dataFinal)
        {
            OSColecao oSColecao = caixaBanco.PesquisarOrdemCaixa(dataInicial, dataFinal);
            VendaColecao vendaColecao = caixaBanco.PesquisarVendaCaixa(dataInicial, dataFinal);
            MovimentacaoCaixaColecao movimentacaoCaixas = caixaBanco.PesquisarMovimentacaoCaixa(dataInicial, dataFinal);
            reportCaixa.LocalReport.DataSources.Clear();
            reportCaixa.LocalReport.ReportEmbeddedResource = "Apresentacao.Relatorios.RelatorioCaixa.rdlc";
            reportCaixa.LocalReport.DataSources.Add(new ReportDataSource("dsVenda", vendaColecao));
            reportCaixa.LocalReport.DataSources.Add(new ReportDataSource("dsOrdem", oSColecao));
            reportCaixa.LocalReport.DataSources.Add(new ReportDataSource("dsMovimentacao", movimentacaoCaixas));
            TotalCaixa(oSColecao, vendaColecao, movimentacaoCaixas);
            reportCaixa.RefreshReport();
        }

        private void TotalCaixa(OSColecao colecaoOS, VendaColecao colecaoVenda, MovimentacaoCaixaColecao movimentacaoCaixas)
        {
            Totalizadores totalizadores = new Totalizadores();

            foreach (var os in colecaoOS)
            {
                totalizadores.Total = totalizadores.Total + os.PagamentoColecao.Total;
                totalizadores.TotalCredito = totalizadores.TotalCredito + os.PagamentoColecao.TotalCredito;
                totalizadores.TotalDebito = totalizadores.TotalDebito + os.PagamentoColecao.TotalDebito;
                totalizadores.TotalDesconto = totalizadores.TotalDesconto + os.PagamentoColecao.TotalDesconto;
                totalizadores.TotalDinheiro = totalizadores.TotalDinheiro + os.PagamentoColecao.TotalDinheiro;
                totalizadores.TotalOS = totalizadores.TotalOS + os.PagamentoColecao.Total;
            }


            foreach (var venda in colecaoVenda)
            {
                totalizadores.Total = totalizadores.Total + venda.PagamentoColecao.Total;
                totalizadores.TotalCredito = totalizadores.TotalCredito + venda.PagamentoColecao.TotalCredito;
                totalizadores.TotalDebito = totalizadores.TotalDebito + venda.PagamentoColecao.TotalDebito;
                totalizadores.TotalDesconto = totalizadores.TotalDesconto + venda.PagamentoColecao.TotalDesconto;
                totalizadores.TotalDinheiro = totalizadores.TotalDinheiro + venda.PagamentoColecao.TotalDinheiro;
                totalizadores.TotalVenda = totalizadores.TotalVenda + venda.PagamentoColecao.Total;
            }
            totalizadores.DinheiroAdicionado = movimentacaoCaixas.DinheiroAdicionado;
            totalizadores.DinheiroRemovido = movimentacaoCaixas.DinheiroSubtraido;

            totalizadores.Total += movimentacaoCaixas.DinheiroAdicionado;
            totalizadores.Total -= movimentacaoCaixas.DinheiroSubtraido;

            reportCaixa.LocalReport.DataSources.Add(new ReportDataSource("dsTotais", new List<Totalizadores>()
            {
                totalizadores
            }));
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime dataInicial, dataFinal;

            bool dataInicialConversao = DateTime.TryParse(mskDataInicial.Text, out dataInicial);
            bool dataFinalConversao = DateTime.TryParse(mskDataFinal.Text, out dataFinal);
            if (dataInicialConversao && dataFinalConversao)
                PesquisarCaixa(dataInicial, dataFinal);
            else if (dataInicialConversao && !dataFinalConversao)
                PesquisarCaixa(dataInicial, null);
            else if (!dataInicialConversao && !dataFinalConversao)
                MessageBox.Show("Verifique as datas de entrada");
            else
                MessageBox.Show("Verifique a data inicial se ela esta correta");
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
            DateTime data = caixaBanco.HoraServidor;
            PesquisarCaixa(data, null);
        }
    }
}
