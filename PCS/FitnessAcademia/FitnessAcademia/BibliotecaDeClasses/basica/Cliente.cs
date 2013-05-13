using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.basica
{
    public class Cliente
    {
        public const int TO_STRING_DEFAULT = 0;
        public const int TO_STRING_FULL = 1;
        public const int TO_STRING_NOME = 2;
        public const int TO_STRING_NOME_CPF = 3;

        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private string rg;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        private DateTime dataNasc;

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }
        private string logradouro;

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }
        private string numLog;

        public string NumLog
        {
            get { return numLog; }
            set { numLog = value; }
        }
        private string complemento;

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        private string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        private string uf;

        public string Uf
        {
            get { return uf.ToUpper(); }
            set { uf = value.ToUpper(); }
        }
        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        private string estCivil;

        public string EstCivil
        {
            get { return estCivil.ToUpper(); }
            set { estCivil = value.ToUpper(); }
        }
        private string sexo;

        public string Sexo
        {
            get { return sexo.ToUpper(); }
            set { sexo = value.ToUpper(); }
        }
        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        private string celular;

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private DateTime valExameMedico;

        public DateTime ValExameMedico
        {
            get { return valExameMedico; }
            set { valExameMedico = value; }
        }

        public Cliente()
        {
            this.toStringBehavior = TO_STRING_DEFAULT;
        }

        public Cliente(int codigo)
        {
            this.codigo = codigo;
            this.toStringBehavior = TO_STRING_DEFAULT;
        }

        public Cliente(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.toStringBehavior = TO_STRING_DEFAULT;
        }

        public Cliente(int codigo, string nome, string cpf, int toStringBehavior)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cpf = cpf;
            this.toStringBehavior = toStringBehavior;
        }

        public Cliente(int codigo, string nome, int toStringBehavior)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.toStringBehavior = toStringBehavior;
        }

        public Cliente(string nome)
        {
            this.nome = nome;
            this.toStringBehavior = TO_STRING_DEFAULT;
        }

        public Cliente(string cpf, string rg)
            :this()
        {
            this.cpf = cpf;
            this.rg = rg;
        }

        private int toStringBehavior;

        public int ToStringBehavior
        {
            get { return toStringBehavior; }
            set { toStringBehavior = value; }
        }

        public override string ToString()
        {
            switch (toStringBehavior)
            {
                case TO_STRING_NOME:
                    return this.nome;
                    //break;
                case TO_STRING_NOME_CPF:
                    return this.nome + ", CPF " + Cpf;
                //break;
                case TO_STRING_FULL:
                    return "Código " + Codigo.ToString() + " " + Nome + " CPF " + Cpf + " RG " + Rg
                        + " Data nasc. " + DataNasc.ToString() + " Endereço " + Logradouro + " - "
                        + NumLog + " - " + Complemento + " - " + Bairro + " - " + Cidade
                        + " - " + Uf + " - " + Cep + " F: " + Telefone + " / " + Celular
                        + " e-mail " + Email + " Val exame médido: " + ValExameMedico.ToString();
                    //break;
            }
            return Codigo + " - " + Nome + ", cpf " + Cpf;
        }
            
    }
}
