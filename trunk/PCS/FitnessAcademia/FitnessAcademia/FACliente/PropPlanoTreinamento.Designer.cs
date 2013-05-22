namespace FACliente
{
    partial class PropPlanoTreinamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropPlanoTreinamento));
            this.imglstBotoes = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxObetivo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkData = new System.Windows.Forms.DateTimePicker();
            this.txtbxNumPlano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.bdsExerciciosDoPlano = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsExerciciosDoPlano)).BeginInit();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 49);
            this.panel1.TabIndex = 28;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.ImageKey = "btnCancelarHot.bmp";
            this.btnCancelar.ImageList = this.imglstBotoes;
            this.btnCancelar.Location = new System.Drawing.Point(609, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImageKey = "btnSalvarHot.bmp";
            this.btnSalvar.ImageList = this.imglstBotoes;
            this.btnSalvar.Location = new System.Drawing.Point(449, 13);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbxObetivo);
            this.panel2.Controls.Add(this.cbxCliente);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpkData);
            this.panel2.Controls.Add(this.txtbxNumPlano);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 92);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Objetivo:";
            // 
            // cbxObetivo
            // 
            this.cbxObetivo.FormattingEnabled = true;
            this.cbxObetivo.Location = new System.Drawing.Point(479, 26);
            this.cbxObetivo.Name = "cbxObetivo";
            this.cbxObetivo.Size = new System.Drawing.Size(247, 21);
            this.cbxObetivo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Cliente:";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(77, 53);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(494, 21);
            this.cbxCliente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Data:";
            // 
            // dtpkData
            // 
            this.dtpkData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkData.Location = new System.Drawing.Point(267, 26);
            this.dtpkData.Name = "dtpkData";
            this.dtpkData.Size = new System.Drawing.Size(103, 20);
            this.dtpkData.TabIndex = 2;
            // 
            // txtbxNumPlano
            // 
            this.txtbxNumPlano.Enabled = false;
            this.txtbxNumPlano.Location = new System.Drawing.Point(77, 26);
            this.txtbxNumPlano.Name = "txtbxNumPlano";
            this.txtbxNumPlano.ReadOnly = true;
            this.txtbxNumPlano.Size = new System.Drawing.Size(101, 20);
            this.txtbxNumPlano.TabIndex = 1;
            this.txtbxNumPlano.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 92);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(782, 5);
            this.splitter1.TabIndex = 30;
            this.splitter1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 97);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(782, 277);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.btnExcluir);
            this.panel3.Controls.Add(this.btnAlterar);
            this.panel3.Controls.Add(this.btnNovo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(83, 277);
            this.panel3.TabIndex = 32;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.ImageKey = "btnExcluirHot.bmp";
            this.btnExcluir.ImageList = this.imglstBotoes;
            this.btnExcluir.Location = new System.Drawing.Point(5, 143);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(72, 61);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "E&xcluir exercício";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.ImageKey = "btnAlterarHot.bmp";
            this.btnAlterar.ImageList = this.imglstBotoes;
            this.btnAlterar.Location = new System.Drawing.Point(5, 76);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(72, 61);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "A&lterar exercício";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.ImageKey = "btnNovoHot.bmp";
            this.btnNovo.ImageList = this.imglstBotoes;
            this.btnNovo.Location = new System.Drawing.Point(5, 9);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(72, 61);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "&Novo exercício";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // PropPlanoTreinamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 423);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "PropPlanoTreinamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PropPlanoTreinamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PropPlanoTreinamento_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsExerciciosDoPlano)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imglstBotoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxObetivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkData;
        private System.Windows.Forms.TextBox txtbxNumPlano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.BindingSource bdsExerciciosDoPlano;
    }
}