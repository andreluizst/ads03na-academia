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
            if (c.Codigo <= 0)
                return false;
            Cliente obj = rpC.pegar(c.Codigo);
            if (obj != null)
                return true;
            return false;
        }
        public void validarDados(Cliente c)
        {
            string msg = "Erro de validação-> ";
            string msgCampoObrigatorio = "Campo obrigatório não preenchido-> ";
            if ((c.Nome == null) || (c.Nome.Length == 0))
                throw new ErroValidacao(msgCampoObrigatorio + "nome do cliente.");
            if (c.Nome.Length > 100)
                throw new ErroValidacao(msg + "O nome do cliente não deve ter mais de 100 caracteres.");
            
            if ((c.Codigo == 0) && (c.Cpf.Length > 0))
            {
                Cliente cliente = new Cliente();
                cliente.Cpf = c.Cpf;
                List<Cliente> lista = rpC.consultar(cliente);
                if (lista.Count > 0)
                    throw new ErroValidacao(msg + "CPF já cadastrado!");
            }

            if (c.Cpf != null)
            {
                if (c.Cpf.Length > 0)
                    if (Util.validarCpf(c.Cpf) == false)
                        throw new ErroValidacao(msg + "CPF inválido!");
            }
            if ((c.Rg == null) || (c.Rg.Length == 0))
                throw new ErroValidacao(msgCampoObrigatorio + "Erro ao validar RG.");
            if (c.Rg.Length > 11)
                throw new ErroValidacao(msg + "O RG não deve ter mais de 11 digitos.");                      
         
          DateTime dataValida;

          if (!DateTime.TryParse(c.DataNasc.ToShortDateString() ,out dataValida)|| (dataValida > DateTime.Today))
               throw new ErroValidacao(msg + "Data de nascimento.");          

            if ((c.Logradouro == null) || (c.Logradouro.Length == 0))
               throw new ErroValidacao(msgCampoObrigatorio + "Logradouro.");
            if (c.Logradouro.Length > 100)
                throw new ErroValidacao(msg + "O logradouro não deve ter mais de 100 caracteres.");

            if ((c.NumLog == null) || (c.NumLog.Length == 0))
                throw new ErroValidacao(msgCampoObrigatorio + "número do logradouro");
            if (c.NumLog.Length > 15)
                throw new ErroValidacao(msg + "O número do logradouro não deve ter mais de 15 caracteres.");

            if (c.Complemento != null)
                if (c.Complemento.Length > 50)
                    throw new ErroValidacao(msg + "O complemento não deve ter mais de 50 caracteres.");

            if ((c.Bairro == null) || (c.Bairro.Length == 0))
                throw new ErroValidacao(msgCampoObrigatorio + "Bairro");
            if (c.Bairro.Length > 60)
                throw new ErroValidacao(msg  + "O bairro não deve ter mais de 60 caratecres.");

            if ((c.Cidade == null) || (c.Cidade.Length == 0))
                throw new ErroValidacao(msgCampoObrigatorio + "Cidade");
            if (c.Cidade.Length > 60)
                throw new ErroValidacao(msg + "A cidade não deve ter mais de 60 caracteres.");

            if ((c.Uf == null) || (c.Uf.Length == 0))
                throw new ErroValidacao(msgCampoObrigatorio + "UF");
            if (c.Uf.Length == 1 || c.Uf.Length > 2)
                throw new ErroValidacao(msg + "UF deve ter dois caracteres.");

            if ((c.Cep == null) || (c.Cep.Length == 0))
                throw new ErroValidacao(msgCampoObrigatorio + "CEP");
            if (c.Cep.Length < 8 || c.Cep.Length > 8)
                throw new ErroValidacao(msg + "CEP incompleto.");

            if ((c.EstCivil == null) || (c.EstCivil.Length == 0))
                throw new ErroValidacao(msgCampoObrigatorio + "Estado civil");
            if (c.EstCivil.Length > 1)
                throw new ErroValidacao(msg + "Estado civil não deve conter mais de um caracter.");

            if ((c.Sexo == null) || (c.Sexo.Length == 0))
                throw new ErroValidacao(msgCampoObrigatorio + "Sexo");
            if (c.Sexo.Length > 1)
                throw new ErroValidacao(msg + "Sexo não deve conter mais de um caracter.");
            /*
            if (c.Telefone != null )
                if ((c.Telefone.Length > 0) && (c.Telefone.Length != 11))
                    throw new ErroValidacao(msg + "Número de telefone incompleto.");
            if (c.Celular != null)
                if (c.Celular.Length > 0 && c.Celular.Length != 11)
                    throw new ErroValidacao(msg + "Número de celular incompleto.");
            */
            if (c.Email != null)
                if (c.Email.Length > 100)
                    throw new ErroValidacao(msg + "O e-mail não deve ter mais de 100 caracteres.");
            if (c.Codigo == 0)
            {
                if (!DateTime.TryParse(c.ValExameMedico.ToShortDateString(), out dataValida) || (dataValida < DateTime.Today))
                    throw new ErroValidacao(msg + "Data do exame médico");
            }
            else
            {
                if (!DateTime.TryParse(c.ValExameMedico.ToShortDateString(), out dataValida))
                    throw new ErroValidacao(msg + "Data do exame médico");
            }

        }
        public void incluir(Cliente c)
        {
            try
            {
                rpC.incluir(c);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("A operação de incluir cliente não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroInclusao("Erro ao tentar incluir Cliente-> " + e.Message);
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
                throw new ErroConexao("A operação de alterar cliente não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroAlteracao("Erro ao tentar alterar Cliente-> " + e.Message);
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
                throw new ErroConexao("A operação de excluir cliente não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroExclusao("Erro ao tentar excluir Cliente-> " + e.Message);
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
                throw new ErroConexao("A operação de consultar cliente não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroPesquisar("Erro ao tentar consultar Cliente-> " + e.Message);
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
                throw new ErroConexao("A operação de consultar cliente não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroPesquisar("Erro ao tentar consultar Cliente-> " + e.Message);
            }
        }
    }
}
