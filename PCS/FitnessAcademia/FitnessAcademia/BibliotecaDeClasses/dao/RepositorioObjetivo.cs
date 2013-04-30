using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BibliotecaDeClasses.conexao;
using BibliotecaDeClasses.erro;
using BibliotecaDeClasses.basica;

namespace BibliotecaDeClasses.dao
{
    public class RepositorioObjetivo:IRepositorioObjetivo
    {
        private static RepositorioObjetivo instancia;
        private Conexao con;

        private RepositorioObjetivo()
        {
            con = Conexao.getInstancia();
        }

        public static RepositorioObjetivo obterInstancia()
        {
            if (instancia == null)
                instancia = new RepositorioObjetivo();
            return instancia;
        }

        public void incluir(Objetivo o)
        {
            // digitar código
        }

        public void alterar(Objetivo o)
        {
            // digitar código
        }

        public void excluir(Objetivo o)
        {
            // digitar código
        }

        public List<Objetivo> consultar(Objetivo o)
        {
            List<Objetivo> lst = new List<Objetivo>();
            try
            {
                con.abrir();
                SqlCommand sql = new SqlCommand("select * from objetivo", con.sqlConnection);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    lst.Add(new Objetivo(reader.GetInt32(reader.GetOrdinal("codigo")),
                        reader.GetString(reader.GetOrdinal("descricao"))));
                }
                reader.Close();
                sql.Dispose();
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
    }
}
