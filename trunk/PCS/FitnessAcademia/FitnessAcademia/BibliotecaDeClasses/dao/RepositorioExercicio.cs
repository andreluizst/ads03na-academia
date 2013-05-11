using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaDeClasses.basica;
using BibliotecaDeClasses.conexao;
using BibliotecaDeClasses.erro;
using System.Data.SqlClient;

namespace BibliotecaDeClasses.dao
{
    public class RepositorioExercicio : IRepositorioExercicio
    {
        private static IRepositorioExercicio instancia;
        private Conexao con;

        public RepositorioExercicio()
        {
            con = Conexao.getInstancia();
        }

        public static IRepositorioExercicio obterInstancia()
        {
            if (instancia == null)
                instancia = new RepositorioExercicio();
            return instancia;
        }


        public void incluir(Exercicio e)
        {
            string transName = "InsTrans_Exercicio";
            string sql = "insert into Exercicio(descricao) values(@descricao)";
            try
            {
                con.abrir();
                SqlCommand sqlCmd = new SqlCommand(sql, con.sqlConnection, con.iniciarTransacao(transName));
                sqlCmd.Parameters.AddWithValue("@descricao", e.Descricao);
                sqlCmd.ExecuteNonQuery();
                con.concluirTransacao(transName);
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

        public void alterar(Exercicio e)
        {
            string transName = "updtTrans_Exercicio";
            string sql = "update Exercicio set descricao = @descricao where codigo = @codigo";
            try
            {
                con.abrir();
                SqlCommand sqlCmd = new SqlCommand(sql, con.sqlConnection, con.iniciarTransacao(transName));
                sqlCmd.Parameters.AddWithValue("@codigo", e.Codigo);
                sqlCmd.Parameters.AddWithValue("@descricao", e.Descricao);
                sqlCmd.ExecuteNonQuery();
                con.concluirTransacao(transName);
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
                throw new ErroPesquisar("Erro ao tentar alterar objetivo: " + ex.Message);
            }
            finally
            {
                con.fechar();
            }
        }

        public void excluir(Exercicio e)
        {
            string transName = "delTrans_Exercicio";
            string sql = "delete from Exercicio where codigo = @codigo";
            try
            {
                con.abrir();
                SqlCommand sqlCmd = new SqlCommand(sql, con.sqlConnection, con.iniciarTransacao(transName));
                sqlCmd.Parameters.AddWithValue("@codigo", e.Codigo);
                sqlCmd.ExecuteNonQuery();
                con.concluirTransacao(transName);
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
                throw new ErroPesquisar("Erro ao tentar excluir objetivo: " + ex.Message);
            }
            finally
            {
                con.fechar();
            }
        }

        public List<Exercicio> consultar(Exercicio e)
        {
            return consultar(e, Exercicio.TO_STRING_DEFAULT);
        }

        public List<Exercicio> consultar(Exercicio e, int toStringBehavior)
        {
            List<Exercicio> lista = new List<Exercicio>();
            string sql = "select * from Exercicio";
            bool existeParametro = false;
            try
            {
                con.abrir();
                if (e.Codigo > 0)
                {
                    sql += " where codigo = " + e.Codigo.ToString();
                    existeParametro = true;
                }
                if (e.Descricao != null)
                {
                    if (existeParametro)
                    {
                        sql += " and ";
                    }
                    else
                    {
                        sql += " where ";
                    }
                    sql += " descricao like '" + e.Descricao + "'";
                }
                SqlCommand sqlCmd = new SqlCommand(sql, con.sqlConnection);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Exercicio(reader.GetInt32(reader.GetOrdinal("codigo")),
                        reader.GetString(reader.GetOrdinal("descricao")), toStringBehavior));
                }
                reader.Close();
                sqlCmd.Dispose();
                con.fechar();
            }
            catch (ErroConexao ex)
            {
                throw new ErroConexao("Erro de conexão: " + ex.Message);
            }
            catch (SqlException ex)
            {
                throw new ErroPesquisar("Erro ao consultar exercício(s): " + ex.Message);
            }
            return lista;
        }

    }
}
