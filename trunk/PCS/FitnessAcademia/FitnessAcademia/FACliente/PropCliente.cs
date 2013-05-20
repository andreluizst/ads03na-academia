using System;
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
    public partial class PropCliente : Form, IDialogo<Cliente>
    {
        private GuiBehavior<Cliente> guiBehavior;
        private Cliente obj;
        private FACliente.localhost.Service1 srvGeral;
        private bool isInsert = false;
        private string nome = "Cliente";
        public string Nome
        {
            get { return nome; }
        }

        public string Titulo
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public void setObject(Cliente obj)
        {
            this.obj = obj;
        }

        public PropCliente()
        {
            InitializeComponent();
            srvGeral = new Service1();
            this.Text = "NOVO " + this.nome;
            guiBehavior = new GuiBehavior<Cliente>(srvGeral, this);
            isInsert = true;
        }

        public PropCliente(Cliente obj)
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
            txtbxNome.Text = obj.Nome;
            //continua...
            
        }

        private void preencherObj()
        {
            if (isInsert)
                obj = new Cliente();
            else
                obj.Codigo = Convert.ToInt32(txtbxCodigo.Text);
            obj.Nome = txtbxNome.Text;
            //continua...
        }

        public void salvar()
        {
            preencherObj();
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

        private void PropCliente_KeyDown(object sender, KeyEventArgs e)
        {
            guiBehavior.FrmDlg_KeyDown(sender, e);
        }

    }
}
