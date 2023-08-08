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
    public partial class fChiTietNhapHang : Form
    {
        public fChiTietNhapHang()
        {
            InitializeComponent();
        }
        public fChiTietNhapHang(string v)
        {
            InitializeComponent();
            cb_shd.Text = v;
        }

        private void fChiTietNhapHang_Load(object sender, EventArgs e)
        {
            LayMaHang();
            
            hien();
        }
        
        //
        private void LayMaHang()
        {
            String constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblMatHang", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        cb_mahang.DataSource = tb;
                        cb_mahang.DisplayMember = "sMaHang";
                        cb_mahang.ValueMember = "sMaHang";
                    }
                }
            }
        }
        //
        private void hien()
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from Lay_CTNH where Lay_CTNH.[Số hóa đơn] = '" + cb_shd.Text + "'", con))
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

        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_shd.Text = dtg1.CurrentRow.Cells["Số hóa đơn"].Value.ToString();
            cb_mahang.SelectedValue = dtg1.CurrentRow.Cells["Mã hàng"].Value.ToString();
            txt_gia.Text = dtg1.CurrentRow.Cells["Giá nhập"].Value.ToString();
            txt_solg.Text = dtg1.CurrentRow.Cells["Số lượng nhập"].Value.ToString();
        }
        //
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
                cmd.CommandText = "insert into tblChiTietNhapHang(iSoHD, sMahang, fGianhap, fSoluongnhap  )" +
                    "values (N'" + cb_shd.Text + "',N'" + cb_mahang.Text + "', '" + txt_gia.Text + "', '" + txt_solg.Text + "')";
                if (txt_gia.Text.Trim().Length == 0 || txt_solg.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin");
                    return;
                }
                MessageBox.Show("Thêm thành công");
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {
                
            }
            hien();
        }
        //
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                string shd = cb_shd.Text;
                string mahang = cb_mahang.Text;
                string slm = txt_solg.Text;
                cmd.CommandText = "update tblChiTietNhapHang set fSoluongnhap = N'" + slm + "' " +
                    "where iSoHD = N'" + shd + "' and sMaHang = N'" + mahang + "' ";
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
                hien();
            }
        }
        //
        private void btn_xoa_Click(object sender, EventArgs e)
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
                    string shd = cb_shd.Text;
                    string mh = cb_mahang.Text;
                    cmd.CommandText = "delete from tblChiTietNhapHang where iSoHD = '" + shd + "' and sMaHang = '" + mh + "'  ";
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
                MessageBox.Show("Xóa thất bại - đã có mã hàng");
            }
            hien();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDonNhapHang f_m = new fDonNhapHang();
            f_m.ShowDialog();
            this.Close();
        }
    }
}
