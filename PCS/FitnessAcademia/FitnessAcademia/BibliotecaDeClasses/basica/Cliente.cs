﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses.basica
{
    public class Cliente
    {
        public const int TO_STRING_DEFAULT = 0;
        public const int TO_STRING_FULL = 1;
        public const int TO_STRING_NAME = 2;

        private int codCli;

        public int CodCli
        {
            get { return codCli; }
            set { codCli = value; }
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
            get { return uf; }
            set { uf = value; }
        }
        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        private char estCivil;

        public char EstCivil
        {
            get { return estCivil; }
            set { estCivil = value; }
        }
        private char sexo;

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
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

        public Cliente(int codCli)
        {
            this.codCli = codCli;
            this.toStringBehavior = TO_STRING_DEFAULT;
        }

        public Cliente(int codCli, string nome)
        {
            this.codCli = codCli;
            this.nome = nome;
        }

        public Cliente(string nome)
        {
            this.nome = nome;
        }

        public Cliente(string cpf, string rg)
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
                case TO_STRING_NAME:
                    return this.nome;
                    //break;
                case TO_STRING_FULL:
                    return "Código " + CodCli.ToString() + " " + Nome + " CPF " + Cpf + " RG " + Rg
                        + " Data nasc. " + DataNasc.ToString() + " Endereço " + Logradouro + " - "
                        + NumLog + " - " + Complemento + " - " + Bairro + " - " + Cidade
                        + " - " + Uf + " - " + Cep + " F: " + Telefone + " / " + Celular
                        + " e-mail " + Email + " Val exame médido: " + ValExameMedico.ToString();
                    //break;
            }
            return CodCli + " " + Nome;
        }
            
    }
}