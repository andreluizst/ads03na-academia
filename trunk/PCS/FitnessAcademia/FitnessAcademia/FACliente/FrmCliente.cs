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
    public partial class FrmCliente : Form, IActionsGui
    {
        private Service1 srv1;
        private List<Cliente> lista;
        private GuiBehavior<Cliente> guiBehavior;
        private ToolStripMenuItem miShellOpen;
        private ToolStripMenuItem miShellNovo;
        private ToolStripMenuItem miShellAlterar;
        private ToolStripMenuItem miShellExcluir;

        public FrmCliente()
        {
            InitializeComponent();
            srv1 = new Service1();
            dataGridView.AutoGenerateColumns = true;
            lista = new List<Cliente>();
            guiBehavior = new GuiBehavior<Cliente>(srv1, this);
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

        public void novo()
        {
            guiBehavior.Novo(new PropCliente());
        }

        public void alterar()
        {
            if (lista.Count > 0)
            {
                Cliente obj = lista[dataGridView.CurrentRow.Index];
                guiBehavior.Alterar(new PropCliente(obj), obj);
            }
        }

        public void excluir()
        {
            if (lista.Count > 0)
                guiBehavior.Excluir(lista[dataGridView.CurrentRow.Index]);
        }

        public void pesquisar()
        {
            Cliente[] clientes;
            Cliente obj = new Cliente();
            obj.Codigo = 0;
            obj.Nome = txtbxDescricao.Text;
            clientes = srv1.consultarCliente(obj);
            UnBindingList();
            lista.Clear();
            foreach (Cliente item in clientes)
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

        private void FrmCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (miShellOpen != null)
                miShellOpen.Enabled = true;
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
                alterar();
        }

        private void FrmCliente_Shown(object sender, EventArgs e)
        {
            updateActions();
        }

        private void FrmCliente_Activated(object sender, EventArgs e)
        {
            updateActions();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            updateActions();
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
