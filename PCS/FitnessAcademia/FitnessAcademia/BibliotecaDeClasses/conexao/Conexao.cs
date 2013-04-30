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
        public SqlConnection sqlConnection;
        //http://www.connectionstrings.com/
        private string sqlSrvConnectionString = "Data Source=localhost;Initial Catalog=FitnessAcademia;UId=pcsmelo;Password=melo;";

        private Conexao()
        {
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
            }
            catch (Exception e)
            {
                throw new ErroConexao("Erro de conexão SQL: " + e.Message, e);
            }
        }

        public void fechar()
        {
            this.sqlConnection.Close();
            this.sqlConnection.Dispose();
        }
    }
}
