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
    public partial class fNhanVien : Form
    {
        public fNhanVien()
        {
            InitializeComponent();
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            Hien();
        }

        //
        private void Hien()
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand("Select * from Lay_NV", con))
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
            txt_ma.Text = dtg1.CurrentRow.Cells["Mã nhân viên"].Value.ToString();
            txt_ten.Text = dtg1.CurrentRow.Cells["Tên nhân viên"].Value.ToString();
            txt_dc.Text = dtg1.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            txt_sdt.Text = dtg1.CurrentRow.Cells["Điện thoại"].Value.ToString();
            dt_nsinh.Text = dtg1.CurrentRow.Cells["Ngày sinh"].Value.ToString();
            dt_nlam.Text = dtg1.CurrentRow.Cells["Ngày vào làm"].Value.ToString();
            txt_luong.Text = dtg1.CurrentRow.Cells["Lương cơ bản"].Value.ToString();
            txt_pc.Text = dtg1.CurrentRow.Cells["Phụ cấp"].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            //float y = (dt_nlam.Value.Year - dt_nsinh.Value.Year)*365 + (dt_nlam.Value.Month - dt_nsinh.Value.Month)*30 + (dt_nlam.Value.Day - dt_nsinh.Value.Day);
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into tblNhanVien(iMaNV, sTenNV, sDiachi, sDienthoai, dNgaysinh, dNgayvaolam, fLuongcoban, fPhucap)" +
                    "values (N'" + txt_ma.Text + "', N'" + txt_ten.Text + "', N'" + txt_dc.Text + "', N'" + txt_sdt.Text + "'," +
                    " N'" + dt_nsinh.Value + "', N'" + dt_nlam.Value + "', N'" + txt_luong.Text + "', N'" + txt_pc.Text + "' )";
               
               /* if (y/365 < 18 )
                {
                    MessageBox.Show("Nhân viên phải trên 18t");
                    return;
                }*/
                int i = cmd.ExecuteNonQuery();
                if (i < 0)
                {
                    MessageBox.Show("Them 0 thanh cong");
                    return;
                }
                MessageBox.Show("Them thanh cong");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them 0 thanh cong");
            }
            Hien();
        }

        //sửa số điện thoại
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                string sdt = txt_sdt.Text;
                string ma = txt_ma.Text;
                cmd.CommandText = "update tblNhanVien set sDienthoai = N'" + sdt + "' where iMaNV = N'" + ma + "' ";
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
                    string ma = txt_ma.Text;
                    string ten = txt_ten.Text;
                    cmd.CommandText = "delete from tblNhanVien where sTenNV = N'" + ten + "' and iMaNV = N'" + ma + "'   ";
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
                MessageBox.Show("Xoa không thanh cong");
            }

        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult drl = MessageBox.Show("bạn có chắc chẵn muốn xoá không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (drl == DialogResult.OK)
            {
                Xoa();
                Hien();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain f_m = new fMain();
            f_m.ShowDialog();
            this.Close();
        }
    }
}
