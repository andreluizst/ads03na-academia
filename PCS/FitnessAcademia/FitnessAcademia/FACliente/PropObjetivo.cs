﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FACliente.localhost;

namespace FACliente
{
    public partial class PropObjetivo : Form, IDialogo<Objetivo>
    {

        private GuiBehavior<Objetivo> guiBehavior;
        private Objetivo obj;
        private FACliente.localhost.Service1 srvGeral;
        private bool isInsert = false;
        private string nome = "Objetivo";
        public string Nome
        {
            get { return nome; }
        }

        public string Titulo
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public void setObject(Objetivo obj)
        {
            this.obj = obj;
        }

        public PropObjetivo()
        {
            InitializeComponent();
            srvGeral = new Service1();
            this.Text = "NOVO " + this.nome;
            guiBehavior = new GuiBehavior<Objetivo>(srvGeral, this);
            isInsert = true;
        }

        public PropObjetivo(Objetivo obj)
            :this()
        {
            if (obj != null)
            {
                this.obj = obj;
                this.Text = "Alterar " + this.nome;
                preencherCampos();
                isInsert = false;
            }
        }

        private void preencherCampos()
        {
            txtbxCodigo.Text = obj.Codigo.ToString();
            txtbxDescricao.Text = obj.Descricao;
        }

        public void salvar()
        {
            if (isInsert)
                obj = new Objetivo();
            else
                obj.Codigo = Convert.ToInt32(txtbxCodigo.Text);
            obj.Descricao = txtbxDescricao.Text;
            guiBehavior.Salvar(obj);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            guiBehavior.FrmDlg_Cancelar();
        }

        private void PropObjetivo_KeyDown(object sender, KeyEventArgs e)
        {
            guiBehavior.FrmDlg_KeyDown(sender, e);
        }



    }
}
