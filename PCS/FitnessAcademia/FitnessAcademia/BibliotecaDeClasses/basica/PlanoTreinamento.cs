using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.basica
{
    public class PlanoTreinamento
    {
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

        }

        public PlanoTreinamento(int numPlano, DateTime data)
        {
            this.numPlano = numPlano;
            this.data = data;

        }
    }
}
