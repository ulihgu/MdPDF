namespace MdPDF
{
    partial class MdPDF
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdPDF));
            this.panTop = new System.Windows.Forms.Panel();
            this.rotateLabel = new System.Windows.Forms.Label();
            this.historyMenu = new System.Windows.Forms.MenuStrip();
            this.iniMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpen = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.leftPdf = new System.Windows.Forms.Label();
            this.rightPdf = new System.Windows.Forms.Label();
            this.menupage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentPage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ViewerPdf = new PdfiumViewer.PdfViewer();
            this.MenuePdf = new PdfiumViewer.PdfViewer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panTop.SuspendLayout();
            this.historyMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.LightSlateGray;
            this.panTop.Controls.Add(this.rotateLabel);
            this.panTop.Controls.Add(this.historyMenu);
            this.panTop.Controls.Add(this.FileOpen);
            this.panTop.Controls.Add(this.logo);
            this.panTop.Controls.Add(this.Min);
            this.panTop.Controls.Add(this.Max);
            this.panTop.Controls.Add(this.exit);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Margin = new System.Windows.Forms.Padding(6);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(2026, 79);
            this.panTop.TabIndex = 6;
            this.panTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTop_MouseDown);
            // 
            // rotateLabel
            // 
            this.rotateLabel.BackColor = System.Drawing.Color.Transparent;
            this.rotateLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.rotateLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.rotateLabel.ForeColor = System.Drawing.Color.White;
            this.rotateLabel.Image = ((System.Drawing.Image)(resources.GetObject("rotateLabel.Image")));
            this.rotateLabel.Location = new System.Drawing.Point(202, 0);
            this.rotateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.rotateLabel.Name = "rotateLabel";
            this.rotateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rotateLabel.Size = new System.Drawing.Size(101, 79);
            this.rotateLabel.TabIndex = 7;
            this.rotateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.rotateLabel, "调整旋转角度");
            this.rotateLabel.Click += new System.EventHandler(this.rotateLabel_Click);
            // 
            // historyMenu
            // 
            this.historyMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.historyMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.historyMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.historyMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.historyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniMenu});
            this.historyMenu.Location = new System.Drawing.Point(297, 18);
            this.historyMenu.Name = "historyMenu";
            this.historyMenu.Size = new System.Drawing.Size(138, 42);
            this.historyMenu.TabIndex = 6;
            this.historyMenu.Text = "历史记录";
            // 
            // iniMenu
            // 
            this.iniMenu.Name = "iniMenu";
            this.iniMenu.Size = new System.Drawing.Size(130, 38);
            this.iniMenu.Text = "历史记录";
            // 
            // FileOpen
            // 
            this.FileOpen.BackColor = System.Drawing.Color.Transparent;
            this.FileOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileOpen.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.FileOpen.ForeColor = System.Drawing.Color.White;
            this.FileOpen.Image = ((System.Drawing.Image)(resources.GetObject("FileOpen.Image")));
            this.FileOpen.Location = new System.Drawing.Point(103, 0);
            this.FileOpen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FileOpen.Size = new System.Drawing.Size(99, 79);
            this.FileOpen.TabIndex = 5;
            this.FileOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FileOpen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FileOpen_MouseClick);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.logo.ForeColor = System.Drawing.Color.White;
            this.logo.Image = global::MdPDF.Properties.Resources.Pdf;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.logo.Name = "logo";
            this.logo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logo.Size = new System.Drawing.Size(103, 79);
            this.logo.TabIndex = 4;
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.Color.Transparent;
            this.Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Min.Dock = System.Windows.Forms.DockStyle.Right;
            this.Min.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.Min.ForeColor = System.Drawing.Color.White;
            this.Min.Image = global::MdPDF.Properties.Resources.最小化;
            this.Min.Location = new System.Drawing.Point(1782, 0);
            this.Min.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(85, 79);
            this.Min.TabIndex = 3;
            this.Min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // Max
            // 
            this.Max.BackColor = System.Drawing.Color.Transparent;
            this.Max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Max.Dock = System.Windows.Forms.DockStyle.Right;
            this.Max.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.Max.ForeColor = System.Drawing.Color.White;
            this.Max.Image = global::MdPDF.Properties.Resources.最大化16;
            this.Max.Location = new System.Drawing.Point(1867, 0);
            this.Max.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(63, 79);
            this.Max.TabIndex = 2;
            this.Max.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Image = global::MdPDF.Properties.Resources.关闭16;
            this.exit.Location = new System.Drawing.Point(1930, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(96, 79);
            this.exit.TabIndex = 1;
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.leftPdf);
            this.panel2.Controls.Add(this.rightPdf);
            this.panel2.Controls.Add(this.menupage);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.CurrentPage);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1081);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2026, 46);
            this.panel2.TabIndex = 10;
            // 
            // leftPdf
            // 
            this.leftPdf.BackColor = System.Drawing.Color.Transparent;
            this.leftPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftPdf.Dock = System.Windows.Forms.DockStyle.Right;
            this.leftPdf.Font = new System.Drawing.Font("楷体", 6.375F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leftPdf.ForeColor = System.Drawing.Color.Red;
            this.leftPdf.Image = ((System.Drawing.Image)(resources.GetObject("leftPdf.Image")));
            this.leftPdf.Location = new System.Drawing.Point(1569, 0);
            this.leftPdf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.leftPdf.Name = "leftPdf";
            this.leftPdf.Size = new System.Drawing.Size(77, 46);
            this.leftPdf.TabIndex = 7;
            this.leftPdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.leftPdf.Click += new System.EventHandler(this.leftPdf_Click);
            // 
            // rightPdf
            // 
            this.rightPdf.BackColor = System.Drawing.Color.Transparent;
            this.rightPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightPdf.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPdf.Font = new System.Drawing.Font("楷体", 6.375F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rightPdf.ForeColor = System.Drawing.Color.Red;
            this.rightPdf.Image = ((System.Drawing.Image)(resources.GetObject("rightPdf.Image")));
            this.rightPdf.Location = new System.Drawing.Point(1646, 0);
            this.rightPdf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.rightPdf.Name = "rightPdf";
            this.rightPdf.Size = new System.Drawing.Size(86, 46);
            this.rightPdf.TabIndex = 6;
            this.rightPdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rightPdf.Click += new System.EventHandler(this.rightPdf_Click);
            // 
            // menupage
            // 
            this.menupage.BackColor = System.Drawing.Color.Transparent;
            this.menupage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menupage.Dock = System.Windows.Forms.DockStyle.Left;
            this.menupage.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menupage.ForeColor = System.Drawing.Color.Red;
            this.menupage.Location = new System.Drawing.Point(0, 0);
            this.menupage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.menupage.Name = "menupage";
            this.menupage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menupage.Size = new System.Drawing.Size(320, 46);
            this.menupage.TabIndex = 5;
            this.menupage.Text = "页码：第0页";
            this.menupage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::MdPDF.Properties.Resources.减号16;
            this.label3.Location = new System.Drawing.Point(1732, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 46);
            this.label3.TabIndex = 3;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrentPage
            // 
            this.CurrentPage.BackColor = System.Drawing.Color.Transparent;
            this.CurrentPage.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.CurrentPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.CurrentPage.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CurrentPage.ForeColor = System.Drawing.Color.Red;
            this.CurrentPage.Location = new System.Drawing.Point(1791, 0);
            this.CurrentPage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CurrentPage.Name = "CurrentPage";
            this.CurrentPage.Size = new System.Drawing.Size(139, 46);
            this.CurrentPage.TabIndex = 2;
            this.CurrentPage.Text = "0";
            this.CurrentPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(1930, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 46);
            this.label5.TabIndex = 1;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ViewerPdf
            // 
            this.ViewerPdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewerPdf.Location = new System.Drawing.Point(409, 79);
            this.ViewerPdf.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ViewerPdf.Name = "ViewerPdf";
            this.ViewerPdf.ShowBookmarks = false;
            this.ViewerPdf.Size = new System.Drawing.Size(1617, 1002);
            this.ViewerPdf.TabIndex = 16;
            this.ViewerPdf.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitBest;
            // 
            // MenuePdf
            // 
            this.MenuePdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuePdf.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuePdf.Location = new System.Drawing.Point(0, 79);
            this.MenuePdf.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MenuePdf.Name = "MenuePdf";
            this.MenuePdf.ShowBookmarks = false;
            this.MenuePdf.ShowToolbar = false;
            this.MenuePdf.Size = new System.Drawing.Size(409, 1002);
            this.MenuePdf.TabIndex = 12;
            this.MenuePdf.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitBest;
            // 
            // MdPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2026, 1127);
            this.Controls.Add(this.ViewerPdf);
            this.Controls.Add(this.MenuePdf);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MdPDF";
            this.Text = "PDF编辑器";
            this.Load += new System.EventHandler(this.MdPDF_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.historyMenu.ResumeLayout(false);
            this.historyMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label FileOpen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label menupage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CurrentPage;
        private System.Windows.Forms.Label label5;
        private PdfiumViewer.PdfViewer ViewerPdf;
        private PdfiumViewer.PdfViewer MenuePdf;
        private System.Windows.Forms.Label rightPdf;
        private System.Windows.Forms.Label leftPdf;
        private System.Windows.Forms.MenuStrip historyMenu;
        private System.Windows.Forms.ToolStripMenuItem iniMenu;
        private System.Windows.Forms.Label rotateLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

