using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaDeClasses.basica;
using BibliotecaDeClasses.dao;
using BibliotecaDeClasses.erro;

namespace BibliotecaDeClasses.regra
{
    public class ControladorCliente
    {
        private IRepositorioCliente rpC;

        public ControladorCliente()
        {
            rpC = new RepositorioCliente();
        }

        public bool existe(Cliente c)
        {
            List<Cliente> lista = rpC.consultar(c);
            if (lista.Count > 0)
                return true;
            return false;
        }
        public void validarDados(Cliente c)
        {
            if (c.Nome == null)
                throw new ErroValidacao("Erro ao validar cliente!");
            if (c.Nome.Length == 0 || c.Nome.Length > 100)
                throw new ErroValidacao("Erro ao validar cliente");

            
            //------------validar CPF--------------------------
                    



            //------------validar RG--------------------------


            //------------validar data de nascimento-----------

            //NÃO FUNCIONOU
          DateTime result = DateTime.MinValue;
          if(!DateTime.TryParse(c.DataNasc.ToShortDateString() ,out result))
               throw new ErroValidacao("Erro ao validar Data de Nascimento!");

          

            if (c.Logradouro == null)
               throw new ErroValidacao("Erro ao validar Logradouro!");
            if (c.Logradouro.Length == 0 || c.Logradouro.Length > 100)
                throw new ErroValidacao("Erro ao validar Logradouro");

            if (c.NumLog == null)
                throw new ErroValidacao("Erro ao validar NumLog!");
            if (c.NumLog.Length == 0 || c.NumLog.Length > 15)
                throw new ErroValidacao("Erro ao validar NumLog");

           
            if (c.Complemento.Length == 0 || c.Complemento.Length > 50)
                throw new ErroValidacao("Erro ao validar Complemento");

            if(c.Bairro == null)
                throw new ErroValidacao("Erro ao validar Bairro");
            if (c.Bairro.Length == 0 || c.Bairro.Length > 60)
                throw new ErroValidacao("Erro ao validar Bairro");

            if(c.Cidade == null)
                throw new ErroValidacao("Erro ao validar Cidade");
            if (c.Cidade.Length == 0 || c.Cidade.Length > 60)
                throw new ErroValidacao("Erro ao validar Cidade");

            if(c.Uf == null)
                throw new ErroValidacao("Erro ao validar UF");
            if (c.Uf.Length == 0 || c.Uf.Length > 2)
                throw new ErroValidacao("Erro ao validar UF");

            if(c.Cep == null)
                throw new ErroValidacao("Erro ao validar CEP");
            if (c.Cep.Length == 0 || c.Cep.Length > 8)
                throw new ErroValidacao("Erro ao validar CEP");


            if (c.EstCivil.Length == 0 || c.EstCivil.Length > 1)
                throw new ErroValidacao("Erro ao validar Estado civil");

            if (c.Sexo.Length == 0 || c.Sexo.Length > 1)
                throw new ErroValidacao("Erro ao validar Complemento");

            if (c.Telefone.Length == 0 || c.Telefone.Length > 11)
                throw new ErroValidacao("Erro ao validar Complemento");

            if (c.Celular.Length == 0 || c.Celular.Length > 11)
                throw new ErroValidacao("Erro ao validar Complemento");

            if (c.Email.Length == 0 || c.Email.Length > 100)
                throw new ErroValidacao("Erro ao validar Complemento");

           //----------------Validade exame médico-------------------

        }
        public void incluir(Cliente c)
        {
            try
            {
                rpC.incluir(c);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("Cliente: A operação de inclusão não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroInclusao("Erro ao tentar incluir Cliente: " + e.Message);
            }
        }
        public void alterar(Cliente c)
        {
            try
            {
                rpC.alterar(c);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("Cliente: A operação de alteração não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroAlteracao("Erro ao tentar alterar Cliente: " + e.Message);
            }
        }
        public void excluir(Cliente c)
        {
            try
            {
                rpC.excluir(c);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("Cliente: A operação de exclusão não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroExclusao("Erro ao tentar excluir Clienteo: " + e.Message);
            }
        }
        public List<Cliente> consultar(Cliente c)
        {
            return consultar(c, Exercicio.TO_STRING_DEFAULT);
        }

        public List<Cliente> consultar(Cliente c, int toStringBehavior)
        {
            try
            {
                return rpC.consultar(c, toStringBehavior);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("Cliente: A operação de consultar não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroPesquisar("Erro ao tentar consultar Cliente: " + e.Message);
            }
        }
        public Cliente pegar(int codigo)
        {
            return pegar(codigo, Cliente.TO_STRING_DEFAULT);
        }

        public Cliente pegar(int codigo, int toStringBehavior)
        {
            try
            {
                return rpC.pegar(codigo, toStringBehavior);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("cliente: A operação de consultar não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroPesquisar("Erro ao tentar consultar Cliente: " + e.Message);
            }
        }
    }
}
