using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaDeClasses.basica;

namespace BibliotecaDeClasses.dao
{
    public interface IRepositorioExercicio
    {
        void incluir(Exercicio e);
        void alterar(Exercicio e);
        void excluir(Exercicio e);
        List<Exercicio> consultar(Exercicio e, int toStringBehavior);
        List<Exercicio> consultar(Exercicio e);
        Exercicio pegar(int codigo);
        Exercicio pegar(int codigo, int toStringBehavior);
    }
}
