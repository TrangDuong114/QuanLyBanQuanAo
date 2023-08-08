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
    public partial class fKhachHang : Form
    {
        public fKhachHang()
        {
            InitializeComponent();
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            Hien();
            
        }

        private void Hien()
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand("Select * from Lay_KH", con))
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


        //
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into tblKhachHang(iMaKH, sTenKh, sDiachi, sDienthoai)" +
                    "values (N'" + txt_ma.Text + "', N'" + txt_ten.Text + "', N'" + txt_dc.Text + "', N'" + txt_sdt.Text + "')";
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Them thanh cong");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them 0 thanh cong");
            }
            Hien();
        }

        //Sửa số điện thoại
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
                cmd.CommandText = "update tblKhachHang set sDienthoai = N'" + sdt + "' where iMaKH = N'" + ma + "' ";
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
                    cmd.CommandText = "delete from tblKhachHang where sTenKH = N'" + ten + "' and iMaKh = N'" + ma + "'   ";
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

        //
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain f_m = new fMain();
            f_m.ShowDialog();
            this.Close();
        }

        private void dtg1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma.Text = dtg1.CurrentRow.Cells["Mã khách hàng"].Value.ToString();
            txt_ten.Text = dtg1.CurrentRow.Cells["Tên khách hàng"].Value.ToString();
            txt_dc.Text = dtg1.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            txt_sdt.Text = dtg1.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            txt_dh.Text = dtg1.CurrentRow.Cells["Số đơn hàng"].Value.ToString();
            ck_xoa();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
       private void ck_xoa()
        {
           
            int ck = int.Parse( txt_dh.Text);
            if (ck <= 0)
            {
                btn_xoa.Enabled = true;
            }
            else
            {
                btn_xoa.Enabled = false;
            }
        }

        private void btn_rp_Click(object sender, EventArgs e)
        {
            this.Hide();
            fThi f_thi = new fThi(txt_ma.Text);
            f_thi.ShowDialog();
            this.Close();


        }
    }
}
