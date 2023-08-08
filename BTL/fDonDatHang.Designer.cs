
namespace BTL
{
    partial class fDonDatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtg1 = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_kh = new System.Windows.Forms.ComboBox();
            this.cb_nv = new System.Windows.Forms.ComboBox();
            this.txt_soHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.dtp_dat = new System.Windows.Forms.DateTimePicker();
            this.dtp_giao = new System.Windows.Forms.DateTimePicker();
            this.btn_ct = new System.Windows.Forms.Button();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1043, 45);
            this.panelTitleBar.TabIndex = 92;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(281, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông tin đơn đặt hàng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtg1
            // 
            this.dtg1.AllowDrop = true;
            this.dtg1.AllowUserToAddRows = false;
            this.dtg1.AllowUserToDeleteRows = false;
            this.dtg1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg1.ColumnHeadersHeight = 29;
            this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtg1.Location = new System.Drawing.Point(43, 242);
            this.dtg1.Name = "dtg1";
            this.dtg1.RowHeadersWidth = 51;
            this.dtg1.RowTemplate.Height = 24;
            this.dtg1.ShowCellToolTips = false;
            this.dtg1.Size = new System.Drawing.Size(939, 172);
            this.dtg1.TabIndex = 93;
            this.dtg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg1_CellClick);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_thoat.Location = new System.Drawing.Point(800, 432);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(79, 36);
            this.btn_thoat.TabIndex = 97;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_xoa.Location = new System.Drawing.Point(587, 432);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(79, 36);
            this.btn_xoa.TabIndex = 96;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_sua.Location = new System.Drawing.Point(374, 432);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(79, 36);
            this.btn_sua.TabIndex = 95;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_them.Location = new System.Drawing.Point(161, 432);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(79, 36);
            this.btn_them.TabIndex = 94;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 27);
            this.label4.TabIndex = 98;
            this.label4.Text = "Danh sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "Số hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 100;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 101;
            this.label3.Text = "Mã khách hàng";
            // 
            // cb_kh
            // 
            this.cb_kh.FormattingEnabled = true;
            this.cb_kh.Location = new System.Drawing.Point(151, 144);
            this.cb_kh.Name = "cb_kh";
            this.cb_kh.Size = new System.Drawing.Size(60, 24);
            this.cb_kh.TabIndex = 102;
            // 
            // cb_nv
            // 
            this.cb_nv.FormattingEnabled = true;
            this.cb_nv.Location = new System.Drawing.Point(151, 104);
            this.cb_nv.Name = "cb_nv";
            this.cb_nv.Size = new System.Drawing.Size(60, 24);
            this.cb_nv.TabIndex = 103;
            // 
            // txt_soHD
            // 
            this.txt_soHD.Location = new System.Drawing.Point(151, 65);
            this.txt_soHD.Name = "txt_soHD";
            this.txt_soHD.Size = new System.Drawing.Size(60, 22);
            this.txt_soHD.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 105;
            this.label5.Text = "Ngày đặt hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 106;
            this.label6.Text = "Ngày giao hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 107;
            this.label7.Text = "Địa chỉ giao hàng";
            // 
            // txt_dc
            // 
            this.txt_dc.Location = new System.Drawing.Point(489, 151);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(200, 22);
            this.txt_dc.TabIndex = 108;
            // 
            // dtp_dat
            // 
            this.dtp_dat.CausesValidation = false;
            this.dtp_dat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dat.Location = new System.Drawing.Point(489, 70);
            this.dtp_dat.Name = "dtp_dat";
            this.dtp_dat.Size = new System.Drawing.Size(200, 22);
            this.dtp_dat.TabIndex = 109;
            this.dtp_dat.Value = new System.DateTime(2023, 5, 8, 0, 0, 0, 0);
            // 
            // dtp_giao
            // 
            this.dtp_giao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_giao.Location = new System.Drawing.Point(489, 111);
            this.dtp_giao.MinDate = new System.DateTime(1945, 1, 25, 23, 59, 59, 0);
            this.dtp_giao.Name = "dtp_giao";
            this.dtp_giao.Size = new System.Drawing.Size(200, 22);
            this.dtp_giao.TabIndex = 110;
            this.dtp_giao.Value = new System.DateTime(2023, 5, 8, 0, 0, 0, 0);
            // 
            // btn_ct
            // 
            this.btn_ct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_ct.ForeColor = System.Drawing.Color.White;
            this.btn_ct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ct.Location = new System.Drawing.Point(793, 68);
            this.btn_ct.Name = "btn_ct";
            this.btn_ct.Size = new System.Drawing.Size(164, 41);
            this.btn_ct.TabIndex = 111;
            this.btn_ct.Text = "Chi tiết đơn hàng";
            this.btn_ct.UseVisualStyleBackColor = false;
            this.btn_ct.Click += new System.EventHandler(this.btn_ct_Click);
            // 
            // fDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 488);
            this.Controls.Add(this.btn_ct);
            this.Controls.Add(this.dtp_giao);
            this.Controls.Add(this.dtp_dat);
            this.Controls.Add(this.txt_dc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_soHD);
            this.Controls.Add(this.cb_nv);
            this.Controls.Add(this.cb_kh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtg1);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "fDonDatHang";
            this.Text = "fDonDatHang";
            this.Load += new System.EventHandler(this.fDonDatHang_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dtg1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_kh;
        private System.Windows.Forms.ComboBox cb_nv;
        private System.Windows.Forms.TextBox txt_soHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.DateTimePicker dtp_dat;
        private System.Windows.Forms.DateTimePicker dtp_giao;
        private System.Windows.Forms.Button btn_ct;
    }
}