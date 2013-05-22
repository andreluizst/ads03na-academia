using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BibliotecaDeClasses.basica;
using BibliotecaDeClasses.erro;
using BibliotecaDeClasses.fachada;

namespace WebSrvGeral
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        private string msgError;
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string getLastMsgError()
        {
            return msgError;
        }

        [WebMethod]
        public void salvarTeste()
        {
            Exercicio exer = new Exercicio();
            exer.Descricao = "";
            //Fachada.obterInstancia().salvar(exer);
            try
            {
                Fachada.obterInstancia().salvar(exer);
            }
            catch (Exception e)
            {
                msgError = e.Message;
                throw e;
            }
        }

        //------------------------------ EXERCÍCIO ----------------------------------
        [WebMethod]
        public Exercicio[] consultarExercicio(Exercicio exer)
        {
            return Fachada.obterInstancia().consultar(exer).ToArray();
        }

        [WebMethod]
        public Exercicio[] consultarExercicioEx(Exercicio exer, int toStringBehavior)
        {
            return Fachada.obterInstancia().consultar(exer, toStringBehavior).ToArray();
        }

        [WebMethod]
        public void salvarExercicio(Exercicio exer)
        {
            try
            {
                Fachada.obterInstancia().salvar(exer);
            }
            catch (Exception e)
            {
                msgError = e.Message;
                throw e;
            }
        }

        [WebMethod]
        public void excluirExercicio(Exercicio exer)
        {
            Fachada.obterInstancia().excluir(exer);
        }

        [WebMethod]
        public Exercicio pegarExercicio(int codigo)
        {
            return Fachada.obterInstancia().pegarExercicio(codigo);
        }

        [WebMethod]
        public Exercicio pegarExercicioEx(int codigo, int toStringBehavior)
        {
            return Fachada.obterInstancia().pegarExercicio(codigo, toStringBehavior);
        }

        //---------------------------------- OBJETIVO -----------------------------------
        [WebMethod]
        public Objetivo[] consultarObjetivo(Objetivo obj)
        {
            return Fachada.obterInstancia().consultar(obj).ToArray();
        }

        [WebMethod]
        public Objetivo[] consultarObjetivoEx(Objetivo obj, int toStringBehavior)
        {
            return Fachada.obterInstancia().consultar(obj, toStringBehavior).ToArray();
        }

        [WebMethod]
        public void salvarObjetivo(Objetivo obj)
        {
            try
            {
                Fachada.obterInstancia().salvar(obj);
            }
            catch (Exception e)
            {
                msgError = e.Message;
                throw e;
            }
        }

        [WebMethod]
        public void excluirObjetivo(Objetivo obj)
        {
            Fachada.obterInstancia().excluir(obj);
        }

        [WebMethod]
        public Objetivo pegarObjetivo(int codigo)
        {
            return Fachada.obterInstancia().pegarObjetivo(codigo);
        }

        [WebMethod]
        public Objetivo pegarObjetivoEx(int codigo, int toStringBehavior)
        {
            return Fachada.obterInstancia().pegarObjetivo(codigo, toStringBehavior);
        }

        //---------------------------------- CLIENTE ------------------------------------
        [WebMethod]
        public Cliente[] consultarCliente(Cliente obj)
        {
            return Fachada.obterInstancia().consultar(obj).ToArray();
        }

        [WebMethod]
        public Cliente[] consultarClienteEx(Cliente obj, int toStringBehavior)
        {
            return Fachada.obterInstancia().consultar(obj, toStringBehavior).ToArray();
        }

        [WebMethod]
        public void salvarCliente(Cliente obj)
        {
            try
            {
                Fachada.obterInstancia().salvar(obj);
            }
            catch (Exception e)
            {
                msgError = e.Message;
                throw e;
            }
        }

        [WebMethod]
        public void excluirCliente(Cliente obj)
        {
            Fachada.obterInstancia().excluir(obj);
        }

        [WebMethod]
        public Cliente pegarCliente(int codigo)
        {
            return Fachada.obterInstancia().pegarCliente(codigo);
        }

        [WebMethod]
        public Cliente pegarClienteEx(int codigo, int toStringBehavior)
        {
            return Fachada.obterInstancia().pegarCliente(codigo, toStringBehavior);
        }
        
    }
}