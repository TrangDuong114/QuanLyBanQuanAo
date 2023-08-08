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
    public partial class f_RP_CTDH : Form
    {
        public f_RP_CTDH()
        {
            InitializeComponent();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Hien_CTDH";
                    cmd.Parameters.AddWithValue("@soHD", cb_sohd.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable dt = new System.Data.DataTable();
                        ad.Fill(dt);
                        RP_CTDH rpt = new RP_CTDH();
                        rpt.SetDataSource(dt);
                        crystalReportViewer1.ReportSource = rpt;
                        crystalReportViewer1.Refresh();
                    }
                }
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            LayCB();
        }
        private void LayCB()
        {
            string constr = ConfigurationManager.ConnectionStrings["ql_ban_quan_ao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblDonDatHang", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("hoadon");
                        ad.Fill(tb);
                        cb_sohd.DataSource = tb;
                        cb_sohd.DisplayMember = "iSoHD";
                        cb_sohd.ValueMember = "iSoHD";
                    }
                }

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            fReport f_rp = new fReport();
            f_rp.ShowDialog();
            this.Close();
        }
    }
}
