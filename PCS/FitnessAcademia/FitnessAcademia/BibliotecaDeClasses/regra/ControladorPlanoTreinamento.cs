using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaDeClasses.basica;
using BibliotecaDeClasses.dao;
using BibliotecaDeClasses.erro;

namespace BibliotecaDeClasses.regra
{
    public class ControladorPlanoTreinamento
    {
        private IRepositorioPlanoDeTreinamento rpPT;
        private bool operacoesLiberadas;
        private ControladorCliente ctrlC;
        private ControladorExercicio ctrlE;
        private ControladorObjetivo ctrlO;
        private string msgOperacoesBloqueadas = "Para iniciar Plano de Treinamento, clientes, objetivos e exercícios"
            + " devem estar previamente cadastrados!";
            //+ "\nClientes;\nObjetivos\nExercícios.";

        public ControladorPlanoTreinamento()
        {
            rpPT = new RepositorioPlanoDeTreinamento();
            operacoesLiberadas = false;
        }

        public void validarLiberacaoDeOperacoes()
        {
            ctrlC = new ControladorCliente();
            ctrlO = new ControladorObjetivo();
            ctrlE = new ControladorExercicio();
            operacoesLiberadas = ctrlC.consultar(new Cliente("%")).Count > 0 ? true : false;
            operacoesLiberadas = operacoesLiberadas == true ? ctrlO.consultar(new Objetivo(0, "%")).Count > 0 : false;
            operacoesLiberadas = operacoesLiberadas == true ? ctrlE.consultar(new Exercicio(0, "%")).Count > 0 : false;
            if (operacoesLiberadas == false)
                throw new Exception(msgOperacoesBloqueadas);
        }

        public bool existe(PlanoTreinamento obj)
        {
            if (obj.Numplano <= 0)
                return false;
            PlanoTreinamento pt = rpPT.pegar(obj.Numplano);
            if (pt != null)
                return true;
            return false;
        }

        public bool existe(PlanoTreinamento pt, DateTime dataFinal)
        {
            List<PlanoTreinamento> lista = rpPT.consultar(pt, dataFinal);
            if (lista.Count > 0)
                return true;
            return false;

        }

        public void validarDados(PlanoTreinamento pt)
        {
            string msg = "Erro de validação-> ";
            string msgCampoObrigatorio = "Campo obrigatório não preenchido-> ";
            if (pt.ObjetivoDoPlano != null)
            {
                if (pt.ObjetivoDoPlano.Codigo <= 0)
                    throw new ErroValidacao(msgCampoObrigatorio + "Objetivo.");
            }
            else
                throw new ErroValidacao(msgCampoObrigatorio + "Objetivo.");
            if (pt.ClienteDoPlano != null)
            {
                if (pt.ClienteDoPlano.Codigo <= 0)
                    throw new ErroValidacao(msgCampoObrigatorio + "Cliente.");
            }
            else
                throw new ErroValidacao(msgCampoObrigatorio + "Cliente.");

            DateTime dataValida;

            if (!DateTime.TryParse(pt.Data.ToShortDateString(), out dataValida))// || (dataValida < DateTime.Today))
                throw new ErroValidacao(msg + "Data inválida.");
            if (pt.Exercicios != null)
            {
                if (pt.Exercicios.Count > 0)
                {
                    foreach (ExercicioDoPlano item in pt.Exercicios)
                    {
                        if (item.Exercicio != null)
                            if (item.Exercicio.Codigo <= 0)
                                throw new ErroValidacao(msgCampoObrigatorio + "Exercício.");
                        if (item.Seq <= 0)
                            throw new ErroValidacao(msgCampoObrigatorio + "Seq.");
                        if (item.Series <= 0)
                            throw new ErroValidacao(msgCampoObrigatorio + "Séries.");
                        if (item.NumRepeticoes <= 0)
                            throw new ErroValidacao(msgCampoObrigatorio + "Nº Repetições.");
                    }
                }
                else
                    throw new ErroValidacao(msg + "O plano de treinamento deve ter um ou mais exercícios!");
            }
            else
                throw new ErroValidacao(msg + "O plano de treinamento deve ter um ou mais exercícios!");
        }

        public void incluir(PlanoTreinamento pt)
        {
            try
            {
                rpPT.incluir(pt);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("A operação de incluir plano de treinamento não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroInclusao("Erro ao tentar incluir Plano de Treinamento-> " + e.Message);
            }
        }

        public void alterar(PlanoTreinamento pt)
        {
            try
            {
                rpPT.alterar(pt);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("A operação de alterar Plano de Treinamento não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroAlteracao("Erro ao tentar alterar Plano de Treinamento-> " + e.Message);
            }
        }

        public void excluir(PlanoTreinamento pt)
        {
            try
            {
                rpPT.excluir(pt);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("A operação de excluir Plano de Treinamento não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroExclusao("Erro ao tentar excluir Plano de Treinamento-> " + e.Message);
            }
        }

        public List<PlanoTreinamento> consultar(PlanoTreinamento pt, DateTime dataFinal)
        {
            return consultar(pt, dataFinal, PlanoTreinamento.TO_STRING_DEFAULT);
        }

        public List<PlanoTreinamento> consultar(PlanoTreinamento pt, DateTime dataFinal, int toStringBehavior)
        {
            try
            {
                return rpPT.consultar(pt, dataFinal, toStringBehavior);
               
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("A operação de consultar Plano de Treinamento não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroPesquisar("Erro ao tentar consultar Plano de Treinamento-> " + e.Message);
            }
        }

        public PlanoTreinamento pegar(int numero)
        {
            return pegar(numero, PlanoTreinamento.TO_STRING_DEFAULT);
        }

        public PlanoTreinamento pegar(int numero, int toStringBehavior)
        {
            try
            {
                return rpPT.pegar(numero, toStringBehavior);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("A operação de consultar Plano de Treinamento não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroPesquisar("Erro ao tentar consultar plano de treinamento-> " + e.Message);
            }
        }

    }
}
