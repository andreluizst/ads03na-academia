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
        private Conexao con;

        public RepositorioPlanoDeTreinamento()
        {
            con = Conexao.getInstancia();
        }

        private void incluirExercicios(SqlCommand sqlCmdEx, PlanoTreinamento pt)
        {
            sqlCmdEx.Parameters.Add("@plano", SqlDbType.Int);
            sqlCmdEx.Parameters.Add("@seq", SqlDbType.Int);
            sqlCmdEx.Parameters.Add("@codExercicio", SqlDbType.Int);
            sqlCmdEx.Parameters.Add("@series", SqlDbType.Int);
            sqlCmdEx.Parameters.Add("@numRepeticoes", SqlDbType.Int);
            sqlCmdEx.Parameters.Add("@peso", SqlDbType.Real);
            foreach (ExercicioDoPlano item in pt.Exercicios)
            {
                sqlCmdEx.Parameters["@plano"].Value = pt.Numplano;// pNumPlano.Value;
                sqlCmdEx.Parameters["@seq"].Value = item.Seq;
                sqlCmdEx.Parameters["@codExercicio"].Value = item.Exercicio.Codigo;
                sqlCmdEx.Parameters["@series"].Value = item.Series;
                sqlCmdEx.Parameters["@numRepeticoes"].Value = item.NumRepeticoes;
                sqlCmdEx.Parameters["@peso"].Value = item.Peso;// Convert.ToDecimal(item.Peso);
                sqlCmdEx.ExecuteNonQuery();
            }
        }

        public void incluir(PlanoTreinamento pt)
        {
            string transName = "InsTrans_Plano";
            string sqlExercicio = "insert into ExercicioDoPlano(numPlano, seq, codExercicio, series, numRepeticoes, peso)"
                + " values(@plano, @seq, @codExercicio, @series, @numRepeticoes, @peso)";
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
                throw new ErroInclusao(ex.Message);
            }
            finally
            {
                con.fechar();
            }
        }

        public void excluir(PlanoTreinamento pt)
        {
            string transName = "DelTrans_Plano";
            string sqlDelPlano = "delete from PlanoTreinamento where numPlano = @pNumPlano";
            string sqlExercicio = "delete from ExercicioDoPlano where numPlano = @plano";
            SqlTransaction transacao;

            try
            {
                con.abrir();
                transacao = con.iniciarTransacao(transName);
                SqlCommand sqlCmdEx = new SqlCommand(sqlExercicio, con.sqlConnection, transacao);
                sqlCmdEx.Parameters.AddWithValue("@plano", pt.Numplano);
                sqlCmdEx.ExecuteNonQuery();
                SqlCommand sqlCmd = new SqlCommand(sqlDelPlano, con.sqlConnection, transacao);
                sqlCmd.Parameters.AddWithValue("@pNumPlano", pt.Numplano);
                sqlCmd.ExecuteNonQuery();
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
                throw new ErroExclusao(ex.Message);
            }
            finally
            {
                con.fechar();
            }
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
                throw new ErroAlteracao(e.Message);
            }
            finally
            {
                con.fechar();
            }
        }

        public PlanoTreinamento pegar(int numero)
        {
            return pegar(numero, PlanoTreinamento.TO_STRING_DEFAULT);
        }

        public PlanoTreinamento pegar(int numero, int toStringBehavior)
        {
            PlanoTreinamento obj = new PlanoTreinamento();
            obj.Numplano = numero;
            List<PlanoTreinamento> lista = consultar(obj, null ,toStringBehavior);
            if (lista.Count > 0)
                return lista[0];
            return null;
        }

        public List<PlanoTreinamento> consultar(PlanoTreinamento pt, DateTime? dataFinal)
        {
            return consultar(pt, dataFinal, PlanoTreinamento.TO_STRING_DEFAULT);
        }

        //A data do objeto PlanoTreinamento será usada na consulta como uma data inicial de um período se o parâmetro dataFinal não for NULL
        public List<PlanoTreinamento> consultar(PlanoTreinamento pt, DateTime? dataFinal, int toStringBehavior)
        {
            List<PlanoTreinamento> lista = new List<PlanoTreinamento>();
            bool existeParametro = false;
            //bool numPlanoExiste = false;
            //bool codCliExiste = false;
            //bool codObjetivoExiste = false;
            bool dataExiste = false;
            string sql = "select * from PlanoTreinamento";
            string sqlExercicios = "select * from exercicioDoPlano where numPlano = @pNumPlano";
            //string transName = "sqlSelect_Plano";
            ///SqlTransaction transacao;
            IRepositorioCliente rpC = new RepositorioCliente();
            IRepositorioExercicio rpE = new RepositorioExercicio();
            IRepositorioObjetivo rpO = new RepositorioObjetivo();
            try
            {
                if (pt.Numplano > 0)
                {
                    sql += " where numPlano = " + pt.Numplano.ToString();
                    existeParametro = true;
                    //numPlanoExiste = true;
                }
                if (pt.ClienteDoPlano != null)
                {
                    if (pt.ClienteDoPlano.Codigo > 0)
                    {
                        if (existeParametro)
                            sql += " and codCli = ";
                        else
                            sql += " where codCli = ";
                        sql += pt.ClienteDoPlano.Codigo.ToString();
                        existeParametro = true;
                        //codCliExiste = true;
                    }
                }
                if (pt.ObjetivoDoPlano != null)
                {
                    if (pt.ObjetivoDoPlano.Codigo > 0)
                    {
                        if (existeParametro)
                            sql += " and codObjetivo = ";
                        else
                            sql += " where codObjetivo = ";
                        sql += pt.ObjetivoDoPlano.Codigo.ToString();
                        existeParametro = true;
                        //codObjetivoExiste = true;
                    }
                }
                
                if ((pt.Data != null) && (dataFinal != null))
                {
                    if (existeParametro)
                        sql += " and ((data >= @dataInicial) and (data <= @dataFinal))";
                    else
                        sql += " where ((data >= @dataInicial) and (data <= @dataFinal))";
                    existeParametro = true;
                    dataExiste = true;
                }
                con.abrir();
                //transacao = con.iniciarTransacao(transName);
                SqlCommand sqlCmdPlano = new SqlCommand(sql, con.sqlConnection);//, transacao);
                if (dataExiste)
                {
                    /* Se usar o método AddWithValue(parametro, valor) onde o valor for uma DateTime
                    *  a consulta não retorna registro, pois a data fica incorreta. Por esse motivo deve-se usar
                    *  os parametros de data conforme abaixo.
                    */
                    sqlCmdPlano.Parameters.Add("@dataInicial", SqlDbType.Date);
                    sqlCmdPlano.Parameters.Add("@dataFinal", SqlDbType.Date);
                    sqlCmdPlano.Parameters["@dataInicial"].Value = pt.Data;
                    sqlCmdPlano.Parameters["@dataFinal"].Value = dataFinal;
                }
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
                        ep.Peso = Convert.ToDouble(Util.GetRealRead(sdrExercicios, "peso"));
                        plano.Exercicios.Add(ep);
                    }
                    sdrExercicios.Close();
                    sqlCmdExer.Dispose();
                    plano.setToStringBehavior(toStringBehavior);
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
                throw new ErroPesquisar(es.Message);
            }
            catch (Exception e)
            {
                throw new ErroPesquisar(e.Message);
            }
            finally
            {
                con.fechar();
            }
        }
    }
}
