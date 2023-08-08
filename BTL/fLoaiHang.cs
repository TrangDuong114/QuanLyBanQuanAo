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
    public partial class fLoaiHang : Form
    {
        public fLoaiHang()
        {
            InitializeComponent();
        }

        private void Form_LoaiHang_Load(object sender, EventArgs e)
        { 
            Hien();   
        }

        //Hiện lên datagidview
        private void Hien()
        {
            /*string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand("Select * from Lay_LH", con))
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
            }*/
            HamDungChung kn = new HamDungChung();
            kn.ketnoi();
            DataTable dt = kn.getTable("select * from Lay_LH ");
            dtg1.DataSource = dt;

        }


        //Ấn vào cột thì lấy được dữ liệu
        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maLH.Text = dtg1.CurrentRow.Cells["Mã loại hàng"].Value.ToString();
            txt_LH.Text = dtg1.CurrentRow.Cells["Tên loại hàng"].Value.ToString();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Thêm Loại hàng
        
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
                cmd.CommandText = "insert into tblLoaiHang(sMaloaihang, sTenloaihang)" +
                    "values (N'" + txt_maLH.Text + "',N'" + txt_LH.Text + "' )";
               
                if  (txt_LH.Text.Trim().Length == 0 || txt_maLH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin");
                    if (txt_maLH.Text.Trim().Length == 0 && txt_LH.Text.Trim().Length == 0)
                    {
                        ck_lh.Text = "Trống";
                        ck_ma.Text = "Trống";
                    }
                    else if (txt_maLH.Text.Trim().Length == 0)
                    {
                        ck_ma.Text = "Trống";
                        ck_lh.Text = "";
                    }
                    else
                    {
                        ck_lh.Text = "Trống";
                        ck_ma.Text = "";
                    }

                    return;
                }
                if (checkMa() == false)
                {
                    ck_ma.Text = "Mã hàng đã tồn tại";
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
        //check trùng mã loại hàng
        private bool checkMa()
        {
            string maLH = txt_maLH.Text;
            int i ;
            for(i = 0; i< dtg1.Rows.Count - 1; i++ )
            {
                if (dtg1.Rows[i].Cells["Mã loại hàng"].Value.ToString() == maLH)
                {
                    return false;
                    
                }
            }
            return true;
        }


        private void dtg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //sửa tên loại hàng
        private void Sua()
        {
          
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                String lhm = txt_LH.Text;
                string mlh = txt_maLH.Text;
                cmd.CommandText = "update tblLoaiHang set sTenloaihang = N'" + lhm + "' where sMaloaihang = N'" + mlh + "' ";
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

        //xóa loại hàng
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
                    String lh = txt_LH.Text;
                    cmd.CommandText = "delete from tblLoaiHang where sTenloaihang = N'" + lh + "'  ";
                    int y = cmd.ExecuteNonQuery();
                    if (y > 0)
                    {
                        MessageBox.Show("Xoa thanh cong");
                    }
                    
                    con.Close();
                }
            } catch (Exception ex) 
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


        private void txt_maLH_Validating(object sender, CancelEventArgs e)
        {
           /* if (txt_LH.Text == "")
                errorProvider1.SetError(txt_LH, "Bạn phải nhập loại hàng!");
            else
                errorProvider1.SetError(txt_LH, "");*/
        }

        private void txt_LH_Validating(object sender, CancelEventArgs e)
        {
            /*if (txt_maLH.Text == "")
                errorProvider1.SetError(txt_maLH, "Bạn phải nhập mã loại hàng!");
            if (checkMa() == false)
                errorProvider1.SetError(txt_maLH, "mã loại hàng trùng!");
           
            else
            {   
                errorProvider1.SetError(txt_maLH, "");
            }*/
        }
        //quay lại main
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain f_m = new fMain();
            f_m.ShowDialog();
            this.Close();
        }

       
    }
}
