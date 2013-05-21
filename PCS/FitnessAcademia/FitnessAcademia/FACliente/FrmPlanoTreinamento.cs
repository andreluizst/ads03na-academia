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
    public partial class FrmPlanoTreinamento : Form, IActionsGui
    {
        private FACliente.localhostPlano.Service1 srv1;
        private List<PlanoTreinamento> lista;
        private List<Cliente> lstClientes;
        private List<Objetivo> lstObjetivos;
        //private GuiBehavior<PlanoTreinamento> guiBehavior;
        private ToolStripMenuItem miShellOpen;
        private ToolStripMenuItem miShellNovo;
        private ToolStripMenuItem miShellAlterar;
        private ToolStripMenuItem miShellExcluir;

        public FrmPlanoTreinamento()
        {
            InitializeComponent();
            srv1 = new FACliente.localhostPlano.Service1();
            dataGridView.AutoGenerateColumns = true;
            lista = new List<PlanoTreinamento>();
            lstClientes = new List<Cliente>();
            lstObjetivos = new List<Objetivo>();
            //guiBehavior = new GuiBehavior<PlanoTreinamento>(srv1, this);
        }

        private void preencherListas()
        {
            Cliente[] clientes;
            Objetivo[] objetivos;
            try
            {
                clientes = srv1.listarClientes();
                Cliente c = new Cliente();
                c.Codigo = 0;
                c.Nome = "<Todos>";
                lstClientes.Clear();
                lstClientes.Add(c);
                foreach (Cliente item in clientes)
                {
                    lstClientes.Add(item);
                }
                Objetivo o = new Objetivo();
                o.Codigo = 0;
                lstObjetivos.Clear();
                o.Descricao = "<Todos>";
                lstObjetivos.Add(o);
                objetivos = srv1.listarObjetivos();
                foreach (Objetivo item in objetivos)
                {
                    lstObjetivos.Add(item);
                }
            }
            catch (Exception)
            {
                string msg;
                try
                {
                    msg = srv1.getLastMsgError();
                }
                catch (Exception e)
                {
                    msg = e.Message;
                }
                MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void UnBindingList()
        {
            bindingSource1.DataSource = null;
            dataGridView.DataSource = null;
        }

        private void BindingList()
        {
            bindingSource1.DataSource = lista;
            dataGridView.DataSource = bindingSource1;
            dataGridView.AutoResizeColumns();
        }

        public void pesquisar()
        {
            PlanoTreinamento[] planos;
            PlanoTreinamento obj = new PlanoTreinamento();
            obj.Numplano = 0;
            //obj.ObjetivoDoPlano.Codigo = txtbxDescricao.Text;
            //obj.ClienteDoPlano.Codigo = 
            planos = srv1.consultarPlanoTreinamento(obj, DateTime.Now);
            UnBindingList();
            lista.Clear();
            foreach (PlanoTreinamento item in planos)
            {
                lista.Add(item);
            }
            BindingList();
            if (lista.Count == 0)
                MessageBox.Show("A pesquisa não encontrou registros.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        public bool pesquisarExiste()
        {
            return true;
        }

        public void fecharPesquisa()
        {
            lista.Clear();
            UnBindingList();
        }

        public void setOpenMenuShell(ToolStripMenuItem menuItem)
        {
            miShellOpen = menuItem;
            miShellOpen.Enabled = false;
        }

        public void setActionsMenuShell(ToolStripMenuItem mnNovo,
            ToolStripMenuItem mnAlterar, ToolStripMenuItem mnExcluir)
        {
            miShellNovo = mnNovo;
            miShellAlterar = mnAlterar;
            miShellExcluir = mnExcluir;
        }

        private void updateActions()
        {
            btnAlterar.Enabled = dataGridView.RowCount > 0 ? true : false;
            btnExcluir.Enabled = btnAlterar.Enabled;
            if (miShellAlterar != null)
                miShellAlterar.Enabled = btnAlterar.Enabled;
            if (miShellExcluir != null)
                miShellExcluir.Enabled = btnExcluir.Enabled;
        }

        private void FrmPlanoTreinamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (miShellOpen != null)
                miShellOpen.Enabled = true;
        }

        private void FrmPlanoTreinamento_Shown(object sender, EventArgs e)
        {
            updateActions();
        }

        private void FrmPlanoTreinamento_Activated(object sender, EventArgs e)
        {
            updateActions();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            updateActions();
        }

        public void novo()
        {

        }

        public void alterar()
        {

        }

        public void excluir()
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluir();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

    }
}
