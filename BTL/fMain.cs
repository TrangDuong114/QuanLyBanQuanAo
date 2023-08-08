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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
       

        }

        public fMain(string v)
        {
            InitializeComponent();
            lb_ten.Text = v;

        }
        private void btn_dbh_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDonDatHang f_dh = new fDonDatHang();
            f_dh.ShowDialog();
            this.Close();
        }

        private void btn_kh_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMatHang f_mh = new fMatHang();
            f_mh.ShowDialog();
            this.Close();
        }

        private void btn_lh_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLoaiHang f_lh = new fLoaiHang();
            f_lh.ShowDialog();
            this.Close();
        }

        private void btn_ncc_Click(object sender, EventArgs e)
        {
            this.Hide();
            fNhaCungCap f_ncc = new fNhaCungCap();
            f_ncc.ShowDialog();
            this.Close();
        }

        private void btn_dnh_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDonNhapHang f_nh = new fDonNhapHang();
            f_nh.ShowDialog();
            this.Close();
        }

        private void btn_rp_Click(object sender, EventArgs e)
        {
            this.Hide();
            fReport f_rp = new fReport();
            f_rp.ShowDialog();
            this.Close();
        }

        private void btn_TTKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            fKhachHang f_kh = new fKhachHang();
            f_kh.ShowDialog();
            this.Close();
        }

        private void btn_dx_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            this.Hide();
            fDangNhap f_dn = new fDangNhap();
            f_dn.ShowDialog();
            this.Close();
        }

        private void btn_nv_Click(object sender, EventArgs e)
        {
            this.Hide();
            fNhanVien f_nv = new fNhanVien();
            f_nv.ShowDialog();
            this.Close();
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
