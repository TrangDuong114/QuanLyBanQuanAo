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
    public partial class fChiTietDatHang : Form
    {
        public fChiTietDatHang()
        {
            InitializeComponent();
         
        }
        public fChiTietDatHang(string v)
        {
            InitializeComponent();
            cb_soHD.Text = v;
        }
        

        private void fChiTietDatHang_Load(object sender, EventArgs e)
        {
            Lay_MH();
            Hien();
            
        }
        private void Lay_MH()
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblMatHang", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("MaHang");
                        ad.Fill(tb);
                        cb_maH.DataSource = tb;
                        cb_maH.DisplayMember = "sMaHang";
                        cb_maH.ValueMember = "sMaHang";

                    }
                }

            }
        }
        private void Hien()
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand("select * from Lay_CTDH where Lay_CTDH.[Số hóa đơn] = '" + cb_soHD.Text + "'", con))
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
        //bỏ
        /*private void doimau()
        {
            dtg1.Rows[0].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            string a = dtg1.Rows[0].Cells["Số hóa đơn"].Value.ToString();
            
            

            for (int i = 1; i < dtg1.Rows.Count  ; i++)
            {
                string b = dtg1.Rows[i].Cells["Số hóa đơn"].Value.ToString();

                if (b != a)
                {
                    a = b;
                    dtg1.Rows[i].DefaultCellStyle.BackColor = Color.LightSeaGreen ;
                }
            }
        }*/
        //
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();         
            fDonDatHang f_dh = new fDonDatHang();
            f_dh.ShowDialog();
            this.Close();

        }
        
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "";
                cmd.Connection = con;

               
                cmd.CommandText = "insert into tblChiTietDatHang(iSoHD, sMahang, fGiaban, fSoluongmua, fMucgiamgia)" +
                    "values (N'" + cb_soHD.Text + "', N'" + cb_maH.Text + "'," + txt_gia.Text + "," + txt_sl.Text + ", " + txt_gg.Text + ")";

                if (txt_gia.Text.Trim().Length == 0 || txt_sl.Text.Trim().Length == 0 || txt_gg.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin");
                    return;
                }
                if (checkMa() == false)
                {
                    MessageBox.Show("Đã có mã hàng trong hóa đơn");
                    return;
                }
                else
                {
                    int y = cmd.ExecuteNonQuery();
                    if (y > 0)
                    {
                        MessageBox.Show("Them thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Them khong thanh cong");
                    }
                }
                Hien();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private bool checkMa()
        {
            string ma = cb_maH.Text;
            int i;
            for (i = 0; i < dtg1.Rows.Count - 1; i++)
            {
                if (dtg1.Rows[i].Cells["Mặt hàng"].Value.ToString() == ma)
                {
                    return false;

                }
            }
            return true;
        }
        //Sửa số lượng 
        private void Sua()
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                String sohd = cb_soHD.Text;
                string mh = cb_maH.Text;
                float slm = float.Parse( txt_sl.Text);
                cmd.CommandText = "update tblChiTietDatHang set fSoluongmua = N'" + slm + "' where sMahang = N'" + mh + "' and iSoHD = N'" + sohd + "' ";
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
        //Xóa chi tiết đặt hàng
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
                    String mh = cb_maH.Text;
                    string hd = cb_soHD.Text;
                    cmd.CommandText = "delete from tblChiTietDatHang where sMaHang = N'" + mh + "' and iSoHD = N'" + hd + "'   ";
                    int y = cmd.ExecuteNonQuery();
                    if (y > 0)
                    {
                        MessageBox.Show("Xoa thanh cong");
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {  }

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
        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_soHD.Text = dtg1.CurrentRow.Cells["Số hóa đơn"].Value.ToString();
            cb_maH.SelectedValue = dtg1.CurrentRow.Cells["Mặt hàng"].Value.ToString();
            txt_gia.Text = dtg1.CurrentRow.Cells["Đơn giá"].Value.ToString();
            txt_sl.Text = dtg1.CurrentRow.Cells["Số lượng"].Value.ToString();
            txt_gg.Text = dtg1.CurrentRow.Cells["Mức giảm giá"].Value.ToString();   
        }
    }

        
}

