using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FACliente.localhostSrvPlano;

namespace FACliente
{
    public partial class PropPlanoTreinamento : Form
    {
        private PlanoTreinamento obj;
        private Service1 srvPlano;
        private bool isInsert = false;
        private string nome = "Plano de Treinamento";
        private List<ComboBoxItemEx> lstClientes;
        private List<ComboBoxItemEx> lstObjetivos;
        private List<ExercicioDoPlano> lista;


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
            lstClientes = new List<ComboBoxItemEx>();
            lstObjetivos = new List<ComboBoxItemEx>();
            lista = new List<ExercicioDoPlano>();
        }

        public PropPlanoTreinamento(List<ComboBoxItemEx> clientes, List<ComboBoxItemEx> objetivos)
            : this()
        {
            preencherListas(clientes, objetivos);
        }

        public PropPlanoTreinamento(PlanoTreinamento obj)
            :this()
        {
            if (obj != null)
            {
                this.obj = obj;
                lista.AddRange(obj.Exercicios);
                this.Text = "Alterar " + this.nome;
                preencherCampos();
                isInsert = false;
            }
        }

        public PropPlanoTreinamento(PlanoTreinamento obj, List<ComboBoxItemEx> clientes, List<ComboBoxItemEx> objetivos)
            :this(obj)
        {
            preencherListas(clientes, objetivos);
        }

        private void preencherListas(List<ComboBoxItemEx> clientes, List<ComboBoxItemEx> objetivos)
        {
            lstClientes.AddRange(clientes);
            if (lstClientes[0].DisplayValue.ToLower() == "<todos>")
                lstClientes[0].DisplayValue = "<Selecione um cliente>";
            else
                lstClientes.Insert(0, new ComboBoxItemEx(0, "<Selecione um cliente>"));
            bdsClientes.DataSource = lstClientes;
            cbxCliente.DataSource = bdsClientes;
            lstObjetivos.AddRange(objetivos);
            if (lstObjetivos[0].DisplayValue.ToLower() == "<todos>")
                lstObjetivos[0].DisplayValue = "<Selecione um objetivo>";
            else
                lstObjetivos.Insert(0, new ComboBoxItemEx(0, "<Selecione um objetivo>"));
            bdsObjetivos.DataSource = lstObjetivos;
            cbxObetivo.DataSource = bdsObjetivos;
        }

        private void preencherCampos()
        {
            txtbxNumPlano.Text = obj.Numplano.ToString();
            dtpkData.Value = obj.Data;
            for (int i =0; i < lstClientes.Count; i++)
            {
                if (lstClientes[i].Id == obj.ClienteDoPlano.Codigo)
                {
                    cbxCliente.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < lstObjetivos.Count; i++)
            {
                if (lstObjetivos[i].Id == obj.ObjetivoDoPlano.Codigo)
                {
                    cbxObetivo.SelectedIndex = i;
                    break;
                }
            }
            BindingList();
        }

        private void preencherObj()
        {
            if (isInsert)
                obj = new PlanoTreinamento();
            else
                obj.Numplano = Convert.ToInt32(txtbxNumPlano.Text);
            obj.Data = dtpkData.Value;
            obj.ObjetivoDoPlano.Codigo = lstObjetivos[cbxObetivo.SelectedIndex].Id;
            obj.ClienteDoPlano.Codigo = lstClientes[cbxCliente.SelectedIndex].Id;
            obj.Exercicios = lista.ToArray();
        }

        private void salvar()
        {
            try
            {
                srvPlano.salvarPlanoTreinamento(obj);
            }
            catch (Exception e)
            {
                string msg;
                msg = FiltrarMsgErroWebSrv.execute(e.Message);
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
            btnOrdMvPrimeiro.Enabled = dataGridView.RowCount > 1 ? true : false;
            btnOrdMvUltimo.Enabled = btnOrdMvPrimeiro.Enabled;
            btnOrdMvCima.Enabled = btnOrdMvPrimeiro.Enabled;
            btnOrdMvBaixo.Enabled = btnOrdMvPrimeiro.Enabled;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            updateActions();
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

        private void btnOrdMvPrimeiro_Click(object sender, EventArgs e)
        {
            if (lista.Count > 0)
                moverDePara(dataGridView.CurrentRow.Index, 0);
        }

        private void moverDePara(int indexOrigem, int indexDestino)
        {
            ExercicioDoPlano ep;
            int selectRowIndex = indexDestino;// dataGridView.CurrentRow.Index;
            if (lista.Count() > 1)
            {
                UnBindingList();
                ep = lista[indexOrigem];//dataGridView.CurrentRow.Index];
                lista.RemoveAt(indexOrigem);//dataGridView.CurrentRow.Index);
                lista.Insert(indexDestino, ep);
                reordenarListaDeExercicios(ref lista);
                BindingList();
                dataGridView.Rows[selectRowIndex].Selected = true;
            }
        }

        private void reordenarListaDeExercicios(ref List<ExercicioDoPlano> lista)
        {
            if (lista.Count() > 1)
            {
                for (int i = 0; i < lista.Count(); i++)
                {
                    lista[i].Seq = i + 1;
                }
            }
        }

        private void btnOrdMvUltimo_Click(object sender, EventArgs e)
        {
            if (lista.Count > 0)
                moverDePara(dataGridView.CurrentRow.Index, dataGridView.Rows.Count - 1);
        }

        private void btnOrdMvCima_Click(object sender, EventArgs e)
        {
            if (lista.Count > 0)
                moverDePara(dataGridView.CurrentRow.Index, dataGridView.CurrentRow.Index - 1);
        }

        private void btnOrdMvBaixo_Click(object sender, EventArgs e)
        {
            if (lista.Count > 0)
                moverDePara(dataGridView.CurrentRow.Index, dataGridView.CurrentRow.Index + 1);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            PropExerciciosDoPlano frm = new PropExerciciosDoPlano();
            if (frm.ShowDialog() == DialogResult.OK)
                MessageBox.Show("A operação foi realizada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
