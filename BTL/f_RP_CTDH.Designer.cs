﻿
namespace BTL
{
    partial class f_RP_CTDH
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cb_sohd = new System.Windows.Forms.ComboBox();
            this.btn_in = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // cb_sohd
            // 
            this.cb_sohd.FormattingEnabled = true;
            this.cb_sohd.Location = new System.Drawing.Point(168, 12);
            this.cb_sohd.Name = "cb_sohd";
            this.cb_sohd.Size = new System.Drawing.Size(121, 24);
            this.cb_sohd.TabIndex = 1;
            // 
            // btn_in
            // 
            this.btn_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_in.ForeColor = System.Drawing.Color.White;
            this.btn_in.Location = new System.Drawing.Point(308, 5);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(79, 36);
            this.btn_in.TabIndex = 2;
            this.btn_in.Text = "IN";
            this.btn_in.UseVisualStyleBackColor = false;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số hóa đơn";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(715, 15);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(73, 33);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // f_RP_CTDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.cb_sohd);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "f_RP_CTDH";
            this.Text = "f_CP_CTHD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox cb_sohd;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thoat;
    }
}