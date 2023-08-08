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
    internal class HamDungChung
    {
        public string str = @"Data Source=LAPTOP-IAR1C4P7\SQLEXPRESS;Initial Catalog=QuanLyCuaHangQuanAo;Integrated Security=True";
        public SqlConnection con = new SqlConnection();
        //kết nối
        public bool ketnoi()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.ConnectionString = str;
                con.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối csdl", "Thông báo");
                return false;
            }
            return true;
        }
        //lấy dữ liệu lên girdview
        public DataTable getTable(string sql)
        {
            SqlDataAdapter ad = new SqlDataAdapter( sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        //ccombobox
        public void loadCBB(ComboBox cbb, string sql,string cot)

        {

            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            cbb.DataSource = tb;
            cbb.ValueMember = tb.Columns["cot"].ColumnName;
            cbb.DisplayMember = tb.Columns["cot"].ColumnName;
        }


    }
}
