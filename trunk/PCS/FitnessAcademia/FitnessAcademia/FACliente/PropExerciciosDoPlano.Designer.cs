namespace FACliente
{
    partial class PropExerciciosDoPlano
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropExerciciosDoPlano));
            this.imglstBotoes = new System.Windows.Forms.ImageList(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxExercicio = new System.Windows.Forms.ComboBox();
            this.bdsExercicios = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSeq = new System.Windows.Forms.NumericUpDown();
            this.nudSeries = new System.Windows.Forms.NumericUpDown();
            this.nudRepeticoes = new System.Windows.Forms.NumericUpDown();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bdsExercicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeticoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // imglstBotoes
            // 
            this.imglstBotoes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstBotoes.ImageStream")));
            this.imglstBotoes.TransparentColor = System.Drawing.Color.Magenta;
            this.imglstBotoes.Images.SetKeyName(0, "btnNovo.bmp");
            this.imglstBotoes.Images.SetKeyName(1, "btnNovoDisable.bmp");
            this.imglstBotoes.Images.SetKeyName(2, "btnNovoHot.bmp");
            this.imglstBotoes.Images.SetKeyName(3, "btnAlterarHot.bmp");
            this.imglstBotoes.Images.SetKeyName(4, "btnExcluirHot.bmp");
            this.imglstBotoes.Images.SetKeyName(5, "btnLupaHot.bmp");
            this.imglstBotoes.Images.SetKeyName(6, "btnSalvarHot.bmp");
            this.imglstBotoes.Images.SetKeyName(7, "btnCancelarHot.bmp");
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.ImageKey = "btnCancelarHot.bmp";
            this.btnCancelar.ImageList = this.imglstBotoes;
            this.btnCancelar.Location = new System.Drawing.Point(406, 166);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImageKey = "btnSalvarHot.bmp";
            this.btnSalvar.ImageList = this.imglstBotoes;
            this.btnSalvar.Location = new System.Drawing.Point(246, 166);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sequencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Exercício:";
            // 
            // cbxExercicio
            // 
            this.cbxExercicio.FormattingEnabled = true;
            this.cbxExercicio.Location = new System.Drawing.Point(94, 69);
            this.cbxExercicio.Name = "cbxExercicio";
            this.cbxExercicio.Size = new System.Drawing.Size(264, 21);
            this.cbxExercicio.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Series:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Repetições:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Peso (kg):";
            // 
            // nudSeq
            // 
            this.nudSeq.Location = new System.Drawing.Point(94, 35);
            this.nudSeq.Name = "nudSeq";
            this.nudSeq.Size = new System.Drawing.Size(77, 20);
            this.nudSeq.TabIndex = 14;
            // 
            // nudSeries
            // 
            this.nudSeries.Location = new System.Drawing.Point(94, 106);
            this.nudSeries.Name = "nudSeries";
            this.nudSeries.Size = new System.Drawing.Size(77, 20);
            this.nudSeries.TabIndex = 15;
            // 
            // nudRepeticoes
            // 
            this.nudRepeticoes.Location = new System.Drawing.Point(271, 106);
            this.nudRepeticoes.Name = "nudRepeticoes";
            this.nudRepeticoes.Size = new System.Drawing.Size(77, 20);
            this.nudRepeticoes.TabIndex = 16;
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(441, 107);
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(77, 20);
            this.nudPeso.TabIndex = 17;
            // 
            // PropExerciciosDoPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 218);
            this.Controls.Add(this.nudPeso);
            this.Controls.Add(this.nudRepeticoes);
            this.Controls.Add(this.nudSeries);
            this.Controls.Add(this.nudSeq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxExercicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "PropExerciciosDoPlano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PropExerciciosDoPlano";
            ((System.ComponentModel.ISupportInitialize)(this.bdsExercicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeticoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imglstBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxExercicio;
        private System.Windows.Forms.BindingSource bdsExercicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudSeq;
        private System.Windows.Forms.NumericUpDown nudSeries;
        private System.Windows.Forms.NumericUpDown nudRepeticoes;
        private System.Windows.Forms.NumericUpDown nudPeso;
    }
}