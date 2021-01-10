
namespace ltudql1
{
    partial class FrmHocSinh
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
            this.tabControlHocSinh = new System.Windows.Forms.TabControl();
            this.tabLamBai = new System.Windows.Forms.TabPage();
            this.tabPageThongTin = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonInBangDiem = new System.Windows.Forms.Button();
            this.tabPageDongGopCauHoi = new System.Windows.Forms.TabPage();
            this.tabControlHocSinh.SuspendLayout();
            this.tabLamBai.SuspendLayout();
            this.tabPageThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxThongTinChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlHocSinh
            // 
            this.tabControlHocSinh.Controls.Add(this.tabLamBai);
            this.tabControlHocSinh.Controls.Add(this.tabPageThongTin);
            this.tabControlHocSinh.Controls.Add(this.tabPageDongGopCauHoi);
            this.tabControlHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHocSinh.Location = new System.Drawing.Point(0, 0);
            this.tabControlHocSinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlHocSinh.Name = "tabControlHocSinh";
            this.tabControlHocSinh.SelectedIndex = 0;
            this.tabControlHocSinh.Size = new System.Drawing.Size(1652, 1037);
            this.tabControlHocSinh.TabIndex = 0;
            // 
            // tabLamBai
            // 
            this.tabLamBai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabLamBai.Location = new System.Drawing.Point(8, 39);
            this.tabLamBai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLamBai.Name = "tabLamBai";
            this.tabLamBai.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLamBai.Size = new System.Drawing.Size(1636, 990);
            this.tabLamBai.TabIndex = 0;
            this.tabLamBai.Text = "Làm Bài Thi";
            this.tabLamBai.Click += new System.EventHandler(this.tabLamBai_Click);
            // 
            // tabPageThongTin
            // 
            this.tabPageThongTin.Controls.Add(this.splitContainer1);
            this.tabPageThongTin.Location = new System.Drawing.Point(8, 39);
            this.tabPageThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageThongTin.Name = "tabPageThongTin";
            this.tabPageThongTin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageThongTin.Size = new System.Drawing.Size(1636, 990);
            this.tabPageThongTin.TabIndex = 2;
            this.tabPageThongTin.Text = "Thông Tin Cá Nhân";
            this.tabPageThongTin.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxThongTinChiTiet);
            this.splitContainer1.Size = new System.Drawing.Size(1628, 982);
            this.splitContainer1.SplitterDistance = 616;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxThongTinChiTiet
            // 
            this.groupBoxThongTinChiTiet.BackColor = System.Drawing.Color.LightYellow;
            this.groupBoxThongTinChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxThongTinChiTiet.Location = new System.Drawing.Point(0, 0);
            this.groupBoxThongTinChiTiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxThongTinChiTiet.Name = "groupBoxThongTinChiTiet";
            this.groupBoxThongTinChiTiet.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxThongTinChiTiet.Size = new System.Drawing.Size(616, 982);
            this.groupBoxThongTinChiTiet.TabIndex = 0;
            this.groupBoxThongTinChiTiet.TabStop = false;
            this.groupBoxThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Location = new System.Drawing.Point(362, 513);
            this.buttonCapNhat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(200, 63);
            this.buttonCapNhat.TabIndex = 2;
            this.buttonCapNhat.Text = "Cập Nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            // 
            // buttonInBangDiem
            // 
            this.buttonInBangDiem.Location = new System.Drawing.Point(362, 623);
            this.buttonInBangDiem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonInBangDiem.Name = "buttonInBangDiem";
            this.buttonInBangDiem.Size = new System.Drawing.Size(200, 58);
            this.buttonInBangDiem.TabIndex = 1;
            this.buttonInBangDiem.Text = "In Bảng Điểm";
            this.buttonInBangDiem.UseVisualStyleBackColor = true;
            // 
            // tabPageDongGopCauHoi
            // 
            this.tabPageDongGopCauHoi.Location = new System.Drawing.Point(8, 39);
            this.tabPageDongGopCauHoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDongGopCauHoi.Name = "tabPageDongGopCauHoi";
            this.tabPageDongGopCauHoi.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDongGopCauHoi.Size = new System.Drawing.Size(1636, 990);
            this.tabPageDongGopCauHoi.TabIndex = 3;
            this.tabPageDongGopCauHoi.Text = "Đóng góp câu Hỏi";
            this.tabPageDongGopCauHoi.UseVisualStyleBackColor = true;
            this.tabPageDongGopCauHoi.Click += new System.EventHandler(this.tabPageDongGopCauHoi_Click);
            // 
            // FrmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1652, 1037);
            this.Controls.Add(this.tabControlHocSinh);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmHocSinh";
            this.Text = "FrmHocSinh";
            this.tabControlHocSinh.ResumeLayout(false);
            this.tabLamBai.ResumeLayout(false);
            this.tabPageThongTin.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlHocSinh;
        private System.Windows.Forms.TabPage tabPageThongTin;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxThongTinChiTiet;
        private System.Windows.Forms.TabPage tabPageDongGopCauHoi;
        private System.Windows.Forms.TabPage tabLamBai;
        private Views.LamBaiThiView lamBaiThiView1;
        private Views.ThongTinHocSinhView thongTinHocSinhView1;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonInBangDiem;
        private Views.HocSinh.QuanLyHocTapView quanLyHocTapView1;
    }
}