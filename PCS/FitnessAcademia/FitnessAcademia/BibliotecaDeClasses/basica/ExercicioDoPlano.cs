using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.basica
{
    public class ExercicioDoPlano
    {
        private int seq;

        public int Seq
        {
            get { return seq; }
            set { seq = value; }
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
        public ExercicioDoPlano(int seq, int numRepeticoes, double peso)
        {
            this.seq = seq;
            this.numRepeticoes = numRepeticoes;
            this.peso = peso;
        }
    }
}
