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
            this.groupBoxDapAn.Controls.Add(this.comboBoxDoKho);
            this.groupBoxDapAn.Controls.Add(this.labelDoKho);
            this.groupBoxDapAn.Controls.Add(this.comboBoxDapAn);
            this.groupBoxDapAn.Controls.Add(this.label1);
            this.groupBoxDapAn.Controls.Add(this.buttonCapNhat);
            this.groupBoxDapAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDapAn.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDapAn.Name = "groupBoxDapAn";
            this.groupBoxDapAn.Size = new System.Drawing.Size(540, 95);
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
            this.comboBoxDoKho.Location = new System.Drawing.Point(83, 64);
            this.comboBoxDoKho.Name = "comboBoxDoKho";
            this.comboBoxDoKho.Size = new System.Drawing.Size(150, 21);
            this.comboBoxDoKho.TabIndex = 6;
            // 
            // labelDoKho
            // 
            this.labelDoKho.AutoSize = true;
            this.labelDoKho.Location = new System.Drawing.Point(40, 67);
            this.labelDoKho.Name = "labelDoKho";
            this.labelDoKho.Size = new System.Drawing.Size(46, 13);
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
            this.comboBoxDapAn.Location = new System.Drawing.Point(83, 25);
            this.comboBoxDapAn.Name = "comboBoxDapAn";
            this.comboBoxDapAn.Size = new System.Drawing.Size(150, 21);
            this.comboBoxDapAn.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đáp Án Đúng:";
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Location = new System.Drawing.Point(354, 37);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(120, 30);
            this.buttonCapNhat.TabIndex = 1;
            this.buttonCapNhat.Text = "Cập Nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            // 
            // CauHoiView_TuyChinh_Bottom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxDapAn);
            this.Name = "CauHoiView_TuyChinh_Bottom";
            this.Size = new System.Drawing.Size(540, 95);
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
