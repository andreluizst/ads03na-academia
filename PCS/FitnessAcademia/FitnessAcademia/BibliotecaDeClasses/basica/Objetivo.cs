﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.basica
{
    public class Objetivo
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
        public void setToStringBehavior(int toStringBehavior)
        {
            this.toStringBehavior = toStringBehavior;
        }
        public int getToStringBehavior()
        {
            return this.toStringBehavior;
        }
        /*public int ToStringBehavior
        {
            get { return toStringBehavior; }
            set { toStringBehavior = value; }
        }*/

        public Objetivo()
        {
            this.toStringBehavior = TO_STRING_DEFAULT;
        }

        public Objetivo(int codigo, string descricao)
            :this()
        {
            this.codigo = codigo;
            this.descricao = descricao;
        }

        public Objetivo(int codigo, string descricao, int toStringBehavior)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.toStringBehavior = toStringBehavior;
        }

        public override string ToString()
        {
            if (this.toStringBehavior == TO_STRING_DESCRICAO)
                return Descricao;
            return Codigo + " " + Descricao;
        }
    }
}
