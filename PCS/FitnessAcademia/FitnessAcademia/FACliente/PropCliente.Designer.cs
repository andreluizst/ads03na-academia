namespace FACliente
{
    partial class PropCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropCliente));
            this.imglstBotoes = new System.Windows.Forms.ImageList(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtbxNome = new System.Windows.Forms.TextBox();
            this.txtbxCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNúmeroLog = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtbxCpf = new System.Windows.Forms.TextBox();
            this.txtbxRg = new System.Windows.Forms.TextBox();
            this.txtbxLogradouro = new System.Windows.Forms.TextBox();
            this.txtbxComplemento = new System.Windows.Forms.TextBox();
            this.txtbxNumeroLog = new System.Windows.Forms.TextBox();
            this.txtbxBairro = new System.Windows.Forms.TextBox();
            this.txtbxCidade = new System.Windows.Forms.TextBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEstCivil = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblValExameMedico = new System.Windows.Forms.Label();
            this.txtbxUf = new System.Windows.Forms.TextBox();
            this.txtbxCep = new System.Windows.Forms.TextBox();
            this.txtbxEstCivil = new System.Windows.Forms.TextBox();
            this.txtbxSexo = new System.Windows.Forms.TextBox();
            this.txtbxTelefone = new System.Windows.Forms.TextBox();
            this.txtbxCelular = new System.Windows.Forms.TextBox();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.dtpkDataNasc = new System.Windows.Forms.DateTimePicker();
            this.dtpkValExaMedico = new System.Windows.Forms.DateTimePicker();
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
            this.btnCancelar.Location = new System.Drawing.Point(531, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImageKey = "btnSalvarHot.bmp";
            this.btnSalvar.ImageList = this.imglstBotoes;
            this.btnSalvar.Location = new System.Drawing.Point(371, 322);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtbxNome
            // 
            this.txtbxNome.Location = new System.Drawing.Point(256, 21);
            this.txtbxNome.Name = "txtbxNome";
            this.txtbxNome.Size = new System.Drawing.Size(399, 20);
            this.txtbxNome.TabIndex = 1;
            // 
            // txtbxCodigo
            // 
            this.txtbxCodigo.Enabled = false;
            this.txtbxCodigo.Location = new System.Drawing.Point(91, 21);
            this.txtbxCodigo.Name = "txtbxCodigo";
            this.txtbxCodigo.Size = new System.Drawing.Size(64, 20);
            this.txtbxCodigo.TabIndex = 0;
            this.txtbxCodigo.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(197, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 28);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Código:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(21, 66);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 18;
            this.lblCpf.Text = "CPF";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(197, 69);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(23, 13);
            this.lblRg.TabIndex = 19;
            this.lblRg.Text = "RG";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(403, 66);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(102, 13);
            this.lblDataNasc.TabIndex = 20;
            this.lblDataNasc.Text = "Data de nascimento";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(20, 115);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouro.TabIndex = 21;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(501, 118);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 22;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblNúmeroLog
            // 
            this.lblNúmeroLog.AutoSize = true;
            this.lblNúmeroLog.Location = new System.Drawing.Point(384, 118);
            this.lblNúmeroLog.Name = "lblNúmeroLog";
            this.lblNúmeroLog.Size = new System.Drawing.Size(44, 13);
            this.lblNúmeroLog.TabIndex = 23;
            this.lblNúmeroLog.Text = "Número";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(21, 158);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 24;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(341, 164);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 25;
            this.lblCidade.Text = "Cidade";
            // 
            // txtbxCpf
            // 
            this.txtbxCpf.Location = new System.Drawing.Point(72, 66);
            this.txtbxCpf.Name = "txtbxCpf";
            this.txtbxCpf.Size = new System.Drawing.Size(100, 20);
            this.txtbxCpf.TabIndex = 2;
            // 
            // txtbxRg
            // 
            this.txtbxRg.Location = new System.Drawing.Point(256, 66);
            this.txtbxRg.Name = "txtbxRg";
            this.txtbxRg.Size = new System.Drawing.Size(100, 20);
            this.txtbxRg.TabIndex = 3;
            // 
            // txtbxLogradouro
            // 
            this.txtbxLogradouro.Location = new System.Drawing.Point(91, 115);
            this.txtbxLogradouro.Name = "txtbxLogradouro";
            this.txtbxLogradouro.Size = new System.Drawing.Size(277, 20);
            this.txtbxLogradouro.TabIndex = 5;
            // 
            // txtbxComplemento
            // 
            this.txtbxComplemento.Location = new System.Drawing.Point(578, 115);
            this.txtbxComplemento.Name = "txtbxComplemento";
            this.txtbxComplemento.Size = new System.Drawing.Size(77, 20);
            this.txtbxComplemento.TabIndex = 7;
            // 
            // txtbxNumeroLog
            // 
            this.txtbxNumeroLog.Location = new System.Drawing.Point(434, 118);
            this.txtbxNumeroLog.Name = "txtbxNumeroLog";
            this.txtbxNumeroLog.Size = new System.Drawing.Size(61, 20);
            this.txtbxNumeroLog.TabIndex = 6;
            // 
            // txtbxBairro
            // 
            this.txtbxBairro.Location = new System.Drawing.Point(82, 158);
            this.txtbxBairro.Name = "txtbxBairro";
            this.txtbxBairro.Size = new System.Drawing.Size(240, 20);
            this.txtbxBairro.TabIndex = 8;
            // 
            // txtbxCidade
            // 
            this.txtbxCidade.Location = new System.Drawing.Point(387, 161);
            this.txtbxCidade.Name = "txtbxCidade";
            this.txtbxCidade.Size = new System.Drawing.Size(166, 20);
            this.txtbxCidade.TabIndex = 9;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(568, 164);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(21, 13);
            this.lblUf.TabIndex = 34;
            this.lblUf.Text = "UF";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(20, 207);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 35;
            this.lblCep.Text = "CEP";
            // 
            // lblEstCivil
            // 
            this.lblEstCivil.AutoSize = true;
            this.lblEstCivil.Location = new System.Drawing.Point(197, 210);
            this.lblEstCivil.Name = "lblEstCivil";
            this.lblEstCivil.Size = new System.Drawing.Size(61, 13);
            this.lblEstCivil.TabIndex = 36;
            this.lblEstCivil.Text = "Estado civil";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(368, 217);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 37;
            this.lblSexo.Text = "Sexo";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(488, 217);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 38;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(20, 254);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 39;
            this.lblCelular.Text = "Celular";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(200, 261);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Email";
            // 
            // lblValExameMedico
            // 
            this.lblValExameMedico.AutoSize = true;
            this.lblValExameMedico.Location = new System.Drawing.Point(20, 300);
            this.lblValExameMedico.Name = "lblValExameMedico";
            this.lblValExameMedico.Size = new System.Drawing.Size(119, 13);
            this.lblValExameMedico.TabIndex = 41;
            this.lblValExameMedico.Text = "Validade exame médico";
            // 
            // txtbxUf
            // 
            this.txtbxUf.Location = new System.Drawing.Point(595, 161);
            this.txtbxUf.Name = "txtbxUf";
            this.txtbxUf.Size = new System.Drawing.Size(60, 20);
            this.txtbxUf.TabIndex = 10;
            // 
            // txtbxCep
            // 
            this.txtbxCep.Location = new System.Drawing.Point(72, 207);
            this.txtbxCep.Name = "txtbxCep";
            this.txtbxCep.Size = new System.Drawing.Size(100, 20);
            this.txtbxCep.TabIndex = 11;
            // 
            // txtbxEstCivil
            // 
            this.txtbxEstCivil.Location = new System.Drawing.Point(284, 210);
            this.txtbxEstCivil.Name = "txtbxEstCivil";
            this.txtbxEstCivil.Size = new System.Drawing.Size(38, 20);
            this.txtbxEstCivil.TabIndex = 12;
            // 
            // txtbxSexo
            // 
            this.txtbxSexo.Location = new System.Drawing.Point(405, 214);
            this.txtbxSexo.Name = "txtbxSexo";
            this.txtbxSexo.Size = new System.Drawing.Size(43, 20);
            this.txtbxSexo.TabIndex = 13;
            // 
            // txtbxTelefone
            // 
            this.txtbxTelefone.Location = new System.Drawing.Point(555, 214);
            this.txtbxTelefone.Name = "txtbxTelefone";
            this.txtbxTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtbxTelefone.TabIndex = 14;
            // 
            // txtbxCelular
            // 
            this.txtbxCelular.Location = new System.Drawing.Point(72, 254);
            this.txtbxCelular.Name = "txtbxCelular";
            this.txtbxCelular.Size = new System.Drawing.Size(100, 20);
            this.txtbxCelular.TabIndex = 15;
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Location = new System.Drawing.Point(238, 261);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(168, 20);
            this.txtbxEmail.TabIndex = 16;
            // 
            // dtpkDataNasc
            // 
            this.dtpkDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDataNasc.Location = new System.Drawing.Point(544, 63);
            this.dtpkDataNasc.Name = "dtpkDataNasc";
            this.dtpkDataNasc.Size = new System.Drawing.Size(111, 20);
            this.dtpkDataNasc.TabIndex = 4;
            // 
            // dtpkValExaMedico
            // 
            this.dtpkValExaMedico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkValExaMedico.Location = new System.Drawing.Point(156, 300);
            this.dtpkValExaMedico.Name = "dtpkValExaMedico";
            this.dtpkValExaMedico.Size = new System.Drawing.Size(131, 20);
            this.dtpkValExaMedico.TabIndex = 17;
            // 
            // PropCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 369);
            this.Controls.Add(this.dtpkValExaMedico);
            this.Controls.Add(this.dtpkDataNasc);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.txtbxCelular);
            this.Controls.Add(this.txtbxTelefone);
            this.Controls.Add(this.txtbxSexo);
            this.Controls.Add(this.txtbxEstCivil);
            this.Controls.Add(this.txtbxCep);
            this.Controls.Add(this.txtbxUf);
            this.Controls.Add(this.lblValExameMedico);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEstCivil);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.txtbxCidade);
            this.Controls.Add(this.txtbxBairro);
            this.Controls.Add(this.txtbxNumeroLog);
            this.Controls.Add(this.txtbxComplemento);
            this.Controls.Add(this.txtbxLogradouro);
            this.Controls.Add(this.txtbxRg);
            this.Controls.Add(this.txtbxCpf);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblNúmeroLog);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtbxNome);
            this.Controls.Add(this.txtbxCodigo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.KeyPreview = true;
            this.Name = "PropCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PropCliente";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PropCliente_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imglstBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtbxNome;
        private System.Windows.Forms.TextBox txtbxCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNúmeroLog;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtbxCpf;
        private System.Windows.Forms.TextBox txtbxRg;
        private System.Windows.Forms.TextBox txtbxLogradouro;
        private System.Windows.Forms.TextBox txtbxComplemento;
        private System.Windows.Forms.TextBox txtbxNumeroLog;
        private System.Windows.Forms.TextBox txtbxBairro;
        private System.Windows.Forms.TextBox txtbxCidade;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEstCivil;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblValExameMedico;
        private System.Windows.Forms.TextBox txtbxUf;
        private System.Windows.Forms.TextBox txtbxCep;
        private System.Windows.Forms.TextBox txtbxEstCivil;
        private System.Windows.Forms.TextBox txtbxSexo;
        private System.Windows.Forms.TextBox txtbxTelefone;
        private System.Windows.Forms.TextBox txtbxCelular;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.DateTimePicker dtpkDataNasc;
        private System.Windows.Forms.DateTimePicker dtpkValExaMedico;
    }
}