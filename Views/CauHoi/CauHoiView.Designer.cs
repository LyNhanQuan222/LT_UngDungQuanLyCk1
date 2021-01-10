namespace ltudql1.Views
{
    partial class CauHoiView
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
            this.groupBoxDeBai = new System.Windows.Forms.GroupBox();
            this.LabelDeBai = new System.Windows.Forms.Label();
            this.groupBoxCauTraLoi = new System.Windows.Forms.GroupBox();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelCauTraLoi = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxDeBai.SuspendLayout();
            this.groupBoxCauTraLoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanelCauTraLoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDeBai
            // 
            this.groupBoxDeBai.BackColor = System.Drawing.SystemColors.Info;
            this.groupBoxDeBai.Controls.Add(this.LabelDeBai);
            this.groupBoxDeBai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDeBai.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDeBai.Name = "groupBoxDeBai";
            this.groupBoxDeBai.Size = new System.Drawing.Size(494, 258);
            this.groupBoxDeBai.TabIndex = 19;
            this.groupBoxDeBai.TabStop = false;
            this.groupBoxDeBai.Text = "Đề bài";
            // 
            // LabelDeBai
            // 
            this.LabelDeBai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDeBai.Location = new System.Drawing.Point(3, 16);
            this.LabelDeBai.Name = "LabelDeBai";
            this.LabelDeBai.Padding = new System.Windows.Forms.Padding(15);
            this.LabelDeBai.Size = new System.Drawing.Size(488, 239);
            this.LabelDeBai.TabIndex = 0;
            this.LabelDeBai.Text = "<<DeBai>>";
            // 
            // groupBoxCauTraLoi
            // 
            this.groupBoxCauTraLoi.BackColor = System.Drawing.SystemColors.Info;
            this.groupBoxCauTraLoi.Controls.Add(this.flowLayoutPanelCauTraLoi);
            this.groupBoxCauTraLoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCauTraLoi.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCauTraLoi.Name = "groupBoxCauTraLoi";
            this.groupBoxCauTraLoi.Size = new System.Drawing.Size(494, 180);
            this.groupBoxCauTraLoi.TabIndex = 20;
            this.groupBoxCauTraLoi.TabStop = false;
            this.groupBoxCauTraLoi.Text = "Chọn Câu Trả Lời";
            // 
            // radioButtonD
            // 
            this.radioButtonD.Location = new System.Drawing.Point(209, 65);
            this.radioButtonD.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(195, 59);
            this.radioButtonD.TabIndex = 13;
            this.radioButtonD.Text = "<<DapAnD>>";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            this.radioButtonA.Checked = true;
            this.radioButtonA.Location = new System.Drawing.Point(2, 2);
            this.radioButtonA.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(203, 55);
            this.radioButtonA.TabIndex = 10;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "<<DapAnA>>";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.Location = new System.Drawing.Point(2, 65);
            this.radioButtonC.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(203, 59);
            this.radioButtonC.TabIndex = 11;
            this.radioButtonC.Text = "<<DapAnC>>";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.Location = new System.Drawing.Point(209, 2);
            this.radioButtonB.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(209, 59);
            this.radioButtonB.TabIndex = 12;
            this.radioButtonB.Text = "<<DapAnB>>";
            this.radioButtonB.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxDeBai);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxCauTraLoi);
            this.splitContainer1.Size = new System.Drawing.Size(494, 442);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 21;
            // 
            // flowLayoutPanelCauTraLoi
            // 
            this.flowLayoutPanelCauTraLoi.AutoScroll = true;
            this.flowLayoutPanelCauTraLoi.Controls.Add(this.radioButtonA);
            this.flowLayoutPanelCauTraLoi.Controls.Add(this.radioButtonB);
            this.flowLayoutPanelCauTraLoi.Controls.Add(this.radioButtonC);
            this.flowLayoutPanelCauTraLoi.Controls.Add(this.radioButtonD);
            this.flowLayoutPanelCauTraLoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCauTraLoi.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelCauTraLoi.Name = "flowLayoutPanelCauTraLoi";
            this.flowLayoutPanelCauTraLoi.Size = new System.Drawing.Size(488, 161);
            this.flowLayoutPanelCauTraLoi.TabIndex = 1;
            // 
            // CauHoiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "CauHoiView";
            this.Size = new System.Drawing.Size(494, 442);
            this.groupBoxDeBai.ResumeLayout(false);
            this.groupBoxCauTraLoi.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanelCauTraLoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDeBai;
        private System.Windows.Forms.Label LabelDeBai;
        private System.Windows.Forms.GroupBox groupBoxCauTraLoi;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCauTraLoi;
    }
}
