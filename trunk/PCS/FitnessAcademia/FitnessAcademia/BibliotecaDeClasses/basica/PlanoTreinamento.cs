﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.basica
{
    public class PlanoTreinamento
    {
        public const int TO_STRING_DEFAULT = 0;
        public const int TO_STRING_COMPACT = 1;

        private int numPlano;

        public int Numplano
        {
            get { return numPlano; }
            set { numPlano = value; }
        }
        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public PlanoTreinamento()
        {
            toStringBehavior = PlanoTreinamento.TO_STRING_DEFAULT;
            exercicios = new List<ExercicioDoPlano>();
        }

        public PlanoTreinamento(int numPlano, DateTime data):this()
        {
            this.numPlano = numPlano;
            this.data = data;
        }

        public PlanoTreinamento(int numPlano, DateTime data, Objetivo objetivo, Cliente cliente)
            :this()
        {
            this.numPlano = numPlano;
            this.data = data;
            this.clienteDoPlano = cliente;
            this.objetivoDoPlano = objetivo;
        }

        private Objetivo objetivoDoPlano;

        public Objetivo ObjetivoDoPlano
        {
            get { return objetivoDoPlano; }
            set { objetivoDoPlano = value; }
        }

        private Cliente clienteDoPlano;

        public Cliente ClienteDoPlano
        {
            get { return clienteDoPlano; }
            set { clienteDoPlano = value; }
        }

        private List<ExercicioDoPlano> exercicios;

        public List<ExercicioDoPlano> Exercicios
        {
            get { return exercicios; }
            set { exercicios = value; }
        }

        private int toStringBehavior;

        public int ToStringBehavior
        {
            get { return toStringBehavior; }
            set { toStringBehavior = value; }
        }

        public override string ToString()
        {
            return Numplano + " " + String.Format("dd/MM/yyyy", Data) + " - " + clienteDoPlano.ToString();
        }

    }
}
