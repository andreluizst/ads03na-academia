
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
