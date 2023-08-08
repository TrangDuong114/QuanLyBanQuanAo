
namespace BTL
{
    partial class fDonNhapHang
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
            this.label10 = new System.Windows.Forms.Label();
            this.dtg1 = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_nhap = new System.Windows.Forms.DateTimePicker();
            this.cb_nv = new System.Windows.Forms.ComboBox();
            this.txt_soHD = new System.Windows.Forms.TextBox();
            this.btn_ct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(39, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 27);
            this.label10.TabIndex = 112;
            this.label10.Text = "Danh sách";
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
            this.dtg1.Location = new System.Drawing.Point(36, 224);
            this.dtg1.Name = "dtg1";
            this.dtg1.RowHeadersWidth = 51;
            this.dtg1.RowTemplate.Height = 24;
            this.dtg1.ShowCellToolTips = false;
            this.dtg1.Size = new System.Drawing.Size(725, 157);
            this.dtg1.TabIndex = 111;
            this.dtg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg1_CellClick);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_thoat.Location = new System.Drawing.Point(615, 398);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(79, 36);
            this.btn_thoat.TabIndex = 110;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_xoa.Location = new System.Drawing.Point(443, 398);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(79, 36);
            this.btn_xoa.TabIndex = 109;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_sua.Location = new System.Drawing.Point(273, 398);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(79, 36);
            this.btn_sua.TabIndex = 108;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_them.Location = new System.Drawing.Point(99, 398);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(79, 36);
            this.btn_them.TabIndex = 107;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(800, 45);
            this.panelTitleBar.TabIndex = 113;
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
            this.lblTitle.Size = new System.Drawing.Size(188, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đơn nhập hàng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 114;
            this.label1.Text = "Số hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 115;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 116;
            this.label3.Text = "Ngày nhập hàng";
            // 
            // dtp_nhap
            // 
            this.dtp_nhap.CausesValidation = false;
            this.dtp_nhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nhap.Location = new System.Drawing.Point(472, 79);
            this.dtp_nhap.Name = "dtp_nhap";
            this.dtp_nhap.Size = new System.Drawing.Size(200, 22);
            this.dtp_nhap.TabIndex = 117;
            this.dtp_nhap.Value = new System.DateTime(2023, 5, 7, 0, 0, 0, 0);
            // 
            // cb_nv
            // 
            this.cb_nv.FormattingEnabled = true;
            this.cb_nv.Location = new System.Drawing.Point(168, 116);
            this.cb_nv.Name = "cb_nv";
            this.cb_nv.Size = new System.Drawing.Size(91, 24);
            this.cb_nv.TabIndex = 118;
            // 
            // txt_soHD
            // 
            this.txt_soHD.Location = new System.Drawing.Point(168, 79);
            this.txt_soHD.Name = "txt_soHD";
            this.txt_soHD.Size = new System.Drawing.Size(91, 22);
            this.txt_soHD.TabIndex = 119;
            // 
            // btn_ct
            // 
            this.btn_ct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_ct.ForeColor = System.Drawing.Color.White;
            this.btn_ct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ct.Location = new System.Drawing.Point(476, 116);
            this.btn_ct.Name = "btn_ct";
            this.btn_ct.Size = new System.Drawing.Size(196, 50);
            this.btn_ct.TabIndex = 120;
            this.btn_ct.Text = "Chi tiết nhập hàng";
            this.btn_ct.UseVisualStyleBackColor = false;
            this.btn_ct.Click += new System.EventHandler(this.btn_ct_Click);
            // 
            // fDonNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ct);
            this.Controls.Add(this.txt_soHD);
            this.Controls.Add(this.cb_nv);
            this.Controls.Add(this.dtp_nhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtg1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Name = "fDonNhapHang";
            this.Text = "fDonNhapHang";
            this.Load += new System.EventHandler(this.fDonNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtg1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_nhap;
        private System.Windows.Forms.ComboBox cb_nv;
        private System.Windows.Forms.TextBox txt_soHD;
        private System.Windows.Forms.Button btn_ct;
    }
}