
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
                /*
                RepositorioCliente rpC = new RepositorioCliente();
                Cliente cli = new Cliente();

                cli.Nome = "Fernanda";
                cli.Cpf = "11111111111";
                cli.Rg = "22222222222";                
                cli.DataNasc = Convert.ToDateTime("3/9/2012");
                cli.Logradouro = "Av Boa viagem";
                cli.NumLog = "10";
                cli.Complemento = "Apto";
                cli.Bairro = "Boa viagem";
                cli.Cidade = "Recife";
                cli.Uf = "PE";
                cli.Cep = "33323232";
                cli.EstCivil = "S";
                cli.Sexo = "F";
                cli.Telefone = "67576576";
                cli.Celular = "887878787";
                cli.Email = "fernanda@hotmail.com";
                cli.ValExameMedico = Convert.ToDateTime("5/9/2013");
                
                rpC.incluir(cli);
                */

               // cli.Codigo = 10;
             // rpC.excluir(cli);
                Console.WriteLine("OK");
                /*

                IRepositorioPlanoDeTreinamento rpP = new RepositorioPlanoDeTreinamento();
                Objetivo o = new Objetivo();
                o.Codigo = 2;
                Cliente c = new Cliente();
                c.Codigo = 2;
                PlanoTreinamento pt = new PlanoTreinamento();
                pt.ClienteDoPlano = c;
                pt.Data = Convert.ToDateTime("12/05/2013");
                pt.ObjetivoDoPlano = o;
                Exercicio exercicio = new Exercicio();
                exercicio.Codigo = 1;
                ExercicioDoPlano ep = new ExercicioDoPlano(1, exercicio, 5, 10, 0);
                pt.Exercicios.Add(ep);
                Exercicio e2 = new Exercicio();
                e2.Codigo = 3;
                pt.Exercicios.Add(new ExercicioDoPlano(2, e2, 4, 15, 0));
                Exercicio e3 = new Exercicio();
                e3.Codigo = 5;
                pt.Exercicios.Add(new ExercicioDoPlano(3, e3, 6, 6, 0));
                //rpP.incluir(pt);
                List<PlanoTreinamento> lst = new List<PlanoTreinamento>();
                lst.Add(pt);
                Console.WriteLine(pt);
                Console.WriteLine("listando lst<PlanoTreinamento>...");
                foreach (PlanoTreinamento item in lst)
                {
                    Console.WriteLine(item);
                    if (item.Exercicios.Count > 0)
                        foreach (ExercicioDoPlano sub in item.Exercicios)
                        {
                            Console.WriteLine("\t" + sub);
                        }
                }
                Console.WriteLine("listar planos...");
                pt.Data = Convert.ToDateTime("01/01/2013");
                pt.Numplano = 0;
                pt.ObjetivoDoPlano.Codigo = 0;
                pt.ClienteDoPlano.Codigo = 0;
                Console.WriteLine("Consultando plano de treinamento: de " + pt.Data + " até " + DateTime.Now);
                List<PlanoTreinamento> lstPlano = rpP.consultar(pt, DateTime.Now, PlanoTreinamento.TO_STRING_COMPACT);
                //Console.WriteLine(pt);
                foreach (PlanoTreinamento item in lstPlano)
                {
                    Console.WriteLine("Plano de treinamento " + item.Numplano.ToString());
                    Console.WriteLine(item);
                    if (item.Exercicios.Count > 0)
                    {
                        Console.WriteLine("Listando os exercicios do plano de treinamento...");
                        foreach (ExercicioDoPlano subItem in item.Exercicios)
                        {
                            Console.WriteLine("\t" + subItem);
                        }
                    }
                }
                */
                /*Exercicio e = new Exercicio(1, "Abdominal");
                RepositorioExercicio.obterInstancia().incluir(e);
                e.Codigo = 0;
                e.Descricao = "%";
                List<Exercicio> lstExercicio = RepositorioExercicio.obterInstancia().consultar(e);
                Console.WriteLine("Primeira listagem");
                foreach (Exercicio item in lstExercicio)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                e.Codigo = 5;
                RepositorioExercicio.obterInstancia().excluir(e);
                e.Codigo = 8;
                e.Descricao = "ALTERADO";
                RepositorioExercicio.obterInstancia().alterar(e);
                e.Codigo = 0;
                e.Descricao = "%";
                lstExercicio = RepositorioExercicio.obterInstancia().consultar(e);
                Console.WriteLine("Segunda listagem");
                foreach (Exercicio item in lstExercicio)
                {
                    Console.WriteLine(item);
                }*/
                //Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}
