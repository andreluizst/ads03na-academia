using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.basica
{
    class Exercicio
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Exercicio()
        {
        }

        public Exercicio(int codigo, string descricao)
        {
            this.codigo = codigo;
            this.descricao = descricao;

        }
    }
}
