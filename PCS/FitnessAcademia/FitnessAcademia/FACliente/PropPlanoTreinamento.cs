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
            lstClientes.AddRange(clientes);
            if (lstClientes[0].Nome.ToLower() == "<todos>")
                lstClientes.RemoveAt(0);
            lstObjetivos.AddRange(objetivos);
            if (lstObjetivos[0].Descricao.ToLower() == "<todos>")
                lstObjetivos.RemoveAt(0);
        }

        private void preencherCampos()
        {
            txtbxNumPlano.Text = obj.Numplano.ToString();
            dtpkData.Value = obj.Data;
            for (int i =0; i < lstClientes.Count; i++)
            {
                if (lstClientes[i].Codigo == obj.ClienteDoPlano.Codigo)
                {
                    cbxCliente.SelectedItem = i;
                    break;
                }
            }
            for (int i = 0; i < lstObjetivos.Count; i++)
            {
                if (lstObjetivos[i].Codigo == obj.ObjetivoDoPlano.Codigo)
                {
                    cbxObetivo.SelectedIndex = i;
                    break;
                }
            }
            bdsExerciciosDoPlano.DataSource = obj.Exercicios;
            dataGridView.DataSource = bdsExerciciosDoPlano;
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

        private void updateActions()
        {
            btnAlterar.Enabled = dataGridView.RowCount > 0 ? true : false;
            btnExcluir.Enabled = btnAlterar.Enabled;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            updateActions();
        }
    }
}
