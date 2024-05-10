using iTextSharp.text;
using MdPDF.Properties;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MdPDF
{
    public partial class MdPDF : Form
    {
        private ContextMenuStrip contextMenuStrip;
        private int currentPage = 0;
        private int currentPageIndex = 0;
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
            ToolStripMenuItem menuItem2 = new ToolStripMenuItem("顺时90C");
            ToolStripMenuItem menuItem3 = new ToolStripMenuItem("顺时180C");
            ToolStripMenuItem menuItem4 = new ToolStripMenuItem("顺时270C");
            ToolStripMenuItem menuItem5 = new ToolStripMenuItem("逆时90C");
            ToolStripMenuItem menuItem6 = new ToolStripMenuItem("逆时180C");
            ToolStripMenuItem menuItem7 = new ToolStripMenuItem("逆时270C");
            ToolStripMenuItem menuItem8 = new ToolStripMenuItem("复位");
            ToolStripMenuItem menuItem9 = new ToolStripMenuItem("删除");
            ToolStripMenuItem menuItem10 = new ToolStripMenuItem("插入");
            ToolStripMenuItem menuItem11 = new ToolStripMenuItem("拆分");
            ToolStripMenuItem menuItem90 = new ToolStripMenuItem("退出");

            // 添加菜单项到ContextMenuStrip
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { menuItem1, menuItem8, menuItem2, menuItem3, menuItem4, menuItem5, menuItem6, menuItem7, menuItem9, menuItem10, menuItem11, menuItem90 });

            // 将ContextMenuStrip关联到表单，以便于弹出右键菜单
            this.ContextMenuStrip = contextMenuStrip;
            rotateLabel.ContextMenuStrip= contextMenuStrip;
            // 可选：为表单添加鼠标点击事件
            this.MouseClick += new MouseEventHandler(FileOpen_MouseClick);
            MenuePdf.Renderer.MouseClick += MenuePdf_cilck;//这是我们添加的代码

            menuItem1.MouseUp += FileOpen_MouseClick;
            menuItem2.MouseUp += rotatePage_MouseClick;
            menuItem3.MouseUp += rotatePage_MouseClick;
            menuItem4.MouseUp += rotatePage_MouseClick;
            menuItem5.MouseUp += rotatePage_MouseClick;
            menuItem6.MouseUp += rotatePage_MouseClick;
            menuItem7.MouseUp += rotatePage_MouseClick;
            menuItem8.MouseUp += rotatePage_MouseClick;
            menuItem9.MouseUp += rotatePage_MouseClick;
            menuItem10.MouseUp += rotatePage_MouseClick;
            menuItem11.MouseUp += rotatePage_MouseClick;
        }
        //窗口移动处理
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        //相对路径
        string address = System.Environment.CurrentDirectory;
        private void MenuePdf_cilck(object sender, MouseEventArgs e)
        {
            PdfiumViewer.PdfRenderer currentRenderer = (PdfiumViewer.PdfRenderer)sender;
            currentPage = currentRenderer.PointToPdf(e.Location).Page;//获取左侧单击的页码是多少
            if (e.Button == MouseButtons.Left)//单击左键，我们实现的在右侧切换到相应界面
            {
                //更新显示窗口页
                ViewerPdf.Renderer.Page = currentPage;
            }
            else
            {
                //单击右键我们准备实现的一些功能
            }
        }
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
            //Trace.WriteLine("右击进行菜单");
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
                        StreamWriter s = new StreamWriter(address + "\\Menu.ini", true);//true:
                        s.WriteLine(dialog.FileName);//写入INI文件
                        s.Flush();//清空缓存数据，并将缓存数据写入基础流
                        s.Close();
                        StartPdf(dialog.FileName);
                        readFileIni();//读取文件到菜单历史
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("空的文件，请重新选择！");
                }
            }
        }
        private void readFileIni()
        {
            /*StreamReader sr = new StreamReader(address + "\\Menu.ini");
            int i = this.iniMenu.DropDownItems.Count - 2;
            Trace.WriteLine("ITEMS:" + this.iniMenu.DropDownItems.Count);
            while (sr.Peek() >= 0)
            {
                Trace.WriteLine("行号："+sr.Peek());
                ToolStripMenuItem menuitem = new ToolStripMenuItem(sr.ReadLine());
                Trace.WriteLine("menuitem:" + menuitem.Text);
                this.iniMenu.DropDownItems.Add(menuitem);
                i++;
                menuitem.Click += new EventHandler(openIniFile_MouseClick);
                if (i >= 10)
                {
                    break; // 跳出while循环
                }
            }
            sr.Close();*/
            this.iniMenu.DropDownItems.Clear();

            string iniFilePath = (address + "\\Menu.ini");  // 替换为你的INI文件路径
            string[] lines = ReadLastLines(iniFilePath, 10);

            foreach (string line in lines)
            {
                //Console.WriteLine(line);
                ToolStripMenuItem menuitem = new ToolStripMenuItem(line);
                this.iniMenu.DropDownItems.Add(menuitem);
                menuitem.Click += new EventHandler(openIniFile_MouseClick);
            }
        }
        static string[] ReadLastLines(string filePath, int lineCount)
        {
            // 使用ReadAllLines读取文件所有行
            string[] allLines = File.ReadAllLines(filePath);
            // 使用LINQ取最后lineCount行
            return allLines.Skip(Math.Max(allLines.Length - lineCount, 0)).ToArray();
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
                MenuePdf.Renderer.Page = ViewerPdf.Renderer.Page;
            }
            catch (Exception eer)
            {
                MessageBox.Show("页码出错：" + eer);
            }
        }
        /// <summary>
        /// 左旋转90度页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leftPdf_Click(object sender, EventArgs e)
        {

        }
        private void rotatePage_MouseClick(object sender, MouseEventArgs e)
        {
            // 获取当前页的索引
            currentPageIndex = ViewerPdf.Renderer.Page;
            Trace.WriteLine("当前页：" + currentPageIndex);
            //if(NullReferenceException(ViewerPdf.Renderer.Document.PageCount)) { return; }
            switch (sender.ToString())
            {
                case "顺时90C":
                    MenuePdf.Document.RotatePage(currentPageIndex, PdfRotation.Rotate90);
                    ViewerPdf.Document.RotatePage(currentPageIndex, PdfRotation.Rotate90);
                    break;
                case "顺时180C":
                    MenuePdf.Document.RotatePage(currentPageIndex, PdfRotation.Rotate180);
                    ViewerPdf.Document.RotatePage(currentPageIndex, PdfRotation.Rotate180);
                    break;
                case "顺时270C":
                    MenuePdf.Document.RotatePage(currentPageIndex, PdfRotation.Rotate270);
                    ViewerPdf.Document.RotatePage(currentPageIndex, PdfRotation.Rotate270);
                    break;
                case "复位":
                    MenuePdf.Document.RotatePage(currentPageIndex, PdfRotation.Rotate0);
                    ViewerPdf.Document.RotatePage(currentPageIndex, PdfRotation.Rotate0);
                    break;
                case "逆时90C":
                    MenuePdf.Document.RotatePage(currentPageIndex, (PdfRotation)(-45));
                    ViewerPdf.Document.RotatePage(currentPageIndex, (PdfRotation)(-45));
                    break;
                case "逆时180C":
                    MenuePdf.Document.RotatePage(currentPageIndex, (PdfRotation)(-90));
                    ViewerPdf.Document.RotatePage(currentPageIndex, (PdfRotation)(-90));
                    break;
                case "逆时270C":
                    MenuePdf.Document.RotatePage(currentPageIndex, (PdfRotation)(-135));
                    ViewerPdf.Document.RotatePage(currentPageIndex, (PdfRotation)(-135));
                    break;
                case "删除":
                    DelPag(currentPageIndex);
                    break;
                case "插入":
                    InstPag();
                    break;
                case "拆分":
                    SplitPag();
                    break;
            }
            // 刷新PdfiumViewer控件显示            
            ViewerPdf.Renderer.ZoomIn();
            ViewerPdf.Renderer.ZoomOut();
            MenuePdf.Renderer.ZoomIn();
            MenuePdf.Renderer.ZoomOut();
        }
        private void DelPag(int currentPageIndex)
        {
            DelPdf delPdf = new DelPdf(currentPageIndex, ViewerPdf.Renderer.Document.PageCount);
            delPdf.ShowDialog();
            if(delPdf.DialogResult == DialogResult.OK)
            {
                //开始执行删除
                MessageBox.Show("删除完成。");
            }
        }
        private void InstPag()
        {
            InstPdf instPdf = new InstPdf(currentPageIndex, ViewerPdf.Renderer.Document.PageCount);
            instPdf.ShowDialog();
            if (instPdf.DialogResult == DialogResult.OK)
            {
                //开始执行删除
                MessageBox.Show("合并PDF完成。");
            }
        }
        private void SplitPag()
        {
            SplitePdf splitePdf = new SplitePdf(currentPageIndex, ViewerPdf.Renderer.Document.PageCount);
            splitePdf.ShowDialog();
            if (splitePdf.DialogResult == DialogResult.OK)
            {
                //开始执行删除
                MessageBox.Show("拆分PDF完成。");
            }
        }
        private void MdPDF_Load(object sender, EventArgs e)
        {
            readFileIni();//读取文件到菜单历史
        }
        private void openIniFile_MouseClick(object sender, EventArgs e)
        {
            sender.ToString();
            Trace.WriteLine("文件名："+ sender.ToString());
            StartPdf(sender.ToString());
        }

        private void rotateLabel_Click(object sender, EventArgs e)
        {
            // rotateLabel.Click+=
            rotateLabel.ContextMenuStrip.Show(MousePosition);
        }
    }
}
