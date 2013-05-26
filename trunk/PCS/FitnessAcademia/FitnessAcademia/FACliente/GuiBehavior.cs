using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FACliente.localhost;

namespace FACliente
{
    /*
     * Classe usada pelas janelas de manuteção de dados do servidor geral.
     * Essa classe é responsável pelo comportamento padrão de inclusão, alterão e exclusão
     * das classes básicas do servidor geral
    */
    public class GuiBehavior<T>
    {
        /* Os delegates são usados para que os métodos e inclusão, alteração e exclusão possam ter seu comportamento
         * alterado sem a necessidade de alterar a classe, adicionando código ou substituindo o existente.
        */
        public delegate void EventEditDelegate(Form frm, T obj);
        public delegate void EventNewDelegate(Form frm);
        public delegate void EventObjDelegate(T obj);
        public delegate List<T> EventConsultar(T obj);

        #region atributos e propriedades
        private object objeto;
        private Service1 servidor;
        public Service1 Servidor
        {
            get { return servidor; }
            set { servidor = value; }
        }

        private Form frmProprietario;
        public Form FrmProprietario
        {
            get { return frmProprietario; }
            set { frmProprietario = value; }
        }

        private EventObjDelegate salvar;
        public EventObjDelegate Salvar
        {
            get { return salvar; }
            set { salvar = value; }
        }

        private EventEditDelegate alterar;
        public EventEditDelegate Alterar
        {
            get { return alterar; }
            set { alterar = value; }
        }

        private EventNewDelegate novo;
        public EventNewDelegate Novo
        {
            get { return novo; }
            set { novo = value; }
        }

        private EventObjDelegate excluir;
        public EventObjDelegate Excluir
        {
            get { return excluir; }
            set { excluir = value; }
        }
        #endregion

        #region contrutores
        public GuiBehavior()
        {
            salvar = salvarDefaultEx;
            novo = novoDefault;
            alterar = alterarDefault;
            excluir = excluirDefault;
        }

        public GuiBehavior(Service1 servidor)
            :this()
        {
            this.servidor = servidor;
        }

        public GuiBehavior(Service1 servidor, Form frmProprietario)
            : this(servidor)
        {
            this.frmProprietario = frmProprietario;
        }
        #endregion

        private void salvarDefaultEx(T obj)
        {
            this.objeto = obj;
            salvarDefault();
        }

        private void salvarNoServidor()
        {
            if (objeto is Exercicio)
                Servidor.salvarExercicio((Exercicio)objeto);
            if (objeto is Objetivo)
                Servidor.salvarObjetivo((Objetivo)objeto);
            if (objeto is Cliente)
                Servidor.salvarCliente((Cliente)objeto);
        }

        private void salvarDefault()
        {
            try
            {
                salvarNoServidor();
            }
            catch (Exception e)
            {
                string msg;
                msg = FiltrarMsgErroWebSrv.execute(e.Message);
                MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmProprietario.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }
            frmProprietario.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void novoDefault(Form frm)
        {
            frmProprietario = frm;
            if (frmProprietario.ShowDialog() == DialogResult.OK)
                MessageBox.Show("A operação foi realizada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void alterarDefault(Form frm, T obj)
        {
            frmProprietario = frm;
            this.objeto = obj;
            if (frmProprietario.ShowDialog() == DialogResult.OK)
                MessageBox.Show("A operação foi realizada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void excluirDefault(T obj)
        {
            this.objeto = obj;
            try
            {
                excluirDefault();
                MessageBox.Show("A operação foi realizada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(FiltrarMsgErroWebSrv.execute(e.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void excluirDefault()
        {
            string msg = "Confirma a exclusão do item selecionado?";
            if (MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(objeto is Exercicio)
                    Servidor.excluirExercicio((Exercicio)objeto);
                if (objeto is Objetivo)
                    Servidor.excluirObjetivo((Objetivo)objeto);
                if (objeto is Cliente)
                    Servidor.excluirCliente((Cliente)objeto);
            }

        }

        public void FrmDlg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((IDialogo<T>)frmProprietario).salvar();
            }
            else
                if (e.KeyCode == Keys.Escape)
                    frmProprietario.DialogResult = DialogResult.Cancel;
        }

        public void FrmDlg_Cancelar()
        {
            frmProprietario.DialogResult = DialogResult.Cancel;
        }

        public void NovoAlterarExcluir_KeyUp_NTX(object sender, KeyEventArgs e)
        {
            if (frmProprietario is IActionsGui)
            {
                if (e.Modifiers == Keys.Alt)
                {
                    if (e.KeyCode == Keys.N)
                        ((IActionsGui)frmProprietario).novo();
                    if (e.KeyCode == Keys.T)
                        ((IActionsGui)frmProprietario).alterar();
                    if (e.KeyCode == Keys.X)
                        ((IActionsGui)frmProprietario).excluir();
                }
            }
        }


    }
}
