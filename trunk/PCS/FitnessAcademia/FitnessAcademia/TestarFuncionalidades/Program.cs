
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
                Objetivo o = new Objetivo();
                o.Codigo = 2;
                Cliente c = new Cliente();
                c.Codigo = 1;
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
                IRepositorioPlanoDeTreinamento rp = new RepositorioPlanoDeTreinamento();
                rp.incluir(pt);
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
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
