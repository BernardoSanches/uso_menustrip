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
    public partial class Frmlaranja : Form
    {
        public Frmlaranja()
        {
            InitializeComponent();
        }

        private void exibformlaranja_Click(object sender, EventArgs e)
        {
            Frmlaranja frm = new Frmlaranja();
            this.Hide();
            frm.ShowDialog();
        }

        private void exibformazuçl_Click(object sender, EventArgs e)
        {
            Frmazul frm = new Frmazul();
            this.Hide();
            frm.ShowDialog();
        }

        private void exibformvermelho_Click(object sender, EventArgs e)
        {
            FrmVermelho frm = new FrmVermelho();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
