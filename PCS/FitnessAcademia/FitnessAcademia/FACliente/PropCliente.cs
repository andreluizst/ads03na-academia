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
            : this()
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
            txtbxCpf.Text = obj.Cpf;
            txtbxRg.Text = obj.Rg;
            dtpkDataNasc.Value = obj.DataNasc;
            txtbxLogradouro.Text = obj.Logradouro;
            txtbxNumeroLog.Text = obj.NumLog;
            txtbxComplemento.Text = obj.Complemento;
            txtbxBairro.Text = obj.Bairro;
            txtbxCidade.Text = obj.Cidade;
            txtbxUf.Text = obj.Uf;
            txtbxCep.Text = obj.Cep;
            txtbxEstCivil.Text = obj.EstCivil;
            txtbxSexo.Text = obj.Sexo;
            txtbxTelefone.Text = obj.Telefone;
            txtbxCelular.Text = obj.Celular;
            txtbxEmail.Text = obj.Email;
            dtpkValExaMedico.Value = obj.ValExameMedico;


        }

        private void preencherObj()
        {
            if (isInsert)
                obj = new Cliente();
            else
                obj.Codigo = Convert.ToInt32(txtbxCodigo.Text);
            obj.Nome = txtbxNome.Text;
            obj.Cpf = txtbxCpf.Text;
            obj.Rg = txtbxRg.Text;
            obj.DataNasc = dtpkDataNasc.Value;
            obj.Logradouro = txtbxLogradouro.Text;
            obj.NumLog = txtbxNumeroLog.Text;
            obj.Complemento = txtbxComplemento.Text;
            obj.Bairro = txtbxBairro.Text;
            obj.Cidade = txtbxCidade.Text;
            obj.Uf = txtbxUf.Text;
            obj.Cep = txtbxCep.Text;
            obj.EstCivil = txtbxEstCivil.Text;
            obj.Sexo = txtbxSexo.Text;
            obj.Telefone = txtbxTelefone.Text;
            obj.Celular = txtbxCelular.Text;
            obj.Email = txtbxEmail.Text;
            obj.ValExameMedico = dtpkValExaMedico.Value;

                        
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
