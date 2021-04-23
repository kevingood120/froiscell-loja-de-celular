using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql
{
    public class MovimentacaoCaixaBanco
    {
        MySqlController mySqlController = new MySqlController();

        public void Adicionar(MovimentacaoCaixa movimentacaoCaixa)
        {
            try
            {
                mySqlController.LimpaParametros();
                mySqlController.AdicionaParametro("@razao", movimentacaoCaixa.Razao);
                mySqlController.AdicionaParametro("@valor", movimentacaoCaixa.Valor);
                mySqlController.AdicionaParametro("@subtrair", movimentacaoCaixa.Subtrair);
                string comando = "INSERT INTO tb_movimentacao_caixa VALUES (NULL, criarcaixa(), @razao, @valor, @subtrair, DEFAULT)";
                movimentacaoCaixa.Cod_mov = mySqlController.ExecuteNonQuery(comando);
                mySqlController.Commit();
            }
            catch
            {
                mySqlController.Rollback();
                throw;
            }
            finally
            {
                mySqlController.FechaConexaoTransacao();
            }
        }
    }
}
