namespace FACliente
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miManterExercício = new System.Windows.Forms.ToolStripMenuItem();
            this.miManterObjetivo = new System.Windows.Forms.ToolStripMenuItem();
            this.miManterCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miSair = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.miFecharPesquisa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.miAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.miExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.miFecharJanelaAtual = new System.Windows.Forms.ToolStripMenuItem();
            this.miJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.mnJanela});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.mnJanela;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miManterExercício,
            this.miManterObjetivo,
            this.miManterCliente,
            this.toolStripMenuItem1,
            this.miSair});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // miManterExercício
            // 
            this.miManterExercício.Name = "miManterExercício";
            this.miManterExercício.Size = new System.Drawing.Size(161, 22);
            this.miManterExercício.Text = "Manter &Exercício";
            this.miManterExercício.Click += new System.EventHandler(this.miManterExercício_Click);
            // 
            // miManterObjetivo
            // 
            this.miManterObjetivo.Name = "miManterObjetivo";
            this.miManterObjetivo.Size = new System.Drawing.Size(161, 22);
            this.miManterObjetivo.Text = "Manter &Objetivo";
            this.miManterObjetivo.Click += new System.EventHandler(this.miManterObjetivo_Click);
            // 
            // miManterCliente
            // 
            this.miManterCliente.Name = "miManterCliente";
            this.miManterCliente.Size = new System.Drawing.Size(161, 22);
            this.miManterCliente.Text = "Mantter &Cliente";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 6);
            // 
            // miSair
            // 
            this.miSair.Name = "miSair";
            this.miSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.miSair.Size = new System.Drawing.Size(161, 22);
            this.miSair.Text = "Sai&r";
            this.miSair.Click += new System.EventHandler(this.miSair_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPesquisar,
            this.miFecharPesquisa,
            this.toolStripMenuItem2,
            this.miNovo,
            this.miAlterar,
            this.miExcluir});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            this.editarToolStripMenuItem.DropDownOpening += new System.EventHandler(this.editarToolStripMenuItem_DropDownOpening);
            // 
            // miPesquisar
            // 
            this.miPesquisar.Name = "miPesquisar";
            this.miPesquisar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.miPesquisar.Size = new System.Drawing.Size(230, 22);
            this.miPesquisar.Text = "&Pesquisar";
            this.miPesquisar.Click += new System.EventHandler(this.miPesquisar_Click);
            // 
            // miFecharPesquisa
            // 
            this.miFecharPesquisa.Name = "miFecharPesquisa";
            this.miFecharPesquisa.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.miFecharPesquisa.Size = new System.Drawing.Size(230, 22);
            this.miFecharPesquisa.Text = "&Fechar pesquisa";
            this.miFecharPesquisa.Click += new System.EventHandler(this.miFecharPesquisa_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(227, 6);
            // 
            // miNovo
            // 
            this.miNovo.Name = "miNovo";
            this.miNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.miNovo.Size = new System.Drawing.Size(230, 22);
            this.miNovo.Text = "&Novo...";
            this.miNovo.Click += new System.EventHandler(this.miNovo_Click);
            // 
            // miAlterar
            // 
            this.miAlterar.Name = "miAlterar";
            this.miAlterar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.miAlterar.Size = new System.Drawing.Size(230, 22);
            this.miAlterar.Text = "&Alterar...";
            this.miAlterar.Click += new System.EventHandler(this.miAlterar_Click);
            // 
            // miExcluir
            // 
            this.miExcluir.Name = "miExcluir";
            this.miExcluir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.miExcluir.Size = new System.Drawing.Size(230, 22);
            this.miExcluir.Text = "E&xcluir";
            this.miExcluir.Click += new System.EventHandler(this.miExcluir_Click);
            // 
            // mnJanela
            // 
            this.mnJanela.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFecharJanelaAtual,
            this.miJanela});
            this.mnJanela.Name = "mnJanela";
            this.mnJanela.Size = new System.Drawing.Size(51, 20);
            this.mnJanela.Text = "&Janela";
            // 
            // miFecharJanelaAtual
            // 
            this.miFecharJanelaAtual.Name = "miFecharJanelaAtual";
            this.miFecharJanelaAtual.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.miFecharJanelaAtual.Size = new System.Drawing.Size(218, 22);
            this.miFecharJanelaAtual.Text = "&Fechar janela atual";
            this.miFecharJanelaAtual.Click += new System.EventHandler(this.miFecharJanelaAtual_Click);
            // 
            // miJanela
            // 
            this.miJanela.Name = "miJanela";
            this.miJanela.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Tab)));
            this.miJanela.Size = new System.Drawing.Size(218, 22);
            this.miJanela.Text = "Pró&xima janela";
            this.miJanela.Click += new System.EventHandler(this.miJanela_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 366);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fitness Academia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miManterExercício;
        private System.Windows.Forms.ToolStripMenuItem miManterObjetivo;
        private System.Windows.Forms.ToolStripMenuItem miManterCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miSair;
        private System.Windows.Forms.ToolStripMenuItem mnJanela;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miPesquisar;
        private System.Windows.Forms.ToolStripMenuItem miFecharPesquisa;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem miNovo;
        private System.Windows.Forms.ToolStripMenuItem miAlterar;
        private System.Windows.Forms.ToolStripMenuItem miExcluir;
        private System.Windows.Forms.ToolStripMenuItem miFecharJanelaAtual;
        private System.Windows.Forms.ToolStripMenuItem miJanela;
    }
}

