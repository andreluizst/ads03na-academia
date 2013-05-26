using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaDeClasses.basica;
using BibliotecaDeClasses.conexao;
using BibliotecaDeClasses.erro;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaDeClasses.dao
{
    public class RepositorioExercicio : IRepositorioExercicio
    {
        private Conexao con;

        public RepositorioExercicio()
        {
            con = Conexao.getInstancia();
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
                throw new ErroInclusao(ex.Message);
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
                throw new ErroAlteracao(ex.Message);
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
                string msg = ex.Message;
                con.reverterTransacao(transName);
                if ((msg.IndexOf("DELETE") >= 0) && (msg.IndexOf("FKcodExercicio") >= 0))
                    msg = "Não é possível excluir o exercício selecionado porque o mesmo"
                        + " já está sendo utilizado em um ou mais Plano(s) de Treinamento!";
                throw new ErroExclusao(msg);
            }
            finally
            {
                con.fechar();
            }
        }

        public Exercicio pegar(int codigo)
        {
            return pegar(codigo, Exercicio.TO_STRING_DEFAULT);
        }

        public Exercicio pegar(int codigo, int toStringBehavior)
        {
            Exercicio obj = new Exercicio();
            obj.Codigo = codigo;
            List<Exercicio> lista = consultar(obj, toStringBehavior);
            if (lista.Count > 0)
                return lista[0];
            return null;
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
            bool existeParametroCodigo = false;
            bool existeParametroDescricao = false;
            try
            {
                con.abrir();
                if (e.Codigo > 0)
                {
                    sql += " where codigo = @codigo";
                    existeParametro = true;
                    existeParametroCodigo = true;
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
                    sql += " descricao like @descricao";
                    existeParametroDescricao = true;
                }
                sql += " order by descricao";
                SqlCommand sqlCmd = new SqlCommand(sql, con.sqlConnection);
                if (existeParametroCodigo)
                {
                    sqlCmd.Parameters.Add("@codigo", SqlDbType.Int);
                    sqlCmd.Parameters["@codigo"].Value = e.Codigo;
                }
                if (existeParametroDescricao)
                {
                    sqlCmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                    sqlCmd.Parameters["@descricao"].Value = "%" + e.Descricao + "%";
                }
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Exercicio(Util.GetIntRead(reader, "codigo"),
                        Util.GetStringRead(reader, "descricao"), toStringBehavior));
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
                throw new ErroPesquisar(ex.Message);
            }
            return lista;
        }

    }
}
