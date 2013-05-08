
using BibliotecaDeClasses.basica;
using BibliotecaDeClasses.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestarFuncionalidades
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cliente c = new Cliente();
                c.Codigo = 3;
                /*c.Nome = "Leandro vieira";
                c.Cpf = "98765432103";
                c.Rg = "rg8885743";
                c.Logradouro = "rua marinada";
                c.NumLog = "32";
                c.Complemento = "apto 1203";
                c.Bairro = "B viagem";
                c.Cidade = "Recife";
                c.Uf = "pe";
                c.Cep = "51030490";
                c.Telefone = "8133446655";
                c.Celular = "8199882211";
                c.Email = "mariana.lima@meuemail.com.br";
                c.EstCivil = "s";
                c.Sexo = "f";
                c.DataNasc = Convert.ToDateTime("13/04/1975");
                c.ValExameMedico = Convert.ToDateTime("30/06/2013");
                RepositorioCliente.obterInstancia().excluir(c);*/
                c.Codigo = 0;
                c.Nome = "%";
                List<Cliente> lst = RepositorioCliente.obterInstancia().consultar(c);
                foreach (Cliente item in lst)
                {
                    Console.WriteLine(item);  
                }
                
                Console.WriteLine();
                lst = RepositorioCliente.obterInstancia().consultar(c, Cliente.TO_STRING_FULL);
                foreach (Cliente item in lst)
                {
                    Console.WriteLine(item);
                }
                //Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
