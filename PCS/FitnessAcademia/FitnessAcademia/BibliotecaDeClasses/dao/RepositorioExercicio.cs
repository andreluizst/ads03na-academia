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

        private RepositorioExercicio()
        {
            con = Conexao.getInstancia();
        }

        public IRepositorioExercicio obterInstancia()
        {
            if (instancia == null)
                instancia = new RepositorioExercicio();
            return instancia;
        }


        public void incluir(Exercicio e)
        {
            //entrar com código
        }

        public void alterar(Exercicio e)
        {
            //entrar com código
        }

        public void excluir(Exercicio e)
        {
            //entrar com código
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
                throw new ErroConexao("A operação de consulta não está disponível no momento: " + ex.Message);
            }
            catch (SqlException ex)
            {
                throw new ErroPesquisar("Erro ao consultar exercício(s): " + ex.Message);
            }
            return lista;
        }

    }
}
