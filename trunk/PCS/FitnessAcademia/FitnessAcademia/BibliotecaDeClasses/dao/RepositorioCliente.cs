using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BibliotecaDeClasses.basica;
using BibliotecaDeClasses.erro;
using BibliotecaDeClasses.conexao;

namespace BibliotecaDeClasses.dao
{
    public class RepositorioCliente:IRepositorioCliente
    {
        private static RepositorioCliente instancia;
        private Conexao con;


        private RepositorioCliente()
        {
            con = Conexao.getInstancia();
        }

        public static RepositorioCliente obterInstancia()
        {
            if (instancia == null)
                instancia = new RepositorioCliente();
            return instancia;
        }

        public void incluir(Cliente c)
        {
            try
            {
                con.abrir();
                SqlCommand sql = new SqlCommand("insert into cliente(Nome, CPF, RG, DataNasc, "
                    + "Logradouro, NumLog, Complemento, Bairro, Cidade, UF, CEP, EstCivil, "
                    + " Sexo, Telefone, Celular, email, ValExameMedico) "
                    + " values(@nome, @cpf, @rg, @dataNasc, @Logradouro, @NumLog, @Complemento,"
                    + " @bairro, @cidade, @uf, @cep, @estCivil, @sexo, @tel, @cel, @email,"
                    + " @valExameMedico)");
            }
            catch (ErroConexao)
            {
                throw new ErroInclusao("A operação de inclusão não está disponível no momento!");
            }
        }

    }
}
