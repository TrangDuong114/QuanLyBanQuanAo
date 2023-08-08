namespace BTL
{
    partial class fLoaiHang
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
            this.dtg1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_LH = new System.Windows.Forms.TextBox();
            this.txt_maLH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ck_ma = new System.Windows.Forms.Label();
            this.ck_lh = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
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
            this.dtg1.Location = new System.Drawing.Point(45, 217);
            this.dtg1.Name = "dtg1";
            this.dtg1.RowHeadersWidth = 51;
            this.dtg1.RowTemplate.Height = 24;
            this.dtg1.ShowCellToolTips = false;
            this.dtg1.Size = new System.Drawing.Size(725, 157);
            this.dtg1.TabIndex = 50;
            this.dtg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg1_CellClick);
            this.dtg1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Loại hàng";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã loại hàng";
            // 
            // txt_LH
            // 
            this.txt_LH.Location = new System.Drawing.Point(540, 118);
            this.txt_LH.Name = "txt_LH";
            this.txt_LH.Size = new System.Drawing.Size(157, 22);
            this.txt_LH.TabIndex = 15;
            this.txt_LH.Validating += new System.ComponentModel.CancelEventHandler(this.txt_LH_Validating);
            // 
            // txt_maLH
            // 
            this.txt_maLH.Location = new System.Drawing.Point(157, 118);
            this.txt_maLH.Name = "txt_maLH";
            this.txt_maLH.Size = new System.Drawing.Size(157, 22);
            this.txt_maLH.TabIndex = 14;
            this.txt_maLH.Validating += new System.ComponentModel.CancelEventHandler(this.txt_maLH_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "Danh sách";
            // 
            // ck_ma
            // 
            this.ck_ma.AutoSize = true;
            this.ck_ma.ForeColor = System.Drawing.Color.Red;
            this.ck_ma.Location = new System.Drawing.Point(330, 123);
            this.ck_ma.Name = "ck_ma";
            this.ck_ma.Size = new System.Drawing.Size(0, 17);
            this.ck_ma.TabIndex = 26;
            // 
            // ck_lh
            // 
            this.ck_lh.AutoSize = true;
            this.ck_lh.ForeColor = System.Drawing.Color.Red;
            this.ck_lh.Location = new System.Drawing.Point(713, 125);
            this.ck_lh.Name = "ck_lh";
            this.ck_lh.Size = new System.Drawing.Size(0, 17);
            this.ck_lh.TabIndex = 52;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_thoat.Location = new System.Drawing.Point(643, 399);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(79, 36);
            this.btn_thoat.TabIndex = 90;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_xoa.Location = new System.Drawing.Point(471, 399);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(79, 36);
            this.btn_xoa.TabIndex = 89;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_sua.Location = new System.Drawing.Point(301, 399);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(79, 36);
            this.btn_sua.TabIndex = 88;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_them.Location = new System.Drawing.Point(127, 399);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(79, 36);
            this.btn_them.TabIndex = 87;
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
            this.panelTitleBar.TabIndex = 91;
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
            this.lblTitle.Size = new System.Drawing.Size(237, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông tin loại hàng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.ck_lh);
            this.Controls.Add(this.ck_ma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_LH);
            this.Controls.Add(this.txt_maLH);
            this.Controls.Add(this.dtg1);
            this.Name = "fLoaiHang";
            this.Text = "Form_LoaiHang";
            this.Load += new System.EventHandler(this.Form_LoaiHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_LH;
        private System.Windows.Forms.TextBox txt_maLH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ck_ma;
        private System.Windows.Forms.Label ck_lh;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
    }
}

