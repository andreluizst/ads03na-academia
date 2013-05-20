using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaDeClasses.erro;
using BibliotecaDeClasses.basica;
using BibliotecaDeClasses.regra;

namespace BibliotecaDeClasses.fachada
{
    public class Fachada
    {
        private static Fachada instancia;
        private ControladorExercicio ctrlE;

        private Fachada()
        {
            ctrlE = new ControladorExercicio();
        }

        public static Fachada obterInstancia()
        {
            if (instancia == null)
                instancia = new Fachada();
            return instancia;
        }

        //------------------------ EXERCÍCIO ----------------------------------

        public void salvar(Exercicio exer)
        {
            try
            {
                ctrlE.validarDados(exer);
                if (ctrlE.existe(exer) == true)
                    ctrlE.alterar(exer);
                else
                    ctrlE.incluir(exer);
            }
            catch (ErroValidacao ev)
            {
                throw new Exception(ev.Message);
            }
            catch (ErroInclusao ei)
            {
                throw new Exception(ei.Message);
            }
            
        }

        public void excluir(Exercicio exer)
        {
            ctrlE.excluir(exer);
        }

        public List<Exercicio> consultar(Exercicio exer)
        {
            return ctrlE.consultar(exer, Exercicio.TO_STRING_DEFAULT);
        }

        public List<Exercicio> consultar(Exercicio exer, int toStringBehavior)
        {
            return ctrlE.consultar(exer, toStringBehavior);
        }

        public Exercicio pegar(int codigo)
        {
            return ctrlE.pegar(codigo);
        }

        public Exercicio pegar(int codigo, int toStringBehavior)
        {
            return pegar(codigo, toStringBehavior);
        }

        //------------------------------OBJETIVO -------------------------------
        /*public void consultar<T>(T obj) where T:IComparable
        {
            if (obj is Exercicio)
            ctrlE.consultar((Exercicio)obj);
        }*/



        //----------------------------CLIENTE --------------------------------



        //-------------------------PLANO DE TREINAMENTO -----------------------


    }
}
