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
        private GuiBehavior<Exercicio> gbExercicio;
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
            gbExercicio = new GuiBehavior<Exercicio>();
            isInsert = true;
            gbExercicio.FrmDlg = this;
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
            if (isInsert == false)
                exercicio.Codigo = Convert.ToInt32(txtbxCodigo);
            exercicio.Descricao = txtbxDescricao.Text;
            gbExercicio.Salvar(exercicio);
            /*
            try
            {
                exercicio.Codigo = Convert.ToInt32(txtbxCodigo);
                exercicio.Descricao = txtbxDescricao.Text;
                srvGeral.salvarExercicio(exercicio);
            }
            catch (Exception)
            {
                string msg;
                try
                {
                    msg = srvGeral.getLastMsgError();
                }
                catch (Exception e)
                {
                    msg = e.Message;
                }
                MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
             */
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void PropExercicio_KeyDown(object sender, KeyEventArgs e)
        {
            gbExercicio.FrmDlg_KeyDown(sender, e);
            /*if (e.KeyCode == Keys.Enter)
            {
                salvar();
            }
            else
                if (e.KeyCode == Keys.Escape)
                    this.DialogResult = DialogResult.Cancel;*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbExercicio.FrmDlg_Cancelar();
        }


    }
}
