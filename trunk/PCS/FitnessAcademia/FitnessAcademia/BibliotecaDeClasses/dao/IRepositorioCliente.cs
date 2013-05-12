using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaDeClasses.basica;

namespace BibliotecaDeClasses.dao
{
    public interface IRepositorioCliente
    {
        void incluir(Cliente c);
        void alterar(Cliente c);
        void excluir(Cliente c);
        List<Cliente> consultar(Cliente c, int toStringBehavior);
        List<Cliente> consultar(Cliente c);
        Cliente pegar(int codigo);
        Cliente pegar(int codigo, int toStringBehavior);
    }
}
