using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaDeClasses.basica;

namespace BibliotecaDeClasses.dao
{
    interface IRepositorioExercicio
    {
        void incluir(Exercicio e);
        void alterar(Exercicio e);
        void excluir(Cliente c);
        List<Cliente> consultar(Exercicio e, int toStringBehavior);
        List<Cliente> consultar(Exercicio e);
    }
}
