using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.basica
{
    public class ExercicioDoPlano
    {
        private int numPlano;

        public int NumPlano
        {
            get { return numPlano; }
            set { numPlano = value; }
        }

        private int seq;

        public int Seq
        {
            get { return seq; }
            set { seq = value; }
        }

        private Exercicio exercicio;

        public Exercicio Exercicio
        {
            get { return exercicio; }
            set { exercicio = value; }
        }

        private int series;

        public int Series
        {
            get { return series; }
            set { series = value; }
        }

        private int numRepeticoes;

        public int NumRepeticoes
        {
            get { return numRepeticoes; }
            set { numRepeticoes = value; }
        }
        private double peso;

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public ExercicioDoPlano()
        {
        }

        public ExercicioDoPlano(int seq, Exercicio exercicio, int series, int numRepeticoes, double peso)
        {
            this.seq = seq;
            this.exercicio = exercicio;
            this.series = series;
            this.numRepeticoes = numRepeticoes;
            this.peso = peso;
        }
    }
}
