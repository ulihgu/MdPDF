namespace MdPDF
{
    partial class DelPdf
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
            this.DelTextBox = new System.Windows.Forms.TextBox();
            this.DelLabel = new System.Windows.Forms.Label();
            this.DelBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DelTextBox
            // 
            this.DelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DelTextBox.Font = new System.Drawing.Font("方正书宋_GBK", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DelTextBox.ForeColor = System.Drawing.Color.Red;
            this.DelTextBox.Location = new System.Drawing.Point(31, 118);
            this.DelTextBox.Name = "DelTextBox";
            this.DelTextBox.Size = new System.Drawing.Size(739, 42);
            this.DelTextBox.TabIndex = 0;
            this.DelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DelTextBox_KeyPress);
            // 
            // DelLabel
            // 
            this.DelLabel.AutoSize = true;
            this.DelLabel.Location = new System.Drawing.Point(31, 74);
            this.DelLabel.Name = "DelLabel";
            this.DelLabel.Size = new System.Drawing.Size(286, 24);
            this.DelLabel.TabIndex = 1;
            this.DelLabel.Text = "本文档共：页 准备删除：";
            // 
            // DelBut
            // 
            this.DelBut.Location = new System.Drawing.Point(247, 358);
            this.DelBut.Name = "DelBut";
            this.DelBut.Size = new System.Drawing.Size(212, 56);
            this.DelBut.TabIndex = 2;
            this.DelBut.Text = "删除";
            this.DelBut.UseVisualStyleBackColor = true;
            this.DelBut.Click += new System.EventHandler(this.DelBut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DelLabel);
            this.groupBox1.Controls.Add(this.DelBut);
            this.groupBox1.Controls.Add(this.DelTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 433);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "删除PDF页";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(658, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "3.删除多页连续页码，请用\\\"-\\\"，如：2-6，表示删除2到6页";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(658, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.删除多页且不连续，请输入页码并用\\\",\\\"分割，如：2,4,6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "1.删除单页，请直接输入页码，如：2";
            // 
            // DelPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DelPdf";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.DelPdf_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox DelTextBox;
        private System.Windows.Forms.Label DelLabel;
        private System.Windows.Forms.Button DelBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}