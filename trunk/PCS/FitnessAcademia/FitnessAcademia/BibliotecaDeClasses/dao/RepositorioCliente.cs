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
    public class RepositorioCliente : IRepositorioCliente
    {
        //private static IRepositorioCliente instancia;
        private Conexao con;


        public RepositorioCliente()
        {
            con = Conexao.getInstancia();
        }

        /*public static IRepositorioCliente obterInstancia()
        {
            if (instancia == null)
                instancia = new RepositorioCliente();
            return instancia;
        }*/

        public void incluir(Cliente c)
        {
            string transName = "InsTrans_Cliente";
            string sql = "insert into cliente(Nome, CPF, RG, DataNasc, "
                    + "Logradouro, NumLog, Complemento, Bairro, Cidade, UF, CEP, EstCivil, "
                    + " Sexo, Telefone, Celular, email, ValExameMedico) "
                    + " values(@nome, @cpf, @rg, @dataNasc, @Logradouro, @NumLog, @Complemento,"
                    + " @bairro, @cidade, @uf, @cep, @estCivil, @sexo, @tel, @cel, @email,"
                    + " @valExameMedico)";
            try
            {
                con.abrir();
                SqlCommand sqlCmd = new SqlCommand(sql, con.sqlConnection, con.iniciarTransacao(transName));
                sqlCmd.Parameters.AddWithValue("@nome", c.Nome);
                sqlCmd.Parameters.AddWithValue("@cpf", c.Cpf);
                sqlCmd.Parameters.AddWithValue("@rg", c.Rg);
                sqlCmd.Parameters.AddWithValue("@dataNasc", c.DataNasc);
                sqlCmd.Parameters.AddWithValue("@logradouro", c.Logradouro);
                sqlCmd.Parameters.AddWithValue("@numLog", c.NumLog);
                sqlCmd.Parameters.AddWithValue("@complemento", c.Complemento);
                sqlCmd.Parameters.AddWithValue("@bairro", c.Bairro);
                sqlCmd.Parameters.AddWithValue("@cidade", c.Cidade);
                sqlCmd.Parameters.AddWithValue("@uf", c.Uf);
                sqlCmd.Parameters.AddWithValue("@cep", c.Cep);
                sqlCmd.Parameters.AddWithValue("@estCivil", c.EstCivil);
                sqlCmd.Parameters.AddWithValue("@sexo", c.Sexo);
                sqlCmd.Parameters.AddWithValue("@tel", c.Telefone);
                sqlCmd.Parameters.AddWithValue("@cel", c.Celular);
                sqlCmd.Parameters.AddWithValue("@email", c.Email);
                sqlCmd.Parameters.AddWithValue("@valExameMedico", c.ValExameMedico);
                sqlCmd.ExecuteNonQuery();
                con.concluirTransacao(transName);
            }
            catch (ErroConexao e)
            {
                con.reverterTransacao(transName);
                throw new ErroInclusao("A operação de inclusão não está disponível no momento! Erro: " + e.Message);
            }
            catch (SqlException e)
            {
                con.reverterTransacao(transName);
                throw new ErroInclusao("Erro ao tentar incluir cliente: " + e.Message);
            }
            finally
            {
                con.fechar();
            }
        }

        public void alterar(Cliente c)
        {
            string transName = "UpdtTrans_Cliente";
            string sql = "UPDATE cliente SET Nome = @nome, CPF = @cpf,"
                    + " RG = @rg, DataNasc = @dataNasc, Logradouro = @logradouro, NumLog = @numLog,"
                    + " Complemento = @complemento, Bairro = @bairro, Cidade = @cidade, UF = @uf,"
                    + " CEP = @cep, EstCivil = @estCivil, Sexo = @sexo, Telefone = @tel,"
                    + " Celular = @cel, email = @email, ValExameMedico = @valExameMedico "
                    + " WHERE codigo = @codigo";
            try
            {
                con.abrir();
                SqlCommand sqlCmd = new SqlCommand(sql, con.sqlConnection, con.iniciarTransacao(transName));
                sqlCmd.Parameters.AddWithValue("@codigo", c.Codigo);
                sqlCmd.Parameters.AddWithValue("@nome", c.Nome);
                sqlCmd.Parameters.AddWithValue("@cpf", c.Cpf);
                sqlCmd.Parameters.AddWithValue("@rg", c.Rg);
                sqlCmd.Parameters.AddWithValue("@dataNasc", c.DataNasc);
                sqlCmd.Parameters.AddWithValue("@logradouro", c.Logradouro);
                sqlCmd.Parameters.AddWithValue("@numLog", c.NumLog);
                sqlCmd.Parameters.AddWithValue("@complemento", c.Complemento);
                sqlCmd.Parameters.AddWithValue("@bairro", c.Bairro);
                sqlCmd.Parameters.AddWithValue("@cidade", c.Cidade);
                sqlCmd.Parameters.AddWithValue("@uf", c.Uf);
                sqlCmd.Parameters.AddWithValue("@cep", c.Cep);
                sqlCmd.Parameters.AddWithValue("@estCivil", c.EstCivil);
                sqlCmd.Parameters.AddWithValue("@sexo", c.Sexo);
                sqlCmd.Parameters.AddWithValue("@tel", c.Telefone);
                sqlCmd.Parameters.AddWithValue("@cel", c.Celular);
                sqlCmd.Parameters.AddWithValue("@email", c.Email);
                sqlCmd.Parameters.AddWithValue("@valExameMedico", c.ValExameMedico);
                sqlCmd.ExecuteNonQuery();
                con.concluirTransacao(transName);
                sqlCmd.Dispose();
            }
            catch (ErroConexao e)
            {
                con.reverterTransacao(transName);
                throw new ErroInclusao("A operação de alteração não está disponível no momento! Erro: " + e.Message);
            }
            catch (SqlException e)
            {
                con.reverterTransacao(transName);
                throw new ErroInclusao("Erro ao tentar alterar cliente: " + e.Message);
            }
            finally
            {
                con.fechar();
            }
        }

        public void excluir(Cliente c)
        {
            string transName = "DelTrans_Cliente";
            string sql = "delete from cliente where codigo = @codigo";
            try
            {
                con.abrir();
                SqlCommand sqlCmd = new SqlCommand(sql, con.sqlConnection, con.iniciarTransacao(transName));
                sqlCmd.Parameters.AddWithValue("@codigo", c.Codigo);
                sqlCmd.ExecuteNonQuery();
                con.concluirTransacao(transName);
            }
            catch (ErroConexao e)
            {
                con.reverterTransacao(transName);
                throw new ErroInclusao("A operação de exclusão não está disponível no momento: " + e.Message);
            }
            catch (SqlException e)
            {
                con.reverterTransacao(transName);
                throw new ErroInclusao("Erro ao tentar excluir cliente: " + e.Message);
            }
            finally
            {
                con.fechar();
            }
        }

        public Cliente pegar(int codigo)
        {
            return pegar(codigo, Cliente.TO_STRING_DEFAULT);
        }

        public Cliente pegar(int codigo, int toStringBehavior)
        {
            Cliente c = new Cliente();
            c.Codigo = codigo;
            List<Cliente> lista = consultar(c, toStringBehavior);
            if (lista.Count > 0)
                return lista[0];
            return null;
        }

        public List<Cliente> consultar(Cliente c)
        {
            return consultar(c, Cliente.TO_STRING_DEFAULT);
        }

        public List<Cliente> consultar(Cliente c, int toStringBehavior)
        {
            List<Cliente> lista = new List<Cliente>();
            string sql = "select * from Cliente where nome like @nome";
            //bool existeParametro = false;
            try
            {
                con.abrir();

                if (c.Codigo > 0)
                {
                    sql += " and codigo = " + c.Codigo.ToString();
                }
                if (c.Cpf != null)
                {
                    sql += " and cpf like '%" + c.Cpf + "%'";
                }
                if (c.Nome == null)
                    c.Nome = "%";
                SqlCommand sqlCmd = new SqlCommand(sql, con.sqlConnection);
                sqlCmd.Parameters.AddWithValue("@nome", c.Nome);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (toStringBehavior == Cliente.TO_STRING_NAME)
                {
                    while (reader.Read())
                    {
                        lista.Add(new Cliente(reader.GetInt32(reader.GetOrdinal("codigo")),
                            reader.GetString(reader.GetOrdinal("nome")), toStringBehavior));
                    }
                }
                else
                {
                    while (reader.Read())
                    {
                        Cliente cli = new Cliente(reader.GetInt32(reader.GetOrdinal("Codigo")),
                            reader.GetString(reader.GetOrdinal("Nome")));
                        cli.Cpf = reader.GetString(reader.GetOrdinal("Cpf"));
                        cli.Rg = reader.GetString(reader.GetOrdinal("Rg"));
                        cli.DataNasc = reader.GetDateTime(reader.GetOrdinal("DataNasc"));
                        cli.Logradouro = reader.GetString(reader.GetOrdinal("Logradouro"));
                        cli.NumLog = reader.GetString(reader.GetOrdinal("NumLog"));
                        cli.Complemento = reader.GetString(reader.GetOrdinal("Complemento"));
                        cli.Bairro = reader.GetString(reader.GetOrdinal("Bairro"));
                        cli.Cidade = reader.GetString(reader.GetOrdinal("Cidade"));
                        cli.Uf = reader.GetString(reader.GetOrdinal("Uf"));
                        cli.Cep = reader.GetString(reader.GetOrdinal("Cep"));
                        cli.Telefone = reader.GetString(reader.GetOrdinal("Telefone"));
                        cli.Celular = reader.GetString(reader.GetOrdinal("Celular"));
                        cli.Email = reader.GetString(reader.GetOrdinal("Email"));
                        cli.EstCivil = reader.GetString(reader.GetOrdinal("EstCivil"));
                        cli.Sexo = reader.GetString(reader.GetOrdinal("Sexo"));
                        cli.ValExameMedico = reader.GetDateTime(reader.GetOrdinal("ValExameMedico"));
                        cli.ToStringBehavior = toStringBehavior;
                        lista.Add(cli);
                    }
                }
                reader.Close();
                sqlCmd.Dispose();
                con.fechar();
            }
            catch (ErroConexao e)
            {
                throw new ErroConexao("A operação de consulta não está disponível no momento: " + e.Message);
            }
            catch (SqlException e)
            {
                throw new ErroPesquisar("Erro ao consultar cliente(s): " + e.Message);
            }
            return lista;
        }

    }
}
