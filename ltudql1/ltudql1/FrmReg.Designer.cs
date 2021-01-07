
namespace ltudql1
{
    partial class FrmReg
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
            this.label5 = new System.Windows.Forms.Label();
            this.linklb = new System.Windows.Forms.LinkLabel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdGiaoVien = new System.Windows.Forms.RadioButton();
            this.rdHocSinh = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 699);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Bạn đã có tài khoản?";
            // 
            // linklb
            // 
            this.linklb.AutoSize = true;
            this.linklb.BackColor = System.Drawing.Color.Transparent;
            this.linklb.DisabledLinkColor = System.Drawing.Color.Navy;
            this.linklb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklb.Location = new System.Drawing.Point(719, 690);
            this.linklb.Name = "linklb";
            this.linklb.Size = new System.Drawing.Size(265, 37);
            this.linklb.TabIndex = 32;
            this.linklb.TabStop = true;
            this.linklb.Text = "Đăng Nhập Ngay";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(885, 357);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(121, 35);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Admin";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // rdGiaoVien
            // 
            this.rdGiaoVien.AutoSize = true;
            this.rdGiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.rdGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGiaoVien.Location = new System.Drawing.Point(677, 357);
            this.rdGiaoVien.Name = "rdGiaoVien";
            this.rdGiaoVien.Size = new System.Drawing.Size(163, 35);
            this.rdGiaoVien.TabIndex = 30;
            this.rdGiaoVien.TabStop = true;
            this.rdGiaoVien.Text = "Giáo Viên";
            this.rdGiaoVien.UseVisualStyleBackColor = false;
            // 
            // rdHocSinh
            // 
            this.rdHocSinh.AutoSize = true;
            this.rdHocSinh.BackColor = System.Drawing.Color.Transparent;
            this.rdHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHocSinh.Location = new System.Drawing.Point(472, 357);
            this.rdHocSinh.Name = "rdHocSinh";
            this.rdHocSinh.Size = new System.Drawing.Size(155, 35);
            this.rdHocSinh.TabIndex = 29;
            this.rdHocSinh.TabStop = true;
            this.rdHocSinh.Text = "Học Sinh";
            this.rdHocSinh.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 63);
            this.label4.TabIndex = 28;
            this.label4.Text = "Loại:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(472, 249);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(594, 59);
            this.txtPass.TabIndex = 27;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(472, 156);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(594, 59);
            this.txtUser.TabIndex = 26;
            this.txtUser.UseWaitCursor = true;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Bisque;
            this.btnLog.Font = new System.Drawing.Font("Trebuchet MS", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(544, 520);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(278, 92);
            this.btnLog.TabIndex = 25;
            this.btnLog.Text = "Đăng Ký";
            this.btnLog.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 63);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mật Khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 63);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tài Khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, -36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(836, 189);
            this.label1.TabIndex = 22;
            this.label1.Text = "Register Form";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 63);
            this.label6.TabIndex = 34;
            this.label6.Text = "Ngày Sinh:";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(653, 459);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(353, 31);
            this.dtNgaySinh.TabIndex = 35;
            // 
            // FrmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ltudql1.Properties.Resources._01_;
            this.ClientSize = new System.Drawing.Size(1370, 727);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linklb);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rdGiaoVien);
            this.Controls.Add(this.rdHocSinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmReg";
            this.Text = "Đăng Ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linklb;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdGiaoVien;
        private System.Windows.Forms.RadioButton rdHocSinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
    }
}