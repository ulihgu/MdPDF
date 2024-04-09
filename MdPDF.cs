using MdPDF.Properties;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MdPDF
{
    public partial class MdPDF : Form
    {
        private ContextMenuStrip contextMenuStrip;
        public MdPDF()
        {
            InitializeComponent();           
            //配置窗口类
            FormBorderStyle = FormBorderStyle.None;//配置
            StartPosition = FormStartPosition.CenterScreen;
            // 创建ContextMenuStrip对象
            contextMenuStrip = new ContextMenuStrip();

            // 创建菜单项
            ToolStripMenuItem menuItem1 = new ToolStripMenuItem("打开PDF");
            ToolStripMenuItem menuItem2 = new ToolStripMenuItem("设置");
            ToolStripMenuItem menuItem3 = new ToolStripMenuItem("退出");

            // 添加菜单项到ContextMenuStrip
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { menuItem1, menuItem2, menuItem3 });

            // 将ContextMenuStrip关联到表单，以便于弹出右键菜单
            this.ContextMenuStrip = contextMenuStrip;

            // 可选：为表单添加鼠标点击事件
            this.MouseClick += new MouseEventHandler(FileOpen_MouseClick);
        }
        //窗口移动处理
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                //Image backImage = Resources.最大化;//这里图片调用的时资源库中添加好的图片  需要添加引用 using CalibrationAndMatching.Properties;
                //btn_Max.BackgroundImage = backImage;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                //Image backImage = Resources.还原;
                //btn_Max.BackgroundImage = backImage;
            }
        }

        private void Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                if (e.Clicks == 1)
                {
                    SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
                }
                else
                {
                    //MessageBox.Show("双周-0000");
                    //SendMessage(this.Handle, WM_LBUTTONUP, 0, 0);
                }
            }
        }

        private void FileOpen_MouseClick(object sender, MouseEventArgs e)
        {
            // 如果是右键点击，显示弹出菜单
            if (e.Button == MouseButtons.Left)
            {
                //contextMenuStrip.Show(this, e.Location);
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog
                    {
                        //设置打开标题、后缀
                        Title = "请选择导入文件",
                        Filter = "pdf文件|*.pdf"
                    };
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        if (dialog.FileName == "")
                        {
                            MessageBox.Show("空的文件，请重新选择！");
                            return;
                        }
                        //_Path.Text = dialog.FileName;
                        StartPdf(dialog.FileName);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("空的文件，请重新选择！");
                }
            }
        }

        private void StartPdf(string pdfPath)
        {
            MenuePdf.Document?.Dispose();
            MenuePdf.Document = OpenDocument(pdfPath);
            MenuePdf.Renderer.Zoom = 0.8;
            ViewerPdf.Document?.Dispose();
            ViewerPdf.Document = MenuePdf.Document;
            ViewerPdf.Renderer.Zoom = 1.5;
            ViewerPdf.Renderer.DisplayRectangleChanged += Renderer_DisplayRectangleChanged;
        }
        private PdfiumViewer.IPdfDocument OpenDocument(string pdfPath)
        {
            try
            {
                return PdfiumViewer.PdfDocument.Load(this, pdfPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        /// <summary>
        /// 右旋转90度页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightPdf_Click(object sender, EventArgs e)
        {            
            // 获取当前页的索引
            int currentPageIndex = ViewerPdf.Renderer.Page;
            //MessageBox.Show("right当前页为：" + currentPageIndex);
            // 获取PDF页面对象            
                ViewerPdf.Document.RotatePage(currentPageIndex, PdfRotation.Rotate90);
            // MessageBox.Show("right当前页为：" + currentPageIndex+ "numerXZ:" + numerXZ);
            // 刷新PdfiumViewer控件显示
            //ViewerPdf.Refresh();
            //MenuePdf.Document.p
        }
        /// <summary>
        /// 翻页矩形框变化时，更新当前页码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Renderer_DisplayRectangleChanged(object sender, EventArgs e)
        {
            CurrentPage.Text = (ViewerPdf.Renderer.Page + 1).ToString();
            try
            {
                menupage.Text = "页码：第" + (ViewerPdf.Renderer.Page + 1).ToString() + "/" + ViewerPdf.Document.PageCount + "页";
            }
            catch (Exception eer)
            {

            }
        }
        /// <summary>
        /// 左旋转90度页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leftPdf_Click(object sender, EventArgs e)
        {
            //ViewerPdf.Renderer.RotateLeft();
            //ViewerPdf.Renderer.;
            // 获取当前页的索引
            //var currentPageIndex = ViewerPdf.Renderer.Page;
            var currentPageIndex = ViewerPdf.Renderer.Page;
            MessageBox.Show("left当前页为：" + currentPageIndex);
            // 获取PDF页面对象
            //ViewerPdf.Document.RotatePage(currentPageIndex, PdfRotation.Rotate180);
            
            // 保存文档更改
            //ViewerPdf.Document.Save();
            // 刷新PdfiumViewer控件显示
            ViewerPdf.Refresh();
        }
    }
}
