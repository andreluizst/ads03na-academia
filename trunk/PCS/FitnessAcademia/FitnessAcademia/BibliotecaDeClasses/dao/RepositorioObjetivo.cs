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
        private Conexao con;

        public RepositorioObjetivo()
        {
            con = Conexao.getInstancia();
        }

        public void incluir(Objetivo o)
        {
            string transName = "InsTrans_Objetivo";
            string sql = "insert into objetivo(descricao) values(@descricao)";
            try
            {
                con.abrir();
                SqlCommand sqlCmd = new SqlCommand(sql, con.sqlConnection, con.iniciarTransacao(transName));
                sqlCmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                sqlCmd.Parameters["@descricao"].Value = o.Descricao;
                sqlCmd.ExecuteNonQuery();
                con.concluirTransacao(transName);
                sqlCmd.Dispose();
            }
            catch (ErroConexao e)
            {
                con.reverterTransacao(transName);
                throw new ErroConexao("Erro de conexão: " + e.Message);
            }
            catch (SqlException e)
            {
                con.reverterTransacao(transName);
                throw new ErroInclusao(e.Message);
            }
            finally
            {
                con.fechar();
            }
        }


        public void alterar(Objetivo o)
        {
            string transName = "updtTrans_Objetivo";
            string sql = "update objetivo set descricao = @descricao where codigo = @codigo";
            try
            {
                con.abrir();
                SqlCommand sqlCmd = new SqlCommand(sql, con.sqlConnection, con.iniciarTransacao(transName));
                sqlCmd.Parameters.Add("@codigo", SqlDbType.Int);
                sqlCmd.Parameters["@codigo"].Value = o.Codigo;
                sqlCmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                sqlCmd.Parameters["@descricao"].Value = o.Descricao;
                sqlCmd.ExecuteNonQuery();
                con.concluirTransacao(transName);
                sqlCmd.Dispose();
            }
            catch (ErroConexao e)
            {
                con.reverterTransacao(transName);
                throw new ErroConexao("A operação de alteração não está disponível no momento: " + e.Message);
            }
            catch (SqlException e)
            {
                con.reverterTransacao(transName);
                throw new ErroAlteracao(e.Message);
            }
            finally
            {
                con.fechar();
            }
        }

        public void excluir(Objetivo o)
        {
            string transName = "delTrans_Objetivo";
            string sql = "delete from objetivo where codigo = @codigo";
            try
            {
                con.abrir();
                SqlCommand sqlCmd = new SqlCommand(sql, con.sqlConnection, con.iniciarTransacao(transName));
                sqlCmd.Parameters.Add("@codigo", SqlDbType.Int);
                sqlCmd.Parameters["@codigo"].Value = o.Codigo;
                sqlCmd.ExecuteNonQuery();
                con.concluirTransacao(transName);
                sqlCmd.Dispose();
            }
            catch (ErroConexao e)
            {
                con.reverterTransacao(transName);
                throw new ErroConexao("A operação de exclusão não está disponível no momento: " + e.Message);
            }
            catch (SqlException e)
            {
                string msg = e.Message;
                con.reverterTransacao(transName);
                if ((msg.IndexOf("DELETE") >= 0) &&  (msg.IndexOf("PlanoTreinamento_FKcodObjetivo") >= 0))
                    msg = "Não é possível excluir o objetivo selecionado porque o mesmo"
                        + " já está sendo utilizado em um ou mais Plano(s) de Treinamento!";
                throw new ErroExclusao(msg);
            }
            finally
            {
                con.fechar();
            }
        }

        public Objetivo pegar(int codigo)
        {
            return pegar(codigo, Objetivo.TO_STRING_DEFAULT);
        }

        public Objetivo pegar(int codigo, int toStringBehavior)
        {
            Objetivo obj = new Objetivo();
            obj.Codigo = codigo;
            List<Objetivo> lista = consultar(obj, toStringBehavior);
            if (lista.Count > 0)
                return lista[0];
            return null;
        }

        public List<Objetivo> consultar(Objetivo o, int toStringBehavior)
        {
            List<Objetivo> lst = new List<Objetivo>();
            string sql = "select * from Objetivo";
            bool existeParametro = false;
            bool existeParametroCodigo = false;
            bool existeParametroDescricao = false;
            try
            {
                con.abrir();
                if (o.Codigo > 0)
                {
                    sql += " where codigo = @codigo";
                    existeParametro = true;
                    existeParametroCodigo = true;
                }
                if (o.Descricao != null)
                {
                    if (o.Descricao.Length > 0)
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
                }
                sql += " order by descricao";
                SqlCommand sqlCmd = new SqlCommand(sql, con.sqlConnection);
                if (existeParametroCodigo)
                {
                    sqlCmd.Parameters.Add("@codigo", SqlDbType.Int);
                    sqlCmd.Parameters["@codigo"].Value = o.Codigo;
                }
                if (existeParametroDescricao)
                {
                    sqlCmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                    sqlCmd.Parameters["@descricao"].Value = "%"+o.Descricao+"%";
                }
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    lst.Add(new Objetivo(Util.GetIntRead(reader, "codigo"), Util.GetStringRead(reader, "descricao")));
                }
                reader.Close();
                sqlCmd.Dispose();
            }
            catch (ErroConexao e)
            {
                throw new ErroConexao("Erro de conexão: " + e.Message);
            }
            catch (SqlException e)
            {
                throw new ErroPesquisar(e.Message);
            }
            catch (Exception e)
            {
                throw new ErroPesquisar(e.Message);
            }
            finally
            {
                con.fechar();
            }
            return lst;
        }

        public List<Objetivo> consultar(Objetivo o)
        {
            return consultar(o, Objetivo.TO_STRING_DEFAULT);
        }

    }
}
