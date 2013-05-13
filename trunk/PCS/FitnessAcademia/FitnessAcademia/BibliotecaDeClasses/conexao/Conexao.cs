using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BibliotecaDeClasses.erro;

namespace BibliotecaDeClasses.conexao
{
    public class Conexao
    {
        private static Conexao instancia;
        private static int count;
        public SqlConnection sqlConnection;
        //http://www.connectionstrings.com/
        private string sqlSrvConnectionString = "Data Source=localhost;Initial Catalog=FitnessAcademia;UId=pcsmelo;Password=melo;";

        private Dictionary<string, SqlTransaction> transacoes;

        private Conexao()
        {
            transacoes = new Dictionary<string,SqlTransaction>();
            count = 0;
        }

        public static Conexao getInstancia()
        {
            if (instancia == null)
                instancia = new Conexao();
            return instancia;
        }

        public void abrir()
        {
            try
            {
                this.sqlConnection = new SqlConnection(sqlSrvConnectionString);
                this.sqlConnection.Open();
                count++;
            }
            catch (Exception e)
            {
                throw new ErroConexao("Erro de conexão SQL: " + e.Message, e);
            }
        }

        public void fechar()
        {
            count--;
            if (count <= 0)
            {
                this.sqlConnection.Close();
                this.sqlConnection.Dispose();
            }
        }

        public SqlTransaction iniciarTransacao(string nomeDaTransacao)
        {
            SqlTransaction transacao = sqlConnection.BeginTransaction(nomeDaTransacao);
            transacoes[nomeDaTransacao] = transacao;
            return transacao;
        }

        public void concluirTransacao(string nome)
        {
            transacoes[nome].Commit();
        }

        public void reverterTransacao(string nome)
        {
            transacoes[nome].Rollback(nome);
        }
    }
}
