using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FACliente.localhostPlano;

namespace FACliente
{
    public partial class PropPlanoTreinamento : Form
    {
        private PlanoTreinamento obj;
        private FACliente.localhostPlano.Service1 srvPlano;
        private bool isInsert = false;
        private string nome = "Plano de Treinamento";
        private List<Cliente> lstClientes;
        private List<Objetivo> lstObjetivos;


        public string Nome
        {
            get { return nome; }
        }

        public PropPlanoTreinamento()
        {
            InitializeComponent();
            this.Text = "NOVO " + this.nome;
            isInsert = true;
            srvPlano = new Service1();
            lstClientes = new List<Cliente>();
            lstObjetivos = new List<Objetivo>();
        }

        public PropPlanoTreinamento(PlanoTreinamento obj)
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

        public PropPlanoTreinamento(PlanoTreinamento obj, List<Cliente> clientes, List<Objetivo> objetivos)
            :this(obj)
        {
            lstClientes = clientes;
            lstObjetivos = objetivos;
        }

        private void preencherCampos()
        {
            txtbxNumPlano.Text = obj.Numplano.ToString();
            dtpkData.Value = obj.Data;
        }

        private void preencherObj()
        {
            if (isInsert)
                obj = new PlanoTreinamento();
            else
                obj.Numplano = Convert.ToInt32(txtbxNumPlano.Text);
            obj.Data = dtpkData.Value;
        }

        private void salvar()
        {
            try
            {
                srvPlano.salvarPlanoTreinamento(obj);
            }
            catch (Exception)
            {
                string msg;
                try
                {
                    msg = srvPlano.getLastMsgError();
                }
                catch (Exception e)
                {
                    msg = e.Message;
                }
                MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }
        }

        private void PropPlanoTreinamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                salvar();
            }
            else
                if (e.KeyCode == Keys.Escape)
                    DialogResult = DialogResult.Cancel;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }
    }
}
