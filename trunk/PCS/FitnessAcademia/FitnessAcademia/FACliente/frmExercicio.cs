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
    public partial class frmExercicio : Form, IActionsGui
    {
        private Service1 srv1;
        private List<Exercicio> lista;
        private GuiBehavior<Exercicio> guiBehavior;
        private ToolStripMenuItem miShellOpen;
        private ToolStripMenuItem miShellNovo;
        private ToolStripMenuItem miShellAlterar;
        private ToolStripMenuItem miShellExcluir;

        public frmExercicio()
        {
            InitializeComponent();
            srv1 = new Service1();
            dataGridView.AutoGenerateColumns = true;
            lista = new List<Exercicio>();
            guiBehavior = new GuiBehavior<Exercicio>(srv1, this);
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
            guiBehavior.Novo(new PropExercicio());
        }

        public void alterar()
        {
            if (lista.Count > 0)
            {
                Exercicio exercicio = lista[dataGridView.CurrentRow.Index];
                guiBehavior.Alterar(new PropExercicio(exercicio), exercicio);
            }
        }

        public void excluir()
        {
            if (lista.Count > 0)
                guiBehavior.Excluir(lista[dataGridView.CurrentRow.Index]);
        }

        public void pesquisar()
        {
            Exercicio[] exercicios;
            Exercicio exer = new Exercicio();
            exer.Codigo = 0;
            exer.Descricao = txtbxDescricao.Text;
            exercicios = srv1.consultarExercicio(exer);
            UnBindingList();
            lista.Clear();
            foreach (Exercicio item in exercicios)
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

        /*public string getActivationName()
        {
            return activationName;
        }*/

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            pesquisar();
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

        private void frmExercicio_KeyUp(object sender, KeyEventArgs e)
        {
            guiBehavior.NovoAlterarExcluir_KeyUp_NTX(sender, e);
            /*if (e.Modifiers == Keys.Alt)
            {
                if (e.KeyCode == Keys.N)
                    novo();
                if (e.KeyCode == Keys.T)
                    alterar();
                if (e.KeyCode == Keys.X)
                    excluir();
            }*/
        }

        private void grdExercicios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
                alterar();
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

        private void grdExercicios_SelectionChanged(object sender, EventArgs e)
        {
            updateActions();
        }

        private void frmExercicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (miShellOpen != null)
                miShellOpen.Enabled = true;
        }

        private void frmExercicio_Activated(object sender, EventArgs e)
        {
            updateActions();
        }

        private void frmExercicio_Shown(object sender, EventArgs e)
        {
            updateActions();
        }
    }
}
