namespace MdPDF
{
    partial class InstPdf
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
            this.PdfInfoLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InSertPageTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectTxtLB = new System.Windows.Forms.Label();
            this.SelectBT = new System.Windows.Forms.Button();
            this.OKBT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PdfInfoLB
            // 
            this.PdfInfoLB.AutoSize = true;
            this.PdfInfoLB.Location = new System.Drawing.Point(18, 64);
            this.PdfInfoLB.Name = "PdfInfoLB";
            this.PdfInfoLB.Size = new System.Drawing.Size(226, 24);
            this.PdfInfoLB.TabIndex = 0;
            this.PdfInfoLB.Text = "本文档共页，准备在";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OKBT);
            this.groupBox1.Controls.Add(this.SelectBT);
            this.groupBox1.Controls.Add(this.InSertPageTXT);
            this.groupBox1.Controls.Add(this.SelectTxtLB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PdfInfoLB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "插入PDF页";
            // 
            // InSertPageTXT
            // 
            this.InSertPageTXT.Location = new System.Drawing.Point(254, 59);
            this.InSertPageTXT.Name = "InSertPageTXT";
            this.InSertPageTXT.Size = new System.Drawing.Size(100, 35);
            this.InSertPageTXT.TabIndex = 1;
            this.InSertPageTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InSertPageTXT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "页后，插入以下文件：";
            // 
            // SelectTxtLB
            // 
            this.SelectTxtLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SelectTxtLB.Location = new System.Drawing.Point(13, 155);
            this.SelectTxtLB.Name = "SelectTxtLB";
            this.SelectTxtLB.Size = new System.Drawing.Size(757, 199);
            this.SelectTxtLB.TabIndex = 0;
            // 
            // SelectBT
            // 
            this.SelectBT.Location = new System.Drawing.Point(8, 100);
            this.SelectBT.Name = "SelectBT";
            this.SelectBT.Size = new System.Drawing.Size(180, 49);
            this.SelectBT.TabIndex = 2;
            this.SelectBT.Text = "选择文件";
            this.SelectBT.UseVisualStyleBackColor = true;
            this.SelectBT.Click += new System.EventHandler(this.SelectBT_Click);
            // 
            // OKBT
            // 
            this.OKBT.Location = new System.Drawing.Point(565, 357);
            this.OKBT.Name = "OKBT";
            this.OKBT.Size = new System.Drawing.Size(180, 49);
            this.OKBT.TabIndex = 2;
            this.OKBT.Text = "确认";
            this.OKBT.UseVisualStyleBackColor = true;
            this.OKBT.Click += new System.EventHandler(this.OKBT_Click);
            // 
            // InstPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InstPdf";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.InstPdf_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PdfInfoLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox InSertPageTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SelectTxtLB;
        private System.Windows.Forms.Button OKBT;
        private System.Windows.Forms.Button SelectBT;
    }
}