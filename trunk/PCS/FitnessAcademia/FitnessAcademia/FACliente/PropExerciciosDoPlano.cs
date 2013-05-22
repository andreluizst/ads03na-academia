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
    public partial class PropExerciciosDoPlano : Form
    {
        private ExercicioDoPlano obj;
        private bool isInsert = false;
        private string nome = "Exercícios do Plano de Treinamento";

        public PropExerciciosDoPlano()
        {
            InitializeComponent();
            this.Text = "NOVO " + this.nome;
            isInsert = true;
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

        private void preencherCampos()
        {
            nudSeq.Value = obj.Seq;
            nudSeries.Value = obj.Series;
            nudRepeticoes.Value = obj.NumRepeticoes;
            nudPeso.Value = Convert.ToDecimal(obj.Peso);
        }

        private void preencherObj()
        {
            if (isInsert)
                obj = new ExercicioDoPlano();
            obj.Seq = (Int32)nudSeq.Value;
            obj.Series = (Int32)nudSeries.Value;
            obj.NumRepeticoes = (Int32)nudRepeticoes.Value;
            obj.Peso = (Double)nudPeso.Value;
        }


    }
}
