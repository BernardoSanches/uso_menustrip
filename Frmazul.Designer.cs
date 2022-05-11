namespace AppMenu
{
    partial class Frmazul
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
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmazul = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmVermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmlaranja = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirFrmazul,
            this.exibirFrmVermelho,
            this.exibirFrmlaranja});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // exibirFrmazul
            // 
            this.exibirFrmazul.Name = "exibirFrmazul";
            this.exibirFrmazul.Size = new System.Drawing.Size(185, 22);
            this.exibirFrmazul.Text = "Formulario azul";
            this.exibirFrmazul.Click += new System.EventHandler(this.exibirFrmazul_Click);
            // 
            // exibirFrmVermelho
            // 
            this.exibirFrmVermelho.Name = "exibirFrmVermelho";
            this.exibirFrmVermelho.Size = new System.Drawing.Size(185, 22);
            this.exibirFrmVermelho.Text = "Formulario Vermelho";
            this.exibirFrmVermelho.Click += new System.EventHandler(this.exibirFrmVermelho_Click);
            // 
            // exibirFrmlaranja
            // 
            this.exibirFrmlaranja.Name = "exibirFrmlaranja";
            this.exibirFrmlaranja.Size = new System.Drawing.Size(185, 22);
            this.exibirFrmlaranja.Text = "Formulario laranja";
            this.exibirFrmlaranja.Click += new System.EventHandler(this.exibirFrmlaranja_Click);
            // 
            // Frmazul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmazul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmazul";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmazul;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmVermelho;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmlaranja;
    }
}