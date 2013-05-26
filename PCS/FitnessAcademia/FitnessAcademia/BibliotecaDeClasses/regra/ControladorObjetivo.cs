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
            string msg = "Erro de validação-> ";
            string msgCampoObrigatorio = "Campos obrigatório não preenchido-> ";
            if ((obvo.Descricao == null) || (obvo.Descricao.Length == 0))
                throw new ErroValidacao(msgCampoObrigatorio + "descrição.");
            if (obvo.Descricao.Length > 50)
                throw new ErroValidacao(msg + "A descrição do objetivo não deve ter mais de 50 caracteres.");

        }
        public void incluir(Objetivo obvo)
        {
            try
            {
                rpO.incluir(obvo);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("A operação de incluir objetivo não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroInclusao("Erro ao tentar incluir Objetivo-> " + e.Message);
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
                throw new ErroConexao("A operação de alterar objetivo não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroAlteracao("Erro ao tentar alterar Objetivo-> " + e.Message);
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
                throw new ErroConexao("A operação de excluir objetivo não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroExclusao("Erro ao tentar excluir Objetivo-> " + e.Message);
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
                throw new ErroConexao("A operação de consultar objetivo não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroPesquisar("Erro ao tentar consultar Objetivo-> " + e.Message);
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
                throw new ErroConexao("A operação de consultar objetivo não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroPesquisar("Erro ao tentar consultar Objetivo-> " + e.Message);
            }
        }
    }
}
