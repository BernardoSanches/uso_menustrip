namespace AppMenu
{
    partial class FrmVermelho
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
            this.formularioVermelhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibformvermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.exibformazul = new System.Windows.Forms.ToolStripMenuItem();
            this.exibfrmlaranja = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioVermelhoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formularioVermelhoToolStripMenuItem
            // 
            this.formularioVermelhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibformvermelho,
            this.exibformazul,
            this.exibfrmlaranja});
            this.formularioVermelhoToolStripMenuItem.Name = "formularioVermelhoToolStripMenuItem";
            this.formularioVermelhoToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.formularioVermelhoToolStripMenuItem.Text = "Exibir";
            this.formularioVermelhoToolStripMenuItem.Click += new System.EventHandler(this.formularioVermelhoToolStripMenuItem_Click);
            // 
            // exibformvermelho
            // 
            this.exibformvermelho.Name = "exibformvermelho";
            this.exibformvermelho.Size = new System.Drawing.Size(185, 22);
            this.exibformvermelho.Text = "Formulario vermelho";
            this.exibformvermelho.Click += new System.EventHandler(this.exibformvermelho_Click);
            // 
            // exibformazul
            // 
            this.exibformazul.Name = "exibformazul";
            this.exibformazul.Size = new System.Drawing.Size(185, 22);
            this.exibformazul.Text = "formulario azul";
            this.exibformazul.Click += new System.EventHandler(this.exibformazul_Click);
            // 
            // exibfrmlaranja
            // 
            this.exibfrmlaranja.Name = "exibfrmlaranja";
            this.exibfrmlaranja.Size = new System.Drawing.Size(185, 22);
            this.exibfrmlaranja.Text = "Formulario laranja";
            this.exibfrmlaranja.Click += new System.EventHandler(this.exibfrmlaranja_Click);
            // 
            // FrmVermelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVermelho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formularioVermelhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibformvermelho;
        private System.Windows.Forms.ToolStripMenuItem exibformazul;
        private System.Windows.Forms.ToolStripMenuItem exibfrmlaranja;
    }
}