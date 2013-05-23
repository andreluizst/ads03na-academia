using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using FACliente.localhostPlano;
using FACliente.localhostSrvPlano;

namespace FACliente
{
    public partial class PropExerciciosDoPlano : Form
    {
        private ExercicioDoPlano obj;
        private List<ComboBoxItemEx> lstExercicios;
        private bool isInsert = false;
        private string nome = "Exercícios do Plano de Treinamento";
        private Service1 srv;

        public PropExerciciosDoPlano()
        {
            InitializeComponent();
            this.Text = "NOVO " + this.nome;
            isInsert = true;
            lstExercicios = new List<ComboBoxItemEx>();
            srv = new Service1();
        }

        public PropExerciciosDoPlano(ref ExercicioDoPlano obj)
            :this()
        {
            if (obj != null)
            {
                this.obj = obj;
                this.Text = "Alterar " + this.nome;
                preencherCampos();
                isInsert = false;
            }
        }

        private void preencherLista()
        {
            Exercicio[] exercicios;
            try
            {
                exercicios = srv.listarExercicios();
                lstExercicios.Clear();
                lstExercicios.Add(new ComboBoxItemEx(0, "<Selecione um exercício>"));
                foreach (Exercicio item in exercicios)
                {
                    lstExercicios.Add(new ComboBoxItemEx(item.Codigo, item.Descricao));
                }
                bdsExercicios.DataSource = lstExercicios;
                cbxExercicio.DataSource = bdsExercicios;
                cbxExercicio.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                string msg;
                msg = FiltrarMsgErroWebSrv.execute(e.Message);
                MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void selecionarExercicio(int codigo)
        {
            for (int i = 0; i < lstExercicios.Count; i++)
            {
                if (lstExercicios[i].Id == codigo)
                {
                    cbxExercicio.SelectedIndex = i;
                    break;
                }
            }
        }

        private void preencherCampos()
        {
            nudSeq.Value = obj.Seq;
            nudSeries.Value = obj.Series;
            nudRepeticoes.Value = obj.NumRepeticoes;
            nudPeso.Value = Convert.ToDecimal(obj.Peso);
            selecionarExercicio(obj.Exercicio.Codigo);
        }

        private void preencherObj()
        {
            if (isInsert)
                obj = new ExercicioDoPlano();
            obj.Seq = (Int32)nudSeq.Value;
            obj.Series = (Int32)nudSeries.Value;
            obj.NumRepeticoes = (Int32)nudRepeticoes.Value;
            obj.Peso = (Double)nudPeso.Value;
            obj.Exercicio = new Exercicio();
            obj.Exercicio.Codigo = lstExercicios[cbxExercicio.SelectedIndex].Id;
        }


    }
}
