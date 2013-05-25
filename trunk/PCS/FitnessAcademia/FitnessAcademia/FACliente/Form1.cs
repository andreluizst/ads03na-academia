using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FACliente
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void miManterExercício_Click(object sender, EventArgs e)
        {
            frmExercicio frm = new frmExercicio();
            showMdiChildren(frm, (ToolStripMenuItem)sender);
        }

        private void miSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void activeNextWindow()
        {
            if (this.MdiChildren.Length > 1)
            {
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    if (this.MdiChildren[i] == this.ActiveMdiChild)
                    {
                        if ((this.MdiChildren.Length - 1) > i)
                        {
                            this.MdiChildren[i + 1].Activate();
                            break;
                        }
                        if ((this.MdiChildren.Length - 1) == i)
                        {
                            this.MdiChildren[0].Activate();
                            break;
                        }
                    }
                }
            }
        }

        
        private void miJanela_Click(object sender, EventArgs e)
        {
            activeNextWindow();
        }

        private void miFecharJanelaAtual_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            if (frm != null)
                frm.Close();
        }

        private void miPesquisar_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                ((IActionsGui)this.ActiveMdiChild).pesquisar();
            }
        }

        private void miFecharPesquisa_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                ((IActionsGui)this.ActiveMdiChild).fecharPesquisa();
            }
        }

        private void editarToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            miPesquisar.Enabled = this.MdiChildren.Length > 0 ? ((IActionsGui)this.ActiveMdiChild).pesquisarExiste() : false;
            miFecharPesquisa.Enabled = miPesquisar.Enabled;
            miNovo.Enabled = this.MdiChildren.Length > 0 ? true : false;
            miAlterar.Enabled = miNovo.Enabled;
            miExcluir.Enabled = miAlterar.Enabled;
            if (this.MdiChildren.Length > 0)
                ((IActionsGui)this.ActiveMdiChild).updateActions();
        }

        private void miManterObjetivo_Click(object sender, EventArgs e)
        {
            FrmObjetivo frm = new FrmObjetivo();
            showMdiChildren(frm, (ToolStripMenuItem)sender);
        }

        private void showMdiChildren(Form frm, ToolStripMenuItem senderMenu)
        {
            frm.MdiParent = this;
            frm.Show();
            ((IActionsGui)frm).setOpenMenuShell(senderMenu);
            ((IActionsGui)frm).setActionsMenuShell(miNovo, miAlterar, miExcluir);
            senderMenu.Enabled = false;
        }

        private void miNovo_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                ((IActionsGui)this.ActiveMdiChild).novo();
            }
        }

        private void miAlterar_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                ((IActionsGui)this.ActiveMdiChild).alterar();
            }
        }

        private void miExcluir_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                ((IActionsGui)this.ActiveMdiChild).excluir();
            }
        }

        private void miManterCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            showMdiChildren(frm, (ToolStripMenuItem)sender);
        }

        private void miPlano_Click(object sender, EventArgs e)
        {
            FrmPlanoTreinamento frm = new FrmPlanoTreinamento();
            showMdiChildren(frm, (ToolStripMenuItem)sender);
        }

    }
}
