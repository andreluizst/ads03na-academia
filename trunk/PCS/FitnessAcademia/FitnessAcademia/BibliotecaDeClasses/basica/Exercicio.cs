using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.basica
{
    public class Exercicio
    {
        public const int TO_STRING_DEFAULT = 0;
        public const int TO_STRING_DESCRICAO = 1;

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

        private int toStringBehavior;

        public int ToStringBehavior
        {
            get { return toStringBehavior; }
            set { toStringBehavior = value; }
        }

        public Exercicio()
        {
            this.toStringBehavior = TO_STRING_DEFAULT;
        }

        public Exercicio(int codigo, string descricao)
            :this()
        {
            this.codigo = codigo;
            this.descricao = descricao;
        }

        public Exercicio(int codigo, string descricao, int toStringBehavior)
            :this()
        {
            this.codigo = codigo;
            this.descricao = descricao;
        }

        public override string ToString()
        {
            if (toStringBehavior == TO_STRING_DESCRICAO)
                return this.descricao;
            return Codigo + " " + Descricao;
        }


    }
}
