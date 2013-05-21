using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BibliotecaDeClasses.basica;
using BibliotecaDeClasses.erro;
using BibliotecaDeClasses.fachada;

namespace WebSrvPlanoTreinamento
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

        //******************************* PLANO DE TREINAMENTO *******************************
        [WebMethod]
        public PlanoTreinamento[] consultarPlanoTreinamento(PlanoTreinamento obj, DateTime dataFinal)
        {
            return Fachada.obterInstancia().consultar(obj, dataFinal).ToArray();
        }

        [WebMethod]
        public PlanoTreinamento[] consultarPlanoTreinamentoEx(PlanoTreinamento obj, DateTime dataFinal, int toStringBehavior)
        {
            return Fachada.obterInstancia().consultar(obj, dataFinal, toStringBehavior).ToArray();
        }

        [WebMethod]
        public void salvarPlanoTreinamento(PlanoTreinamento obj)
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
        public void excluirPlanoTreinamento(PlanoTreinamento obj)
        {
            Fachada.obterInstancia().excluir(obj);
        }

        [WebMethod]
        public PlanoTreinamento pegarPlanoTreinamento(int codigo)
        {
            return Fachada.obterInstancia().pegarPlanoTreinamento(codigo);
        }

        [WebMethod]
        public PlanoTreinamento pegarPlanoTreinamentoEx(int codigo, int toStringBehavior)
        {
            return Fachada.obterInstancia().pegarPlanoTreinamento(codigo, toStringBehavior);
        }

        [WebMethod]
        public Cliente[] listarClientes()
        {
            Cliente c = new Cliente();
            c.Codigo = 0;
            c.Nome = "%";
            return Fachada.obterInstancia().consultar(c, Cliente.TO_STRING_NOME_CPF).ToArray();
        }

        [WebMethod]
        public Objetivo[] listarObjetivos()
        {
            Objetivo o = new Objetivo();
            o.Codigo = 0;
            o.Descricao = "%";
            return Fachada.obterInstancia().consultar(o, Objetivo.TO_STRING_DESCRICAO).ToArray();
        }

        [WebMethod]
        public Exercicio[] listarExercicios()
        {
            Exercicio obj = new Exercicio();
            obj.Codigo = 0;
            obj.Descricao = "%";
            return Fachada.obterInstancia().consultar(obj, Exercicio.TO_STRING_DESCRICAO).ToArray();
        }

    }
}