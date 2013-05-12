using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaDeClasses.basica;

namespace BibliotecaDeClasses.dao
{
    public interface IRepositorioObjetivo
    {
        void incluir(Objetivo o);
        void alterar(Objetivo o);
        void excluir(Objetivo o);
        List<Objetivo> consultar(Objetivo o, int toStringBehavior);
        List<Objetivo> consultar(Objetivo o);
        Objetivo pegar(int codigo);
        Objetivo pegar(int codigo, int toStringBehavior);
    }
}
