
namespace ltudql1.Views
{
    partial class DongGoiCauHoiView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cauHoiView_TuyChinh_Top1 = new ltudql1.Views.CauHoiView_TuyChinh_Top();
            this.groupBoxCauHoiDongGop = new System.Windows.Forms.GroupBox();
            this.cauHoiView_TuyChinh_Bottom1 = new ltudql1.Views.CauHoiView_TuyChinh_Bottom();
            this.treeViewCauHoi = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBoxCauHoiDongGop.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxCauHoiDongGop);
            this.splitContainer1.Size = new System.Drawing.Size(1604, 918);
            this.splitContainer1.SplitterDistance = 1096;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cauHoiView_TuyChinh_Top1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.cauHoiView_TuyChinh_Bottom1);
            this.splitContainer2.Size = new System.Drawing.Size(1096, 918);
            this.splitContainer2.SplitterDistance = 689;
            this.splitContainer2.TabIndex = 0;
            // 
            // cauHoiView_TuyChinh_Top1
            // 
            this.cauHoiView_TuyChinh_Top1.Location = new System.Drawing.Point(0, 0);
            this.cauHoiView_TuyChinh_Top1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cauHoiView_TuyChinh_Top1.Name = "cauHoiView_TuyChinh_Top1";
            this.cauHoiView_TuyChinh_Top1.Size = new System.Drawing.Size(1092, 692);
            this.cauHoiView_TuyChinh_Top1.TabIndex = 0;
            // 
            // groupBoxCauHoiDongGop
            // 
            this.groupBoxCauHoiDongGop.BackColor = System.Drawing.SystemColors.Info;
            this.groupBoxCauHoiDongGop.Controls.Add(this.treeViewCauHoi);
            this.groupBoxCauHoiDongGop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCauHoiDongGop.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCauHoiDongGop.Name = "groupBoxCauHoiDongGop";
            this.groupBoxCauHoiDongGop.Size = new System.Drawing.Size(504, 918);
            this.groupBoxCauHoiDongGop.TabIndex = 0;
            this.groupBoxCauHoiDongGop.TabStop = false;
            this.groupBoxCauHoiDongGop.Text = "Các Câu Hỏi";
            // 
            // cauHoiView_TuyChinh_Bottom1
            // 
            this.cauHoiView_TuyChinh_Bottom1.BackColor = System.Drawing.Color.Beige;
            this.cauHoiView_TuyChinh_Bottom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cauHoiView_TuyChinh_Bottom1.Location = new System.Drawing.Point(0, 0);
            this.cauHoiView_TuyChinh_Bottom1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cauHoiView_TuyChinh_Bottom1.Name = "cauHoiView_TuyChinh_Bottom1";
            this.cauHoiView_TuyChinh_Bottom1.Size = new System.Drawing.Size(1096, 225);
            this.cauHoiView_TuyChinh_Bottom1.TabIndex = 0;
            // 
            // treeViewCauHoi
            // 
            this.treeViewCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCauHoi.Location = new System.Drawing.Point(3, 27);
            this.treeViewCauHoi.Name = "treeViewCauHoi";
            this.treeViewCauHoi.Size = new System.Drawing.Size(498, 888);
            this.treeViewCauHoi.TabIndex = 0;
            // 
            // DongGoiCauHoiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "DongGoiCauHoiView";
            this.Size = new System.Drawing.Size(1604, 918);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBoxCauHoiDongGop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private CauHoiView_TuyChinh_Top cauHoiView_TuyChinh_Top1;
        private System.Windows.Forms.GroupBox groupBoxCauHoiDongGop;
        private CauHoiView_TuyChinh_Bottom cauHoiView_TuyChinh_Bottom1;
        private System.Windows.Forms.TreeView treeViewCauHoi;
    }
}
