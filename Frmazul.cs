using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMenu
{
    public partial class Frmazul : Form
    {
        public Frmazul()
        {
            InitializeComponent();
        }

        private void exibirFrmazul_Click(object sender, EventArgs e)
        {
            Frmazul frm = new Frmazul();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void exibirFrmVermelho_Click(object sender, EventArgs e)
        {
            FrmVermelho frm = new FrmVermelho();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void exibirFrmlaranja_Click(object sender, EventArgs e)
        {
            Frmlaranja frm = new Frmlaranja();
            this.Hide();
            frm.ShowDialog();
            
        }
    }
}
