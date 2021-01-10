
namespace ltudql1.Views
{
    partial class OnThiThu
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
            this.splitContainerOnThiThu = new System.Windows.Forms.SplitContainer();
            this.groupBoxDSCauHoi = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewCauHoi = new System.Windows.Forms.TreeView();
            this.groupBoxCauHoi = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cauHoiView1 = new ltudql1.Views.CauHoiView();
            this.cauHoiLuyenTapView1 = new ltudql1.Views.CauHoiLuyenTapView();
            this.goiYCauHoiView1 = new ltudql1.Views.GoiYCauHoiView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOnThiThu)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainerOnThiThu.SuspendLayout();
            this.groupBoxDSCauHoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxCauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerOnThiThu
            // 
            this.splitContainerOnThiThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOnThiThu.Location = new System.Drawing.Point(0, 0);
            this.splitContainerOnThiThu.Name = "splitContainerOnThiThu";
            // 
            // splitContainerOnThiThu.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxDSCauHoi);
            // 
            // splitContainerOnThiThu.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainerOnThiThu.Size = new System.Drawing.Size(1470, 764);
            this.splitContainerOnThiThu.SplitterDistance = 384;
            this.splitContainerOnThiThu.TabIndex = 0;
            // 
            // groupBoxDSCauHoi
            // 
            this.groupBoxDSCauHoi.Controls.Add(this.treeViewCauHoi);
            this.groupBoxDSCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDSCauHoi.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDSCauHoi.Name = "groupBoxDSCauHoi";
            this.groupBoxDSCauHoi.Size = new System.Drawing.Size(384, 764);
            this.groupBoxDSCauHoi.TabIndex = 0;
            this.groupBoxDSCauHoi.TabStop = false;
            this.groupBoxDSCauHoi.Text = "Danh Sách Câu Hỏi";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxCauHoi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.goiYCauHoiView1);
            this.splitContainer1.Size = new System.Drawing.Size(1082, 764);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewCauHoi
            // 
            this.treeViewCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCauHoi.Location = new System.Drawing.Point(3, 27);
            this.treeViewCauHoi.Name = "treeViewCauHoi";
            this.treeViewCauHoi.Size = new System.Drawing.Size(378, 734);
            this.treeViewCauHoi.TabIndex = 0;
            // 
            // groupBoxCauHoi
            // 
            this.groupBoxCauHoi.Controls.Add(this.cauHoiLuyenTapView1);
            this.groupBoxCauHoi.Controls.Add(this.cauHoiView1);
            this.groupBoxCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCauHoi.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCauHoi.Name = "groupBoxCauHoi";
            this.groupBoxCauHoi.Size = new System.Drawing.Size(1082, 500);
            this.groupBoxCauHoi.TabIndex = 0;
            this.groupBoxCauHoi.TabStop = false;
            this.groupBoxCauHoi.Text = "Thông Tin Câu Hỏi";
            // 
            // cauHoiView1
            // 
            this.cauHoiView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cauHoiView1.Location = new System.Drawing.Point(3, 27);
            this.cauHoiView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cauHoiView1.Name = "cauHoiView1";
            this.cauHoiView1.Size = new System.Drawing.Size(1076, 470);
            this.cauHoiView1.TabIndex = 0;
            this.cauHoiView1.Load += new System.EventHandler(this.cauHoiView1_Load);
            // 
            // cauHoiLuyenTapView1
            // 
            this.cauHoiLuyenTapView1.Location = new System.Drawing.Point(1058, 427);
            this.cauHoiLuyenTapView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cauHoiLuyenTapView1.Name = "cauHoiLuyenTapView1";
            this.cauHoiLuyenTapView1.Size = new System.Drawing.Size(8, 17);
            this.cauHoiLuyenTapView1.TabIndex = 1;
            // 
            // goiYCauHoiView1
            // 
            this.goiYCauHoiView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goiYCauHoiView1.Location = new System.Drawing.Point(0, 0);
            this.goiYCauHoiView1.Name = "goiYCauHoiView1";
            this.goiYCauHoiView1.Size = new System.Drawing.Size(1082, 260);
            this.goiYCauHoiView1.TabIndex = 0;
            // 
            // OnThiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerOnThiThu);
            this.Name = "OnThiThu";
            this.Size = new System.Drawing.Size(1470, 764);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOnThiThu)).EndInit();
            this.splitContainerOnThiThu.ResumeLayout(false);
            this.groupBoxDSCauHoi.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxCauHoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerOnThiThu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxDSCauHoi;
        private System.Windows.Forms.TreeView treeViewCauHoi;
        private System.Windows.Forms.GroupBox groupBoxCauHoi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CauHoiLuyenTapView cauHoiLuyenTapView1;
        private CauHoiView cauHoiView1;
        private GoiYCauHoiView goiYCauHoiView1;
    }
}
