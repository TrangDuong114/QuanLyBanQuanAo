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
    public partial class fDonDatHang : Form
    {
        public fDonDatHang()
        {
            InitializeComponent();
          
        }
        public fDonDatHang(string v)
        {
            InitializeComponent();
            txt_soHD.Text = v;
        }

        private void fDonDatHang_Load(object sender, EventArgs e)
        {
            Hien();
            Lay_CB();
        }
        //
        private void Hien()
        {
            HamDungChung kn = new HamDungChung();
            kn.ketnoi();
            DataTable dt = kn.getTable("select * from Lay_DDH ");
            dtg1.DataSource = dt;
        }
        //
        private void Lay_CB()
        {
            HamDungChung kn = new HamDungChung();
            kn.ketnoi();
            DataTable tb = kn.getTable("select * from tblNhanVien ");
            cb_nv.DataSource = tb;
            cb_nv.DisplayMember = "iMaNV";
            cb_nv.ValueMember = "iMaNV";
            DataTable mh = kn.getTable("select * from tblKhachHang ");
            cb_kh.DataSource = mh;
            cb_kh.DisplayMember = "iMaKH";
            cb_kh.ValueMember = "iMaKH";
        }
        //
        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_soHD.Text = dtg1.CurrentRow.Cells["Số hóa đơn"].Value.ToString();
            cb_nv.SelectedValue = dtg1.CurrentRow.Cells["Mã nhân viên"].Value.ToString();
            cb_kh.SelectedValue = dtg1.CurrentRow.Cells["Mã khách hàng"].Value.ToString();
            dtp_dat.Text = dtg1.CurrentRow.Cells["Ngày đặt hàng"].Value.ToString();
            dtp_giao.Text = dtg1.CurrentRow.Cells["Ngày giao hàng"].Value.ToString();
            txt_dc.Text = dtg1.CurrentRow.Cells["Địa chỉ"].Value.ToString();
        }
        //
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string contr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
                SqlConnection con = new SqlConnection(contr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into tblDonDatHang(iSoHD, iMaNV, iMaKH, dNgayDatHang, dNgayGiaoHang, sDiachiGiaoHang)" +
                    "values ('" + txt_soHD.Text + "','" + cb_nv.Text + "', '" + cb_kh.Text + "', N'" + dtp_dat.Value + "', " +
                    "N'" + dtp_giao.Value + "', N'" + txt_dc.Text + "' )";
                if (txt_soHD.Text.Trim().Length == 0 || txt_dc.Text.Trim().Length == 0 )
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin");
                    return;
                }
                if (checkMa() == false)
                {
                    MessageBox.Show("Thêm không thành công - Đã có số hóa đơn");
                    return;
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                con.Close();

            }
            catch (Exception ex)
            {
                
            }
            Hien();
        }
        //check trùng số hóa đơn
        private bool checkMa()
        {
            string ma = txt_soHD.Text;
            int i;
            for (i = 0; i < dtg1.Rows.Count - 1; i++)
            {
                if (dtg1.Rows[i].Cells["Số hóa đơn"].Value.ToString() == ma)
                {
                    return false;

                }
            }
            return true;
        }
        //Thay đổi địa chỉ
        private void Sua()
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                string dcm = txt_dc.Text;
                string hd = txt_soHD.Text;
                cmd.CommandText = "update tblDonDatHang set sDiachiGiaoHang = N'" + dcm + "' where iSoHd = N'" + hd + "' ";
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
                string contr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
                SqlConnection con = new SqlConnection(contr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                int hd = int.Parse( txt_soHD.Text);
                cmd.CommandText = "delete from tblDonDatHang where iSoHD = '" + hd + "' ";
                int i = cmd.ExecuteNonQuery();
                if(i > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa thất bại thành công - Đã có chi tiết đơn hàng ko thể xóa!");
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

        private void btn_ct_Click(object sender, EventArgs e)
        {
            this.Hide();
            fChiTietDatHang f_ct = new fChiTietDatHang(txt_soHD.Text);
            f_ct.ShowDialog();
            this.Close();
        }
    }
}
