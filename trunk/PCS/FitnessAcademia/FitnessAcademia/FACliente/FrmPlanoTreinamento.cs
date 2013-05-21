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
        private FACliente.localhostPlano.Service1 srvPlano;
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
            srvPlano = new FACliente.localhostPlano.Service1();
            dataGridView.AutoGenerateColumns = true;
            lista = new List<PlanoTreinamento>();
            lstClientes = new List<Cliente>();
            lstObjetivos = new List<Objetivo>();
            //guiBehavior = new GuiBehavior<PlanoTreinamento>(srv1, this);
            preencherListas();
        }

        private void preencherListas()
        {
            Cliente[] clientes;
            Objetivo[] objetivos;
            try
            {
                clientes = srvPlano.listarClientes();
                Cliente c = new Cliente();
                c.Codigo = 0;
                c.Nome = "<Todos>";
                cbxClietne.DataSource = null;
                bdsCliente.DataSource = null;
                lstClientes.Clear();
                lstClientes.Add(c);
                foreach (Cliente item in clientes)
                {
                    lstClientes.Add(item);
                }
                bdsCliente.DataSource = lstClientes;
                cbxClietne.DataSource = bdsCliente;
                Objetivo o = new Objetivo();
                o.Codigo = 0;
                lstObjetivos.Clear();
                o.Descricao = "<Todos>";
                lstObjetivos.Add(o);
                cbxObetivo.DataSource = null;
                bdsObjetivo.DataSource = null;
                objetivos = srvPlano.listarObjetivos();
                foreach (Objetivo item in objetivos)
                {
                    lstObjetivos.Add(item);
                }
                bdsObjetivo.DataSource = lstObjetivos;
                cbxObetivo.DataSource = bdsObjetivo;
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
            obj.ObjetivoDoPlano.Codigo = lstObjetivos[cbxObetivo.SelectedIndex].Codigo;
            obj.ClienteDoPlano.Codigo = lstClientes[cbxClietne.SelectedIndex].Codigo;
            obj.Data = Convert.ToDateTime(dtpkInicial.Text);
            planos = srvPlano.consultarPlanoTreinamento(obj, Convert.ToDateTime(dtpkFinal.Text));
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
            PropPlanoTreinamento frm = new PropPlanoTreinamento();
            if (frm.ShowDialog() == DialogResult.OK)
                MessageBox.Show("A operação foi realizada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void alterar()
        {
            PropPlanoTreinamento frm = new PropPlanoTreinamento(lista[dataGridView.CurrentRow.Index]);
            if (frm.ShowDialog() == DialogResult.OK)
                MessageBox.Show("A operação foi realizada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void excluir()
        {
            try
            {
                string msg = "Confirma a exclusão do item selecionado?";
                if (MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    srvPlano.excluirPlanoTreinamento(lista[dataGridView.CurrentRow.Index]);
                    MessageBox.Show("A operação foi realizada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                return;
            }
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
