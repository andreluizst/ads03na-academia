using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BibliotecaDeClasses.conexao;
using BibliotecaDeClasses.erro;
using BibliotecaDeClasses.basica;
using System.Data;

namespace BibliotecaDeClasses.dao
{
    public class RepositorioObjetivo : IRepositorioObjetivo
    {
        private static IRepositorioObjetivo instancia;
        private Conexao con;

        private RepositorioObjetivo()
        {
            con = Conexao.getInstancia();
        }

        public static IRepositorioObjetivo obterInstancia()
        {
            if (instancia == null)
                instancia = new RepositorioObjetivo();
            return instancia;
        }

        public void incluir(Objetivo o)
        {
            string transName = "InsTrans";
            try
            {
                con.abrir();
                SqlCommand sql = new SqlCommand("insert into objetivo(descricao) values(@descricao)",
                    con.sqlConnection, con.iniciarTransacao(transName));
                sql.Parameters.Add("@descricao", SqlDbType.VarChar);
                sql.Parameters["@descricao"].Value = o.Descricao;
                sql.ExecuteNonQuery();
                con.concluirTransacao(transName);
            }
            catch (ErroConexao e)
            {
                con.reverterTransacao(transName);
                throw new ErroConexao("A operação de inculsão não está disponível no momento: " + e.Message);
            }
            catch (SqlException e)
            {
                con.reverterTransacao(transName);
                throw new ErroPesquisar("Erro ao tentar incluir objetivo: " + e.Message);
            }
            finally
            {
                con.fechar();
            }
        }


        public void alterar(Objetivo o)
        {
            string transName = "updtTrans";
            try
            {
                con.abrir();
                SqlCommand sql = new SqlCommand(
                    "update objetivo set descricao = @descricao where codigo = @codigo",
                    con.sqlConnection, con.iniciarTransacao(transName));
                sql.Parameters.Add("@codigo", SqlDbType.Int);
                sql.Parameters["@codigo"].Value = o.Codigo;
                sql.Parameters.Add("@descricao", SqlDbType.VarChar);
                sql.Parameters["@descricao"].Value = o.Descricao;
                sql.ExecuteNonQuery();
                con.concluirTransacao(transName);
            }
            catch (ErroConexao e)
            {
                con.reverterTransacao(transName);
                throw new ErroConexao("A operação de alteração não está disponível no momento: " + e.Message);
            }
            catch (SqlException e)
            {
                con.reverterTransacao(transName);
                throw new ErroPesquisar("Erro ao tentar alterar objetivo: " + e.Message);
            }
            finally
            {
                con.fechar();
            }
        }

        public void excluir(Objetivo o)
        {
            string transName = "delTrans";
            try
            {
                con.abrir();
                SqlCommand sql = new SqlCommand(
                    "delete from objetivo where codigo = @codigo",
                    con.sqlConnection, con.iniciarTransacao(transName));
                sql.Parameters.Add("@codigo", SqlDbType.Int);
                sql.Parameters["@codigo"].Value = o.Codigo;
                sql.ExecuteNonQuery();
                con.concluirTransacao(transName);
            }
            catch (ErroConexao e)
            {
                con.reverterTransacao(transName);
                throw new ErroConexao("A operação de exclusão não está disponível no momento: " + e.Message);
            }
            catch (SqlException e)
            {
                con.reverterTransacao(transName);
                throw new ErroPesquisar("Erro ao tentar excluir objetivo: " + e.Message);
            }
            finally
            {
                con.fechar();
            }
        }

        public List<Objetivo> consultar(Objetivo o, int toStringBehavior)
        {
            List<Objetivo> lst = new List<Objetivo>();
            string sql = "select * from Objetivo";
            bool existeParametro = false;
            try
            {
                con.abrir();
                if (o.Codigo > 0)
                {
                    sql += " where codigo = " + o.Codigo.ToString();
                    existeParametro = true;
                }
                if (o.Descricao != null)
                {
                    if (existeParametro)
                    {
                        sql += " and ";
                    }
                    else
                    {
                        sql += " where ";
                    }
                    sql += " descricao like '" + o.Descricao + "'";
                }
                SqlCommand sqlCmd = new SqlCommand(sql, con.sqlConnection);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    lst.Add(new Objetivo(reader.GetInt32(reader.GetOrdinal("codigo")),
                        reader.GetString(reader.GetOrdinal("descricao")), toStringBehavior));
                }
                reader.Close();
                sqlCmd.Dispose();
                con.fechar();
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("A operação de consulta não está disponível no momento!");
            }
            catch (SqlException e)
            {
                throw new ErroPesquisar("Erro ao consultar objetivo(s): " + e.Message);
            }
            return lst;
        }

        public List<Objetivo> consultar(Objetivo o)
        {
            return consultar(o, Objetivo.TO_STRING_DEFAULT);
        }

    }
}
