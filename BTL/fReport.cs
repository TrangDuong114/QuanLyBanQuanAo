using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain f_m = new fMain();
            f_m.ShowDialog();
            this.Close();
        }

        private void btn_rp_ctDH_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_RP_CTDH f_ctdh = new f_RP_CTDH();
            f_ctdh.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_RP_gia f_gia = new f_RP_gia();
            f_gia.ShowDialog();
            this.Close();
        }
    }
}
