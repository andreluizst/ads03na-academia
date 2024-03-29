﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaDeClasses.basica;
using BibliotecaDeClasses.dao;
using BibliotecaDeClasses.erro;

namespace BibliotecaDeClasses.regra
{
    public class ControladorExercicio
    {
        private IRepositorioExercicio rpE;

        public ControladorExercicio()
        {
            rpE = new RepositorioExercicio();
        }

        public bool existe(Exercicio exer)
        {
            if (exer.Codigo <= 0)
                return false;
            Exercicio e = rpE.pegar(exer.Codigo);
            if (e != null)
                return true;
            return false;
        }

        public void validarDados(Exercicio exer)
        {
            string msg = "Erro de validação-> ";
            string msgCampoObrigatorio = "Campos obrigatório não preenchido-> ";
            if ((exer.Descricao == null) || (exer.Descricao.Length == 0))
                throw new ErroValidacao(msgCampoObrigatorio + "descrição.");
            if (exer.Descricao.Length > 100)
                throw new ErroValidacao(msg + "A descrição do exercício não deve ter mais de 100 caracteres!");
        }

        public void incluir(Exercicio exer)
        {
            try
            {
                rpE.incluir(exer);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("A operação de incluir exercício não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroInclusao("Erro ao tentar incluir exercício-> " + e.Message);
            }
        }

        public void alterar(Exercicio exer)
        {
            try
            {
                rpE.alterar(exer);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("A operação de alterar exercício não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroAlteracao("Erro ao tentar alterar exercício-> " + e.Message);
            }
        }

        public void excluir(Exercicio exer)
        {
            try
            {
                rpE.excluir(exer);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("A operação de excluir exercício não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroExclusao("Erro ao tentar excluir exercício-> " + e.Message);
            }
        }

        public List<Exercicio> consultar(Exercicio exer)
        {
            return consultar(exer, Exercicio.TO_STRING_DEFAULT);
        }

        public List<Exercicio> consultar(Exercicio exer, int toStringBehavior)
        {
            try
            {
                return rpE.consultar(exer, toStringBehavior);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("A operação de consultar exercício não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroPesquisar("Erro ao tentar consultar exercício-> " + e.Message);
            }
        }

        public Exercicio pegar(int codigo)
        {
            return pegar(codigo, Exercicio.TO_STRING_DEFAULT);
        }

        public Exercicio pegar(int codigo, int toStringBehavior)
        {
            try
            {
                return rpE.pegar(codigo, toStringBehavior);
            }
            catch (ErroConexao)
            {
                throw new ErroConexao("A operação de consultar exercício não está disponível no momento!");
            }
            catch (Exception e)
            {
                throw new ErroPesquisar("Erro ao tentar consultar exercício-> " + e.Message);
            }
        }

    }
}
