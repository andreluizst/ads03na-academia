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

            //if (c.Logradouro == null)
               // throw new ErroValidacao("Erro ao validar Logradouro!");
            if (c.Logradouro.Length == 0 || c.Logradouro.Length > 100)
                throw new ErroValidacao("Erro ao validar Logradouro");

            //if (c.NumLog == null)
               // throw new ErroValidacao("Erro ao validar NumLog!");
            if (c.NumLog.Length == 0 || c.NumLog.Length > 15)
                throw new ErroValidacao("Erro ao validar NumLog");

           // if (c.Complemento == null)
               // throw new ErroValidacao("Erro ao validar Complemento!");
            if (c.Complemento.Length == 0 || c.Complemento.Length > 50)
                throw new ErroValidacao("Erro ao validar Complemento");

            if (c.Bairro.Length == 0 || c.Bairro.Length > 60)
                throw new ErroValidacao("Erro ao validar Complemento");

            if (c.Cidade.Length == 0 || c.Cidade.Length > 60)
                throw new ErroValidacao("Erro ao validar Complemento");

            if (c.Uf.Length == 0 || c.Uf.Length > 2)
                throw new ErroValidacao("Erro ao validar Complemento");

            if (c.Cep.Length == 0 || c.Cep.Length > 8)
                throw new ErroValidacao("Erro ao validar Complemento");

            if (c.EstCivil.Length == 0 || c.EstCivil.Length > 1)
                throw new ErroValidacao("Erro ao validar Complemento");

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
    }
}
