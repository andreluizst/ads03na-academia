using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FACliente.localhost;

namespace FACliente
{
    public class GuiBehavior<T>
    {
        public delegate void EventEditDelegate(Form frm, T obj);
        public delegate void EventNewDelegate(Form frm);
        public delegate void EventObjDelegate(T obj);
        public delegate List<T> EventConsultar(T obj);

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

        private EventConsultar consultar;
        public EventConsultar Consultar
        {
            get { return consultar; }
            set { consultar = value; }
        }

        /*public event EventNewDelegate novo;
        //public event EventObjDelegate salvar;
        public event EventEditDelegate alterar;
        public event EventObjDelegate excluir;
        public event EventConsultar consultar;*/

        public GuiBehavior()
        {
            salvar = salvarDefaultEx;
            novo = novoDefault;
            alterar = alterarDefault;
            excluir = excluirDefault;
            consultar = consultarDefault;
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
            /*
            if (objeto is PlanoTreinamento)
                Servidor.salvarPlanoTreinamento((PlanoTreinamento)objeto); 
             */
        }

        private void salvarDefault()
        {
            try
            {
                salvarNoServidor();
            }
            catch (Exception)
            {
                string msg;
                try
                {
                    msg = Servidor.getLastMsgError();
                }
                catch (Exception e)
                {
                    msg = e.Message;
                }
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
            catch (Exception)
            {
                string msg;
                try
                {
                    msg = Servidor.getLastMsgError();
                }
                catch (Exception e)
                {
                    msg = e.Message;
                }
                MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                /*if (objeto is PlanoTreinamento)
                    Servidor.excluirPlanoTreinamento((PlanoTreinamento)objeto);*/
            }

        }

        private List<T> consultarDefault(T obj)
        {
            List<T> lista = new List<T>();
            this.objeto = obj;
           /* if (objeto is Exercicio)
            {
                T[] exercicios;
                
                exercicios = servidor.consultarExercicio((Exercicio)objeto);
                foreach (T item in exercicios)
                {
                    lista.Add(item);
                }
            }*/
            return lista;
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
