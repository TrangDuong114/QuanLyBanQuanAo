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
    public partial class fMatHang : Form
    {
        public fMatHang()
        {
            InitializeComponent();
        }
        

        private void fMatHang_Load(object sender, EventArgs e)
        {
            Lay_maNCC();
            Lay_maLH();
            
            Hien();
            
        }
        //Láy mã nhà cung cấp
        private void Lay_maNCC()
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select*from tblNhaCungCap", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("NCC");
                        ad.Fill(tb);
                        cb_maNCC.DataSource = tb;
                        cb_maNCC.DisplayMember = "iMaNCC";
                        cb_maNCC.ValueMember = "iMaNCC";
                    }
                }
            }
        }
        //Lấy mã loại hàng
        private void Lay_maLH()
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select*from tblLoaiHang", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("Loaihang");
                        ad.Fill(tb);
                        cb_maLH.DataSource = tb;
                        cb_maLH.DisplayMember = "sMaloaihang";
                        cb_maLH.ValueMember = "sMaloaihang";
                    }
                }
            }
        }
        //Hiện lên datagidview
        public void Hien()
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Lay_MH", con))
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
        //lấy lên textbox
        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma.Text = dtg1.CurrentRow.Cells["Mã hàng"].Value.ToString();
            txt_ten.Text = dtg1.CurrentRow.Cells["Tên mặt hàng"].Value.ToString();
            txt_sz.Text = dtg1.CurrentRow.Cells["Size"].Value.ToString();
            txt_mau.Text = dtg1.CurrentRow.Cells["Màu sắc"].Value.ToString();
            cb_maNCC.SelectedValue = dtg1.CurrentRow.Cells["Mã NCC"].Value.ToString();
            cb_maLH.SelectedValue = dtg1.CurrentRow.Cells["Mã loại hàng"].Value.ToString();
            txt_sl.Text = dtg1.CurrentRow.Cells["Số lượng"].Value.ToString();
            txt_dv.Text = dtg1.CurrentRow.Cells["Đơn vị"].Value.ToString();
            txt_dg.Text = dtg1.CurrentRow.Cells["Đơn giá"].Value.ToString();
        }
        //Thêm
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {

                string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into tblMatHang(sMahang, sTenHang, sSize, sMauSac, iMaNCC, sMaloaihang, fSoluong, sDonvitinh, fGiahang)" +
                    "values (N'" + txt_ma.Text + "',N'" + txt_ten.Text + "', N'" + txt_sz.Text + "', N'" + txt_mau.Text + "', '" +cb_maNCC.Text+ "'," +
                    " '" + cb_maLH.Text + "', '" + txt_sl.Text + "', N'" + txt_dv.Text + "', '" + txt_dg.Text + "')";

                if (txt_ma.Text.Trim().Length == 0 || txt_ten.Text.Trim().Length == 0 || txt_sz.Text.Trim().Length == 0
                    || txt_mau.Text.Trim().Length == 0 || txt_sl.Text.Trim().Length == 0 || txt_dv.Text.Trim().Length == 0 || txt_dg.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin");
                    return;
                }
                if (checkMa() == false)
                {
                    ck_ma.Text = "Trùng";
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
        ////check trùng mã loại hàng
        private bool checkMa()
        {
            string ma = txt_ma.Text;
            int i;
            for (i = 0; i < dtg1.Rows.Count - 1; i++)
            {
                if (dtg1.Rows[i].Cells["Mã hàng"].Value.ToString() == ma)
                {
                    return false;

                }
            }
            return true;
        }
        //thoát
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain f_m = new fMain();
            f_m.ShowDialog();
            this.Close();
        }
        //sửa tên mặt hàng
        private void Sua()
        {
            try { 
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    String ten = txt_ten.Text;
                    string ma = txt_ma.Text;
                    cmd.CommandText = "update tblMatHang set sTenHang = N'" + ten + "' where sMahang = N'" + ma + "' ";
                    int y = cmd.ExecuteNonQuery();
                    
                    con.Close(); 
                }
            } catch(Exception ex)
            {

            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            Sua();
            Hien();
           
        }
        //Xóa
        private void Xoa()
        {
            
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    string tmh = txt_ten.Text;
                    cmd.CommandText = "delete from tblMatHang where sTenhang = N'" + tmh + "'";
                    int y = cmd.ExecuteNonQuery();
                    if (y > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    cmd.Clone();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thành công");
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Xoa();
            Hien();
        }
        
        
        
        
        
    }
}
