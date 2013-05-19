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
    public partial class frmExercicio : Form
    {
        Service1 srv1;
        List<Exercicio> lista;
        public frmExercicio()
        {
            InitializeComponent();
            srv1 = new Service1();
            grdExercicios.AutoGenerateColumns = true;
            lista = new List<Exercicio>();
        }

        private void UnBindingList()
        {
            bindingSource1.DataSource = null;
            grdExercicios.DataSource = null;
        }

        private void BindingList()
        {
            bindingSource1.DataSource = lista;
            grdExercicios.DataSource = bindingSource1;
        }

        private void consultar()
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            PropExercicio propDlg = new PropExercicio();
            if (propDlg.ShowDialog() == DialogResult.OK)
                MessageBox.Show("A operação foi realizada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            PropExercicio propDlg = new PropExercicio(lista[grdExercicios.CurrentRow.Index]);
            if (propDlg.ShowDialog() == DialogResult.OK)
                MessageBox.Show("A operação foi realizada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                srv1.excluirExercicio(lista[grdExercicios.CurrentRow.Index]);
                MessageBox.Show("A operação foi realizada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                string msg;
                try
                {
                    msg = srv1.getLastMsgError();
                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                }
                MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmExercicio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt)
            {
                if (e.KeyCode == Keys.N)
                    btnNovo_Click(btnNovo, e);
                if (e.KeyCode == Keys.A)
                    btnAlterar_Click(btnAlterar, e);
                if (e.KeyCode == Keys.E)
                    btnExcluir_Click(btnExcluir, e);
            }
        }
    }
}
