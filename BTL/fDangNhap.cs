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
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
       
        }
        public fDangNhap(string v)
        {
            InitializeComponent();
            txt_ten.Text = v;
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            string ten = "Trang";
            string mk = "trang";
            if (txt_ten.Text.Trim() == "" || txt_mk.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ tên đăng nhập và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txt_ten.Text.Trim().Equals(ten) && txt_mk.Text.Trim().Equals(mk))
            {
                this.Hide();
                fMain f_m = new fMain(txt_ten.Text);
                f_m.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai mật khẩu hoặc tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
