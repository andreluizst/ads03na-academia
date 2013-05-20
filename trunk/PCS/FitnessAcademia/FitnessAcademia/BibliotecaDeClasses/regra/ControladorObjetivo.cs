using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaDeClasses.basica;
using BibliotecaDeClasses.dao;
using BibliotecaDeClasses.erro;

namespace BibliotecaDeClasses.regra
{
    public class ControladorObjetivo
    {
        private IRepositorioObjetivo rpO;

        public ControladorObjetivo()
        {
            rpO = new RepositorioObjetivo();

        }
        public bool existe(Objetivo obvo)
        {
            if (obvo.Codigo <= 0)
                return false;
            Objetivo o = rpO.pegar(obvo.Codigo);
            if (o != null)
                return true;
            return false;

        }
        public void validarDados(Objetivo obvo)
        {
            if (obvo.Descricao == null)
                throw new ErroValidacao("Erro ao validar Objetivo");
            if (obvo.Descricao.Length == 0 || obvo.Descricao.Length > 50)
                throw new ErroValidacao("Erro ao validar Objetivo");

        }
        public void incluir(Objetivo obvo)
        {
            try
            {
                rpO.incluir(obvo);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("Objetivo: A operação de inclusão não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroInclusao("Erro ao tentar incluir Objetivo: " + e.Message);
            }
        }

        public void alterar(Objetivo obvo)
        {
            try
            {
                rpO.alterar(obvo);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("Objetivo: A operação de alteração não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroInclusao("Erro ao tentar alterar Objetivo: " + e.Message);
            }
        }
        public void excluir(Objetivo obvo)
        {
            try
            {
                rpO.excluir(obvo);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("Objetivo: A operação de exclusão não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroInclusao("Erro ao tentar excluir Objetivo: " + e.Message);
            }
        }

        public List<Objetivo> consultar(Objetivo obvo)
        {
            return consultar(obvo, Objetivo.TO_STRING_DEFAULT);

        }
        public List<Objetivo> consultar(Objetivo obvo, int toStringBehavior)
        {
            try
            {
                return rpO.consultar(obvo, toStringBehavior);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("Objetivo: A operação de consultar não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroPesquisar("Erro ao tentar consultar Objetivo: " + e.Message);
            }
        }

        public Objetivo pegar(int codigo)
        { 
            return pegar(codigo, Objetivo.TO_STRING_DEFAULT);
        }

        public Objetivo pegar(int codigo, int toStringBehavior)
        {
            try
            {
                return rpO.pegar(codigo, toStringBehavior);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("Objetivo: A operação de consultar não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroPesquisar("Erro ao tentar consultar Objetivo: " + e.Message);
            }
        }
    }
}
