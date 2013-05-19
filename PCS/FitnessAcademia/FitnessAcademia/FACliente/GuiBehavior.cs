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

        private Form frmDlg;
        public Form FrmDlg
        {
            get { return frmDlg; }
            set { frmDlg = value; }
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

        public GuiBehavior(Service1 servidor, Form frmDlg)
            : this(servidor)
        {
            this.frmDlg = frmDlg;
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
                frmDlg.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }
            frmDlg.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void novoDefault(Form frm)
        {
            frmDlg = frm;
            //frmDlg.Text = "NOVO";
            //if (frmDlg is IDialogo<T>)
              //  FrmDlg.Text += " " + ((IDialogo<T>)FrmDlg).Nome;
            if (FrmDlg.ShowDialog() == DialogResult.OK)
                MessageBox.Show("A operação foi realizada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void alterarDefault(Form frm, T obj)
        {
            frmDlg = frm;
            //frmDlg.Text = "Alterar";

            this.objeto = obj;


            //if (frmDlg is IDialogo<T>)
              //  FrmDlg.Text += " " + ((IDialogo<T>)FrmDlg).Nome;
            if (FrmDlg.ShowDialog() == DialogResult.OK)
                MessageBox.Show("A operação foi realizada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void excluirDefault(T obj)
        {
            this.objeto = obj;
            try
            {
                excluirDefault();
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
            if (objeto is Exercicio)
                Servidor.excluirExercicio((Exercicio)objeto);
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
                ((IDialogo<T>)FrmDlg).salvar();
            }
            else
                if (e.KeyCode == Keys.Escape)
                    FrmDlg.DialogResult = DialogResult.Cancel;
        }

        public void FrmDlg_Cancelar()
        {
            FrmDlg.DialogResult = DialogResult.Cancel;
        }


    }
}
