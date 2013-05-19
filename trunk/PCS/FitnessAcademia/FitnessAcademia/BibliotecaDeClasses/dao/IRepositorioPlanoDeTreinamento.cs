using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaDeClasses.basica;

namespace BibliotecaDeClasses.dao
{
    public interface IRepositorioPlanoDeTreinamento
    {
        void incluir(PlanoTreinamento pt);
        void alterar(PlanoTreinamento pt);
        void excluir(PlanoTreinamento pt);
        List<PlanoTreinamento> consultar(PlanoTreinamento pt, DateTime dataFinal, int toStringBehavior);
        List<PlanoTreinamento> consultar(PlanoTreinamento pt, DateTime dataFinal);
       
    }
}
