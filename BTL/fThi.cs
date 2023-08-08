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
using CrystalDecisions.CrystalReports.Engine;

namespace BTL
{
    public partial class fThi : Form
    {
        public fThi()
        {
            InitializeComponent();
        }
        public fThi(string v)
        {
            InitializeComponent();
            
            txt_ma.Text = v;
        }

        private void fThi_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "thi";
                    cmd.Parameters.AddWithValue("@maKH", txt_ma.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable dt = new System.Data.DataTable();
                        ad.Fill(dt);
                        Rp_thi rpt = new Rp_thi();
                        rpt.SetDataSource(dt);
                        crystalReportViewer1.ReportSource = rpt;
                        crystalReportViewer1.Refresh();
                    }
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            fKhachHang f_rp = new fKhachHang();
            f_rp.ShowDialog();
            this.Close();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            
        }
    }
}
