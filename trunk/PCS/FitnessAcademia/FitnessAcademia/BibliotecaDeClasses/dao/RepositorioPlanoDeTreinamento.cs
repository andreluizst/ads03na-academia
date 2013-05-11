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
        private static IRepositorioPlanoDeTreinamento instancia;
        private Conexao con;

        private RepositorioPlanoDeTreinamento()
        {
            con = Conexao.getInstancia();
        }

        public static IRepositorioPlanoDeTreinamento obterInstancia()
        {
            if (instancia == null)
                instancia = new RepositorioPlanoDeTreinamento();
            return instancia;
        }

        public void incluir(PlanoTreinamento pt)
        {
            string transName = "InsTrans_Plano";
            //string sqlPlano = "insert into PlanoTreinamento(codCli, data, codObjetivo) values(@codCli, @data, @codObjetivo)";
            string sqlExercicio = "insert into ExercicioDoPlano(numPlano, seq, codExercicio, series, numRepeticoes, peso)"
                + " values(@numPlano, @seq, @codExercicio, @series, @numRepeticoes, @peso)";
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
                
                sqlCmd.Parameters.AddWithValue("@codCli", pt.ClienteDoPlano.Codigo);
                sqlCmd.Parameters.AddWithValue("@data", pt.Data);
                sqlCmd.Parameters.AddWithValue("@codObjetivo", pt.ObjetivoDoPlano.Codigo);
                
                sqlCmd.ExecuteNonQuery();
                SqlCommand sqlCmdEx = new SqlCommand(sqlExercicio, con.sqlConnection, trans);
                foreach (ExercicioDoPlano item in pt.Exercicios)
                {
                    sqlCmdEx.Parameters.AddWithValue("@numPlano", pNumPlano.Value);

                    sqlCmdEx.Parameters.AddWithValue("@seq", item.Seq);
                    sqlCmdEx.Parameters.AddWithValue("@codExercicio", item.Exercicio.Codigo);
                    sqlCmdEx.Parameters.AddWithValue("@series", item.Series);
                    sqlCmdEx.Parameters.AddWithValue("@numRepeticoes", item.NumRepeticoes);
                    sqlCmdEx.Parameters.AddWithValue("@peso", item.Peso);
                    sqlCmdEx.ExecuteNonQuery();
                }
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

        public void alterar(PlanoTreinamento pt)
        {
            //código
        }

        public void excluir(PlanoTreinamento pt)
        {
            //código
        }

        public List<PlanoTreinamento> consultar(PlanoTreinamento pt)
        {
            return consultar(pt, PlanoTreinamento.TO_STRING_DEFAULT);
        }

        public List<PlanoTreinamento> consultar(PlanoTreinamento pt, int toStringBehavior)
        {
            List<PlanoTreinamento> lista = new List<PlanoTreinamento>();
            //código
            return lista;
        }
    }
}
