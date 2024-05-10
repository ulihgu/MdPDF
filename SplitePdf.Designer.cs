namespace MdPDF
{
    partial class SplitePdf
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
            this.infoLB = new System.Windows.Forms.Label();
            this.SpliteTXT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SlectFileBT = new System.Windows.Forms.Button();
            this.SelectLB = new System.Windows.Forms.Label();
            this.SpiteBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoLB
            // 
            this.infoLB.AutoSize = true;
            this.infoLB.Location = new System.Drawing.Point(6, 69);
            this.infoLB.Name = "infoLB";
            this.infoLB.Size = new System.Drawing.Size(322, 24);
            this.infoLB.TabIndex = 0;
            this.infoLB.Text = "本文档共300页码 分割设置：";
            // 
            // SpliteTXT
            // 
            this.SpliteTXT.Font = new System.Drawing.Font("方正仿宋_GBK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SpliteTXT.Location = new System.Drawing.Point(355, 56);
            this.SpliteTXT.Name = "SpliteTXT";
            this.SpliteTXT.Size = new System.Drawing.Size(414, 43);
            this.SpliteTXT.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectLB);
            this.groupBox1.Controls.Add(this.SpiteBT);
            this.groupBox1.Controls.Add(this.SlectFileBT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.infoLB);
            this.groupBox1.Controls.Add(this.SpliteTXT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "拆分PDF";
            // 
            // SlectFileBT
            // 
            this.SlectFileBT.Location = new System.Drawing.Point(6, 191);
            this.SlectFileBT.Name = "SlectFileBT";
            this.SlectFileBT.Size = new System.Drawing.Size(180, 49);
            this.SlectFileBT.TabIndex = 3;
            this.SlectFileBT.Text = "保存路径";
            this.SlectFileBT.UseVisualStyleBackColor = true;
            this.SlectFileBT.Click += new System.EventHandler(this.SlectFileBT_Click);
            // 
            // SelectLB
            // 
            this.SelectLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SelectLB.Location = new System.Drawing.Point(7, 243);
            this.SelectLB.Name = "SelectLB";
            this.SelectLB.Size = new System.Drawing.Size(757, 125);
            this.SelectLB.TabIndex = 4;
            // 
            // SpiteBT
            // 
            this.SpiteBT.Location = new System.Drawing.Point(590, 371);
            this.SpiteBT.Name = "SpiteBT";
            this.SpiteBT.Size = new System.Drawing.Size(180, 49);
            this.SpiteBT.TabIndex = 3;
            this.SpiteBT.Text = "开始分割";
            this.SpiteBT.UseVisualStyleBackColor = true;
            this.SpiteBT.Click += new System.EventHandler(this.SpiteBT_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(19, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "分割提示：分割可以进行如下设置：1-3,4-5;表示1至3为一个文件，4至5为一个文件";
            // 
            // SplitePdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SplitePdf";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.SplitePdf_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label infoLB;
        private System.Windows.Forms.TextBox SpliteTXT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SlectFileBT;
        private System.Windows.Forms.Label SelectLB;
        private System.Windows.Forms.Button SpiteBT;
        private System.Windows.Forms.Label label1;
    }
}