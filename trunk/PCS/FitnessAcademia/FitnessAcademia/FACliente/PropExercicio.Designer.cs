namespace FACliente
{
    partial class PropExercicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropExercicio));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtbxCodigo = new System.Windows.Forms.TextBox();
            this.txtbxDescricao = new System.Windows.Forms.TextBox();
            this.imglstBotoes = new System.Windows.Forms.ImageList(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(23, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(23, 76);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtbxCodigo
            // 
            this.txtbxCodigo.Enabled = false;
            this.txtbxCodigo.Location = new System.Drawing.Point(93, 20);
            this.txtbxCodigo.Name = "txtbxCodigo";
            this.txtbxCodigo.Size = new System.Drawing.Size(64, 20);
            this.txtbxCodigo.TabIndex = 2;
            // 
            // txtbxDescricao
            // 
            this.txtbxDescricao.Location = new System.Drawing.Point(97, 68);
            this.txtbxDescricao.Name = "txtbxDescricao";
            this.txtbxDescricao.Size = new System.Drawing.Size(309, 20);
            this.txtbxDescricao.TabIndex = 3;
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
            this.btnCancelar.Location = new System.Drawing.Point(294, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImageKey = "btnSalvarHot.bmp";
            this.btnSalvar.ImageList = this.imglstBotoes;
            this.btnSalvar.Location = new System.Drawing.Point(134, 133);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // PropExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 176);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtbxDescricao);
            this.Controls.Add(this.txtbxCodigo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "PropExercicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PropExercicio";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PropExercicio_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtbxCodigo;
        private System.Windows.Forms.TextBox txtbxDescricao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ImageList imglstBotoes;
    }
}