namespace AppMenu
{
    partial class Frmlaranja
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibformlaranja = new System.Windows.Forms.ToolStripMenuItem();
            this.exibformazuçl = new System.Windows.Forms.ToolStripMenuItem();
            this.exibformvermelho = new System.Windows.Forms.ToolStripMenuItem();
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
            this.exibformlaranja,
            this.exibformazuçl,
            this.exibformvermelho});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // exibformlaranja
            // 
            this.exibformlaranja.Name = "exibformlaranja";
            this.exibformlaranja.Size = new System.Drawing.Size(185, 22);
            this.exibformlaranja.Text = "Formulario laranja";
            this.exibformlaranja.Click += new System.EventHandler(this.exibformlaranja_Click);
            // 
            // exibformazuçl
            // 
            this.exibformazuçl.Name = "exibformazuçl";
            this.exibformazuçl.Size = new System.Drawing.Size(185, 22);
            this.exibformazuçl.Text = "Formulario Azul";
            this.exibformazuçl.Click += new System.EventHandler(this.exibformazuçl_Click);
            // 
            // exibformvermelho
            // 
            this.exibformvermelho.Name = "exibformvermelho";
            this.exibformvermelho.Size = new System.Drawing.Size(185, 22);
            this.exibformvermelho.Text = "Formulario Vermelho";
            this.exibformvermelho.Click += new System.EventHandler(this.exibformvermelho_Click);
            // 
            // Frmlaranja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmlaranja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibformlaranja;
        private System.Windows.Forms.ToolStripMenuItem exibformazuçl;
        private System.Windows.Forms.ToolStripMenuItem exibformvermelho;
    }
}

