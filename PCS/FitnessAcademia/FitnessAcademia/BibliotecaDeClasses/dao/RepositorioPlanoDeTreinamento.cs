using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaDeClasses.conexao;
using BibliotecaDeClasses.erro;
using BibliotecaDeClasses.basica;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaDeClasses.dao
{
    public class RepositorioPlanoDeTreinamento : IRepositorioPlanoDeTreinamento
    {
        //private static IRepositorioPlanoDeTreinamento instancia;
        private Conexao con;

        public RepositorioPlanoDeTreinamento()
        {
            con = Conexao.getInstancia();
        }

        /*public static IRepositorioPlanoDeTreinamento obterInstancia()
        {
            if (instancia == null)
                instancia = new RepositorioPlanoDeTreinamento();
            return instancia;
        }*/

        private void incluirExercicios(SqlCommand sqlCmdEx, PlanoTreinamento pt)
        {
            sqlCmdEx.Parameters.Add("@plano", SqlDbType.Int);
            sqlCmdEx.Parameters.Add("@seq", SqlDbType.Int);
            sqlCmdEx.Parameters.Add("@codExercicio", SqlDbType.Int);
            sqlCmdEx.Parameters.Add("@series", SqlDbType.Int);
            sqlCmdEx.Parameters.Add("@numRepeticoes", SqlDbType.Int);
            sqlCmdEx.Parameters.Add("@peso", SqlDbType.Decimal);
            foreach (ExercicioDoPlano item in pt.Exercicios)
            {
                /*sqlCmdEx.Parameters.AddWithValue("@plano", pNumPlano.Value);
                sqlCmdEx.Parameters.AddWithValue("@seq", item.Seq);
                sqlCmdEx.Parameters.AddWithValue("@codExercicio", item.Exercicio.Codigo);
                sqlCmdEx.Parameters.AddWithValue("@series", item.Series);
                sqlCmdEx.Parameters.AddWithValue("@numRepeticoes", item.NumRepeticoes);
                sqlCmdEx.Parameters.AddWithValue("@peso", item.Peso);*/
                sqlCmdEx.Parameters["@plano"].Value = pt.Numplano;// pNumPlano.Value;
                sqlCmdEx.Parameters["@seq"].Value = item.Seq;
                sqlCmdEx.Parameters["@codExercicio"].Value = item.Exercicio.Codigo;
                sqlCmdEx.Parameters["@series"].Value = item.Series;
                sqlCmdEx.Parameters["@numRepeticoes"].Value = item.NumRepeticoes;
                sqlCmdEx.Parameters["@peso"].Value = item.Peso;
                sqlCmdEx.ExecuteNonQuery();
            }
        }

        public void incluir(PlanoTreinamento pt)
        {
            string transName = "InsTrans_Plano";
            //string sqlPlano = "insert into PlanoTreinamento(codCli, data, codObjetivo) values(@codCli, @data, @codObjetivo)";
            string sqlExercicio = "insert into ExercicioDoPlano(numPlano, seq, codExercicio, series, numRepeticoes, peso)"
                + " values(@plano, @seq, @codExercicio, @series, @numRepeticoes, @peso)";
            //string sqlSelect = "select numPlano from PlanoTreinamento where 
            string sqlProcAddPlano = "AddPlanoTreinamento";
            SqlTransaction trans;

            try
            {
                con.abrir();
                trans = con.iniciarTransacao(transName);
                SqlCommand sqlCmd = new SqlCommand(sqlProcAddPlano, con.sqlConnection, trans);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pNumPlano = sqlCmd.Parameters.Add("@pNumPlano", SqlDbType.Int);
                pNumPlano.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.AddWithValue("@pCodCli", pt.ClienteDoPlano.Codigo);
                sqlCmd.Parameters.AddWithValue("@pData", pt.Data);
                sqlCmd.Parameters.AddWithValue("@pCodObjetivo", pt.ObjetivoDoPlano.Codigo);
                sqlCmd.ExecuteNonQuery();
                SqlCommand sqlCmdEx = new SqlCommand(sqlExercicio, con.sqlConnection, trans);
                pt.Numplano = Convert.ToInt32(pNumPlano.Value);
                incluirExercicios(sqlCmdEx, pt);
                con.concluirTransacao(transName);
                sqlCmdEx.Dispose();
                sqlCmd.Dispose();
            }
            catch (ErroConexao ex)
            {
                con.reverterTransacao(transName);
                throw new ErroConexao("Erro de conexão: " + ex.Message);
            }
            catch (SqlException ex)
            {
                con.reverterTransacao(transName);
                throw new ErroPesquisar("Erro ao tentar incluir exerício: " + ex.Message);
            }
            finally
            {
                con.fechar();
            }
        }

        public void excluir(PlanoTreinamento pt)
        {
            //código
        }

        public void alterar(PlanoTreinamento pt)
        {
            string transName = "UpdtTrans_Plano";
            string sql = "update PlanoTreinamento set data = @pData, codCli = @pCodCli, codObjetivo = @pCodObjetivo"
                    + " where NumPlano = @pNumPlano";
            string sqlDelExercicios = "delete from ExercicioDoPlano where numPlano = @plano";
            string sqlInsExercicio = "insert into ExercicioDoPlano(numPlano, seq, codExercicio, series, numRepeticoes, peso)"
                + " values(@plano, @seq, @codExercicio, @series, @numRepeticoes, @peso)";
            SqlTransaction transacao;
            try
            {
                con.abrir();
                transacao = con.iniciarTransacao(transName);
                SqlCommand sqlCmd = new SqlCommand(sql, con.sqlConnection, transacao);
                sqlCmd.Parameters.AddWithValue("@pNumPlano", pt.Numplano);
                sqlCmd.Parameters.AddWithValue("@pData", pt.Data);
                sqlCmd.Parameters.AddWithValue("@pCodCli", pt.ClienteDoPlano.Codigo);
                sqlCmd.Parameters.AddWithValue("@pCodObjetivo", pt.ObjetivoDoPlano.Codigo);
                sqlCmd.ExecuteNonQuery();
                SqlCommand sqlDelCmd = new SqlCommand(sqlDelExercicios, con.sqlConnection, transacao);
                sqlDelCmd.Parameters.AddWithValue("@plano", pt.Numplano);
                sqlDelCmd.ExecuteNonQuery();
                SqlCommand sqlInsCmd = new SqlCommand(sqlInsExercicio, con.sqlConnection, transacao);
                incluirExercicios(sqlInsCmd, pt);

                con.concluirTransacao(transName);
            }
            catch (ErroConexao ec)
            {
                con.reverterTransacao(transName);
                throw new ErroConexao("Erro de conexão: " + ec.Message);
            }
            catch (Exception e)
            {
                con.reverterTransacao(transName);
                throw new ErroAlteracao("AlterarError: " + e.Message);
            }
            finally
            {
                con.fechar();
            }
        }

        public List<PlanoTreinamento> consultar(PlanoTreinamento pt, DateTime dataFinal)
        {
            return consultar(pt, dataFinal, PlanoTreinamento.TO_STRING_DEFAULT);
        }

        //A data do objeto PlanoTreinamento será usada na consulta como uma data inicial de um período se o parâmetro dataFinal não for NULL
        public List<PlanoTreinamento> consultar(PlanoTreinamento pt, DateTime dataFinal, int toStringBehavior)
        {
            List<PlanoTreinamento> lista = new List<PlanoTreinamento>();
            //bool existeParametro = false;
            string sql = "select * from PlanoTreinamento where ((data >= @dataInicial) and (data <= @dataFinal))";
            string sqlExercicios = "select * from exercicioDoPlano where numPlano = @pNumPlano";
            //string transName = "sqlSelect_Plano";
            ///SqlTransaction transacao;
            IRepositorioCliente rpC = new RepositorioCliente();
            IRepositorioExercicio rpE = new RepositorioExercicio();
            IRepositorioObjetivo rpO = new RepositorioObjetivo();
            try
            {
                if (pt.ClienteDoPlano != null)
                    if (pt.ClienteDoPlano.Codigo > 0)
                        sql += " and codCli = " + pt.ClienteDoPlano.Codigo.ToString();
                if (pt.ObjetivoDoPlano != null)
                    if (pt.ObjetivoDoPlano.Codigo > 0)
                        sql += " and codObjetivo = " + pt.ObjetivoDoPlano.Codigo.ToString();
                con.abrir();
                //transacao = con.iniciarTransacao(transName);
                SqlCommand sqlCmdPlano = new SqlCommand(sql, con.sqlConnection);//, transacao);
                sqlCmdPlano.Parameters.AddWithValue("@dataInicial", pt.Data);
                sqlCmdPlano.Parameters.AddWithValue("@dataFinal", dataFinal);
                SqlDataReader readPlano = sqlCmdPlano.ExecuteReader();
                while (readPlano.Read())
                {
                    PlanoTreinamento plano = new PlanoTreinamento(Util.GetIntRead(readPlano,"numPlano"),
                        readPlano.GetDateTime(readPlano.GetOrdinal("data")), rpO.pegar(Util.GetIntRead(readPlano,"codObjetivo")),
                        rpC.pegar(Util.GetIntRead(readPlano,"codCli")));

                    SqlCommand sqlCmdExer = new SqlCommand(sqlExercicios, con.sqlConnection);//, transacao);
                    sqlCmdExer.Parameters.AddWithValue("@pNumPlano", plano.Numplano);
                    SqlDataReader sdrExercicios = sqlCmdExer.ExecuteReader();
                    while (sdrExercicios.Read())
                    {
                        ExercicioDoPlano ep = new ExercicioDoPlano();
                        ep.NumPlano = Util.GetIntRead(sdrExercicios, "numPlano");
                        ep.Seq = Util.GetIntRead(sdrExercicios,"seq");
                        ep.Exercicio = rpE.pegar(sdrExercicios.GetInt32(sdrExercicios.GetOrdinal("codExercicio")));
                        ep.Series = Util.GetIntRead(sdrExercicios, "series");
                        ep.NumRepeticoes = Util.GetIntRead(sdrExercicios, "numRepeticoes");
                        ep.Peso = Util.GetDoubleRead(sdrExercicios, "peso");
                        plano.Exercicios.Add(ep);
                    }
                    sdrExercicios.Close();
                    sqlCmdExer.Dispose();
                    plano.ToStringBehavior = toStringBehavior;
                    lista.Add(plano);
                }
                return lista;
            }
            catch (ErroConexao ec)
            {
                throw new ErroConexao("Erro de conexão: " + ec.Message);
            }
            catch (SqlException es)
            {
                throw new ErroPesquisar("Erro ao tentar consultar: " + es.Message);
            }
            catch (Exception e)
            {
                throw new ErroPesquisar("Erro ao tentar consultar: " + e.Message);
            }
            finally
            {
                con.fechar();
            }
        }
    }
}
