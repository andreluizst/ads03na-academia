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
        private ControladorObjetivo ctrlO;
        private ControladorCliente ctrlC;
        private ControladorPlanoTreinamento ctrlPt;

        private Fachada()
        {
            ctrlE = new ControladorExercicio();
            ctrlO = new ControladorObjetivo();
            ctrlC = new ControladorCliente();
            ctrlPt = new ControladorPlanoTreinamento();
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

        public Exercicio pegarExercicio(int codigo)
        {
            return ctrlE.pegar(codigo);
        }

        public Exercicio pegarExercicio(int codigo, int toStringBehavior)
        {
            return ctrlE.pegar(codigo, toStringBehavior);
        }

        //------------------------------OBJETIVO -------------------------------
        public void salvar(Objetivo obj)
        {
            try
            {
                ctrlO.validarDados(obj);
                if (ctrlO.existe(obj) == true)
                    ctrlO.alterar(obj);
                else
                    ctrlO.incluir(obj);
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

        public void excluir(Objetivo obj)
        {
            ctrlO.excluir(obj);
        }

        public List<Objetivo> consultar(Objetivo obj)
        {
            return ctrlO.consultar(obj, Objetivo.TO_STRING_DEFAULT);
        }

        public List<Objetivo> consultar(Objetivo obj, int toStringBehavior)
        {
            return ctrlO.consultar(obj, toStringBehavior);
        }

        public Objetivo pegarObjetivo(int codigo)
        {
            return ctrlO.pegar(codigo);
        }

        public Objetivo pegarObjetivo(int codigo, int toStringBehavior)
        {
            return ctrlO.pegar(codigo, toStringBehavior);
        }



        //----------------------------CLIENTE --------------------------------
        public void salvar(Cliente obj)
        {
            try
            {
                ctrlC.validarDados(obj);
                if (ctrlC.existe(obj) == true)
                    ctrlC.alterar(obj);
                else
                    ctrlC.incluir(obj);
            }
            catch (ErroValidacao ev)
            {
                //MessageBox.Show(ev.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new Exception("Erro de validação!");//ev.Message);
            }
            catch (ErroInclusao ei)
            {
                throw new Exception(ei.Message);
            }

        }

        public void excluir(Cliente obj)
        {
            ctrlC.excluir(obj);
        }

        public List<Cliente> consultar(Cliente obj)
        {
            return ctrlC.consultar(obj, Cliente.TO_STRING_DEFAULT);
        }

        public List<Cliente> consultar(Cliente obj, int toStringBehavior)
        {
            return ctrlC.consultar(obj, toStringBehavior);
        }

        public Cliente pegarCliente(int codigo)
        {
            return ctrlC.pegar(codigo);
        }

        public Cliente pegarCliente(int codigo, int toStringBehavior)
        {
            return ctrlC.pegar(codigo, toStringBehavior);
        }


        //-------------------------PLANO DE TREINAMENTO -----------------------
        public void salvar(PlanoTreinamento obj)
        {
            try
            {
                ctrlPt.validarDados(obj);
                if (ctrlPt.existe(obj) == true)
                    ctrlPt.alterar(obj);
                else
                    ctrlPt.incluir(obj);
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

        public void excluir(PlanoTreinamento obj)
        {
            ctrlPt.excluir(obj);
        }

        public List<PlanoTreinamento> consultar(PlanoTreinamento obj, DateTime dataFinal)
        {
            return ctrlPt.consultar(obj, dataFinal, PlanoTreinamento.TO_STRING_DEFAULT);
        }

        public List<PlanoTreinamento> consultar(PlanoTreinamento obj, DateTime dataFinal, int toStringBehavior)
        {
            return ctrlPt.consultar(obj, dataFinal, toStringBehavior);
        }

        public PlanoTreinamento pegarPlanoTreinamento(int numero)
        {
            return ctrlPt.pegar(numero);
        }

        public PlanoTreinamento pegarPlanoTreinamento(int numero, int toStringBehavior)
        {
            return ctrlPt.pegar(numero, toStringBehavior);
        }
        

    }
}
