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
    public partial class PropExercicio : Form, IDialogo<Exercicio>
    {
        private GuiBehavior<Exercicio> guiBehavior;
        private Exercicio exercicio;
        private FACliente.localhost.Service1 srvGeral;
        private bool isInsert = false;
        private string nome = "Exercício";
        public string Nome
        {
            get { return nome; }
        }

        public string Titulo
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public void setObject(Exercicio obj)
        {
            exercicio = obj;
        }

        public PropExercicio()
        {
            InitializeComponent();
            srvGeral = new Service1();
            this.Text = "NOVO " + this.nome;
            guiBehavior = new GuiBehavior<Exercicio>(srvGeral, this);
            isInsert = true;
        }

        public PropExercicio(Exercicio exercicio)
            :this()
        {
            if (exercicio != null)
            {
                this.exercicio = exercicio;
                this.Text = "Alterar " + this.nome;
                preencherCampos();
                isInsert = false;
            }
        }

        
        private void preencherCampos()
        {
            txtbxCodigo.Text = exercicio.Codigo.ToString();
            txtbxDescricao.Text = exercicio.Descricao;
        }

        public void salvar()
        {
            if (isInsert)
                exercicio = new Exercicio();
            else
                exercicio.Codigo = Convert.ToInt32(txtbxCodigo.Text);
            exercicio.Descricao = txtbxDescricao.Text;
            guiBehavior.Salvar(exercicio);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void PropExercicio_KeyDown(object sender, KeyEventArgs e)
        {
            guiBehavior.FrmDlg_KeyDown(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            guiBehavior.FrmDlg_Cancelar();
        }


    }
}
