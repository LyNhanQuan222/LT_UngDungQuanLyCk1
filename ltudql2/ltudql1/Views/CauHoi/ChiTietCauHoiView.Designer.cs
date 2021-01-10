namespace ltudql1.Views
{
    partial class ChiTietCauHoiView
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
            this.groupBox_treeView_CauHoi_DeThi = new System.Windows.Forms.GroupBox();
            this.treeViewCauHoi_DeThi = new System.Windows.Forms.TreeView();
            this.groupBox_treeView_CauHoi_DeThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_treeView_CauHoi_DeThi
            // 
            this.groupBox_treeView_CauHoi_DeThi.Controls.Add(this.treeViewCauHoi_DeThi);
            this.groupBox_treeView_CauHoi_DeThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_treeView_CauHoi_DeThi.Location = new System.Drawing.Point(0, 0);
            this.groupBox_treeView_CauHoi_DeThi.Name = "groupBox_treeView_CauHoi_DeThi";
            this.groupBox_treeView_CauHoi_DeThi.Size = new System.Drawing.Size(258, 419);
            this.groupBox_treeView_CauHoi_DeThi.TabIndex = 1;
            this.groupBox_treeView_CauHoi_DeThi.TabStop = false;
            this.groupBox_treeView_CauHoi_DeThi.Text = "Câu Hỏi >> Đề Thi";
            // 
            // treeViewCauHoi_DeThi
            // 
            this.treeViewCauHoi_DeThi.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewCauHoi_DeThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCauHoi_DeThi.Location = new System.Drawing.Point(3, 16);
            this.treeViewCauHoi_DeThi.Name = "treeViewCauHoi_DeThi";
            this.treeViewCauHoi_DeThi.Size = new System.Drawing.Size(252, 400);
            this.treeViewCauHoi_DeThi.TabIndex = 0;
            // 
            // ChiTietCauHoiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.groupBox_treeView_CauHoi_DeThi);
            this.Name = "ChiTietCauHoiView";
            this.Size = new System.Drawing.Size(258, 419);
            this.groupBox_treeView_CauHoi_DeThi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_treeView_CauHoi_DeThi;
        private System.Windows.Forms.TreeView treeViewCauHoi_DeThi;
    }
}
