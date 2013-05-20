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

        public ControladorPlanoTreinamento()
        {
            rpPT = new RepositorioPlanoDeTreinamento();
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
            DateTime dataValida;

            if (!DateTime.TryParse(pt.Data.ToShortDateString(), out dataValida) || (dataValida < DateTime.Today))
                throw new ErroValidacao("Erro ao validar data do Plano de Treinamento");

        }
        public void incluir(PlanoTreinamento pt)
        {
            try
            {
                rpPT.incluir(pt);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("Plano de Treinamento: A operação de inclusão não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroInclusao("Erro ao tentar incluir Plano de Treinamento: " + e.Message);
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
                throw new ErroConexao("Plano de Treinamento: A operação de alteração não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroAlteracao("Erro ao tentar alterar Plano de Treinamento: " + e.Message);
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
                throw new ErroConexao("Plano de Treinamento: A operação de exclusão não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroExclusao("Erro ao tentar excluir Plano de Treinamento: " + e.Message);
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
                throw new ErroConexao("Plano de treinamento: A operação de consultar não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroPesquisar("Erro ao tentar consultar Plano de Treinamento: " + e.Message);
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
                throw new ErroConexao("Plano de treinamento: A operação de consultar não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroPesquisar("Erro ao tentar consultar plano de treinamento: " + e.Message);
            }
        }

    }
}
