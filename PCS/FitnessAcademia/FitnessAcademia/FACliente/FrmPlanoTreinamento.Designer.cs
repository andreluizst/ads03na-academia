namespace FACliente
{
    partial class FrmPlanoTreinamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlanoTreinamento));
            this.imglstBotoes = new System.Windows.Forms.ImageList(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxObetivo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpkFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkInicial = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bdsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.bdsObjetivo = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clmnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnObjetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsObjetivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
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
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbxObetivo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpkFinal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpkInicial);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 150);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Objetivo:";
            // 
            // cbxObetivo
            // 
            this.cbxObetivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxObetivo.FormattingEnabled = true;
            this.cbxObetivo.Location = new System.Drawing.Point(486, 53);
            this.cbxObetivo.Name = "cbxObetivo";
            this.cbxObetivo.Size = new System.Drawing.Size(228, 21);
            this.cbxObetivo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cliente:";
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(99, 53);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(300, 21);
            this.cbxCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data final:";
            // 
            // dtpkFinal
            // 
            this.dtpkFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFinal.Location = new System.Drawing.Point(310, 18);
            this.dtpkFinal.Name = "dtpkFinal";
            this.dtpkFinal.Size = new System.Drawing.Size(108, 20);
            this.dtpkFinal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data inicial:";
            // 
            // dtpkInicial
            // 
            this.dtpkInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkInicial.Location = new System.Drawing.Point(109, 18);
            this.dtpkInicial.Name = "dtpkInicial";
            this.dtpkInicial.Size = new System.Drawing.Size(108, 20);
            this.dtpkInicial.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.ImageKey = "btnLupaHot.bmp";
            this.btnConsultar.ImageList = this.imglstBotoes;
            this.btnConsultar.Location = new System.Drawing.Point(486, 110);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(112, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Pesquisar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.ImageKey = "btnExcluirHot.bmp";
            this.btnExcluir.ImageList = this.imglstBotoes;
            this.btnExcluir.Location = new System.Drawing.Point(322, 110);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.ImageKey = "btnAlterarHot.bmp";
            this.btnAlterar.ImageList = this.imglstBotoes;
            this.btnAlterar.Location = new System.Drawing.Point(181, 110);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(112, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "A&lterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.ImageKey = "btnNovoHot.bmp";
            this.btnNovo.ImageList = this.imglstBotoes;
            this.btnNovo.Location = new System.Drawing.Point(41, 110);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(112, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 150);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(735, 5);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnNum,
            this.clmnCliente,
            this.clmnData,
            this.clmnObjetivo});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 155);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(735, 220);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(FACliente.localhostSrvPlano.Cliente);
            // 
            // clmnNum
            // 
            this.clmnNum.HeaderText = "Número";
            this.clmnNum.Name = "clmnNum";
            this.clmnNum.ReadOnly = true;
            // 
            // clmnCliente
            // 
            this.clmnCliente.HeaderText = "Cliente";
            this.clmnCliente.Name = "clmnCliente";
            this.clmnCliente.ReadOnly = true;
            // 
            // clmnData
            // 
            this.clmnData.HeaderText = "Data";
            this.clmnData.Name = "clmnData";
            this.clmnData.ReadOnly = true;
            // 
            // clmnObjetivo
            // 
            this.clmnObjetivo.HeaderText = "Objetivo";
            this.clmnObjetivo.Name = "clmnObjetivo";
            this.clmnObjetivo.ReadOnly = true;
            // 
            // FrmPlanoTreinamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 375);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPlanoTreinamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manter Plano de Treinamento";
            this.Activated += new System.EventHandler(this.FrmPlanoTreinamento_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPlanoTreinamento_FormClosed);
            this.Shown += new System.EventHandler(this.FrmPlanoTreinamento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsObjetivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ImageList imglstBotoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxObetivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpkFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkInicial;
        private System.Windows.Forms.BindingSource bdsCliente;
        private System.Windows.Forms.BindingSource bdsObjetivo;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnObjetivo;
    }
}