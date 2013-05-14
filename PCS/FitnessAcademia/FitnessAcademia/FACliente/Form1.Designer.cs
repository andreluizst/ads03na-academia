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
            this.manterExercícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manterObjetivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantterClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
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
            this.manterExercícioToolStripMenuItem,
            this.manterObjetivoToolStripMenuItem,
            this.mantterClienteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // manterExercícioToolStripMenuItem
            // 
            this.manterExercícioToolStripMenuItem.Name = "manterExercícioToolStripMenuItem";
            this.manterExercícioToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.manterExercícioToolStripMenuItem.Text = "Manter &Exercício";
            // 
            // manterObjetivoToolStripMenuItem
            // 
            this.manterObjetivoToolStripMenuItem.Name = "manterObjetivoToolStripMenuItem";
            this.manterObjetivoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.manterObjetivoToolStripMenuItem.Text = "Manter &Objetivo";
            // 
            // mantterClienteToolStripMenuItem
            // 
            this.mantterClienteToolStripMenuItem.Name = "mantterClienteToolStripMenuItem";
            this.mantterClienteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mantterClienteToolStripMenuItem.Text = "Mantter &Cliente";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.sairToolStripMenuItem.Text = "Sai&r";
            // 
            // mnJanela
            // 
            this.mnJanela.Name = "mnJanela";
            this.mnJanela.Size = new System.Drawing.Size(51, 20);
            this.mnJanela.Text = "&Janela";
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
        private System.Windows.Forms.ToolStripMenuItem manterExercícioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manterObjetivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantterClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnJanela;
    }
}

