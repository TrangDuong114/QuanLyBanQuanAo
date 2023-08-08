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
    public partial class fNhaCungCap : Form
    {
        public fNhaCungCap()
        {
            InitializeComponent();
        }

        private void fNhaCungCap_Load(object sender, EventArgs e)
        {
            Hien();
           
        }
        //Hiện lên datagidview
        private void Hien()
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Lay_NCC", con))
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
        //hiện textbox
        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tenNCC.Text = dtg1.CurrentRow.Cells["Tên nhà cung cấp"].Value.ToString();
            txt_GD.Text = dtg1.CurrentRow.Cells["Tên giao dịch"].Value.ToString();
            txt_dc.Text = dtg1.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            txt_sdt.Text = dtg1.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            
        }
        //thêm
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
                cmd.CommandText = "insert into tblNhaCungCap(sTenNhaCC, sTengiaodich, sDiachi, sDienThoai)" +
                    "values (N'" + txt_tenNCC.Text + "',N'" + txt_GD.Text + "', N'" + txt_dc.Text + "', N'" + txt_sdt.Text + "' )";
                //check trống
                if (txt_tenNCC.Text.Trim().Length == 0 || txt_GD.Text.Trim().Length == 0 || txt_dc.Text.Trim().Length == 0 || txt_sdt.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin");
                    return;
                }
                //check trùng
                if(check_tsdt() == false )
                {
                    ck_sdt.Text = "Đã có số điện thoại";
                    return;
                }
                MessageBox.Show("Them thanh cong");
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {

            }
            Hien();
        }
        //check trùng sdt
        private bool check_tsdt()
        {
            string ma = txt_sdt.Text;
            int i;
            for (i = 0; i < dtg1.Rows.Count - 1; i++)
            {
                if (dtg1.Rows[i].Cells["Số điện thoại"].Value.ToString() == ma)
                {
                    return false;

                }
            }
            return true;
        }
   
        

        
        //Xóa
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
                    String ncc = txt_tenNCC.Text;
                    string dt = txt_sdt.Text;
                    cmd.CommandText = "delete from tblNhaCungCap where sTenNhaCC = N'" + ncc + "' and sDienThoai = '" + dt + "'  ";
                    int y = cmd.ExecuteNonQuery();
                    if (y > 0)
                    {
                        MessageBox.Show("Xoa thanh cong");
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Xóa thất bại - đã có mã hàng"); }
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

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*string sdt = txt_sdt.Text;
            if (!char.IsDigit(e.KeyChar))
            {
                ck_sdt.Text = "Nhập sai định dạnh";
                e.Handled = true;
            }
            else
                ck_sdt.Text = "";*/
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain f_m = new fMain();
            f_m.ShowDialog();
            this.Close();
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
                String gd = txt_GD.Text;
                string ma = dtg1.CurrentRow.Cells["Mã nhà cung cấp"].Value.ToString();
                cmd.CommandText = "update tblNhaCungCap set sTengiaodich = N'" + gd + "' where iMaNCC = N'" + ma + "' ";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
