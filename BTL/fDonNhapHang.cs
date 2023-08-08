using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BTL
{
    public partial class fDonNhapHang : Form
    {
        public fDonNhapHang()
        {
            InitializeComponent();
        }
        public fDonNhapHang(string v)
        {
            InitializeComponent();
            txt_soHD.Text = v;
        }

        private void fDonNhapHang_Load(object sender, EventArgs e)
        {
            LayMaNV();
            Hien();
        }

        private void LayMaNV()
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblNhanVien", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("MaNV");
                        ad.Fill(tb);
                        cb_nv.DataSource = tb;
                        cb_nv.DisplayMember = "iMaNV";
                        cb_nv.ValueMember = "iMaNV";

                    }
                }
            }
        }
        private void Hien()
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Lay_DNH", con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dtg1.DataSource = tb;

                    }
                }

            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {

                string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
                //để mở kết nói tới sql
                SqlConnection con = new SqlConnection(constr);
                //để thực hiện các lệnh truy ván

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "insert into tblDonNhapHang(iSoHD, iMaNV, dNgaynhaphang )" +
                     "values (N'" + txt_soHD.Text + "',N'" + cb_nv.Text + "','" + dtp_nhap.Value + "' )";
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Them thanh cong");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them khong thanh cong");
            }
            Hien();
        }
        //
        private void Sua()
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                string shd = txt_soHD.Text;
                string nvm = cb_nv.Text;

                cmd.CommandText = "update tblDonNhapHang set iMaNV = N'" + nvm + "' where iSoHD = N'" + shd + "' ";

                int y = cmd.ExecuteNonQuery();
                if (y > 0)
                {
                    MessageBox.Show("Sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Sua khong thanh cong");
                }
                con.Close();

            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            Sua();
            Hien();
        }
        //
        private void Xoa()
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "";
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    string shd = txt_soHD.Text;
                    cmd.CommandText = "delete from tblDonNhapHang where iSoHD = N'" + shd + "'  ";
                    int y = cmd.ExecuteNonQuery();
                    if (y > 0)
                    {
                        MessageBox.Show("Xoa thanh cong");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Khong xoa thanh cong"); 
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Xoa();
            Hien();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain f_m = new fMain();
            f_m.ShowDialog();
            this.Close();
        }

        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_soHD.Text = dtg1.CurrentRow.Cells["Số hóa đơn"].Value.ToString();
            cb_nv.SelectedValue = dtg1.CurrentRow.Cells["Mã nhân viên"].Value.ToString();
            dtp_nhap.Text = dtg1.CurrentRow.Cells["Ngày nhập hàng"].Value.ToString();

        }

        private void btn_ct_Click(object sender, EventArgs e)
        {
            this.Hide();
            fChiTietNhapHang f_ct = new fChiTietNhapHang(txt_soHD.Text);
            f_ct.ShowDialog();
            this.Close();
        }
    }
}
