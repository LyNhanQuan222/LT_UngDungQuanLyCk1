namespace ltudql1.Views
{
    partial class CauHoiView_TuyChinh_Bottom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDapAn = new System.Windows.Forms.GroupBox();
            this.comboBoxDoKho = new System.Windows.Forms.ComboBox();
            this.labelDoKho = new System.Windows.Forms.Label();
            this.comboBoxDapAn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.groupBoxDapAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDapAn
            // 
            this.groupBoxDapAn.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBoxDapAn.Controls.Add(this.comboBoxDoKho);
            this.groupBoxDapAn.Controls.Add(this.labelDoKho);
            this.groupBoxDapAn.Controls.Add(this.comboBoxDapAn);
            this.groupBoxDapAn.Controls.Add(this.label1);
            this.groupBoxDapAn.Controls.Add(this.buttonCapNhat);
            this.groupBoxDapAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDapAn.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDapAn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxDapAn.Name = "groupBoxDapAn";
            this.groupBoxDapAn.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxDapAn.Size = new System.Drawing.Size(1080, 183);
            this.groupBoxDapAn.TabIndex = 1;
            this.groupBoxDapAn.TabStop = false;
            this.groupBoxDapAn.Text = "Đáp Án";
            // 
            // comboBoxDoKho
            // 
            this.comboBoxDoKho.FormattingEnabled = true;
            this.comboBoxDoKho.Items.AddRange(new object[] {
            "Dễ",
            "Trung bình",
            "Khó"});
            this.comboBoxDoKho.Location = new System.Drawing.Point(166, 123);
            this.comboBoxDoKho.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxDoKho.Name = "comboBoxDoKho";
            this.comboBoxDoKho.Size = new System.Drawing.Size(296, 33);
            this.comboBoxDoKho.TabIndex = 6;
            // 
            // labelDoKho
            // 
            this.labelDoKho.AutoSize = true;
            this.labelDoKho.Location = new System.Drawing.Point(80, 129);
            this.labelDoKho.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDoKho.Name = "labelDoKho";
            this.labelDoKho.Size = new System.Drawing.Size(89, 25);
            this.labelDoKho.TabIndex = 5;
            this.labelDoKho.Text = "Độ Khó:";
            // 
            // comboBoxDapAn
            // 
            this.comboBoxDapAn.FormattingEnabled = true;
            this.comboBoxDapAn.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBoxDapAn.Location = new System.Drawing.Point(166, 48);
            this.comboBoxDapAn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxDapAn.Name = "comboBoxDapAn";
            this.comboBoxDapAn.Size = new System.Drawing.Size(296, 33);
            this.comboBoxDapAn.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đáp Án Đúng:";
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapNhat.Location = new System.Drawing.Point(708, 71);
            this.buttonCapNhat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(240, 58);
            this.buttonCapNhat.TabIndex = 1;
            this.buttonCapNhat.Text = "Cập Nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = false;
            // 
            // CauHoiView_TuyChinh_Bottom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxDapAn);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CauHoiView_TuyChinh_Bottom";
            this.Size = new System.Drawing.Size(1080, 183);
            this.groupBoxDapAn.ResumeLayout(false);
            this.groupBoxDapAn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDapAn;
        private System.Windows.Forms.ComboBox comboBoxDapAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.ComboBox comboBoxDoKho;
        private System.Windows.Forms.Label labelDoKho;
    }
}
