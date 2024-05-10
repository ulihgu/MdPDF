using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdPDF
{
    public partial class SplitePdf : Form
    {
        public String SpliteOption, SavePath;
        private int CurrentPage, totalPage;

        private void SplitePdf_Load(object sender, EventArgs e)
        {
            infoLB.Text = "本文档共" + totalPage + "页  分割设置：";
            if (totalPage == 2)
            {
                SpliteTXT.Text = "1,2";
                return;
            }
            if (CurrentPage == 1)
            {
                SpliteTXT.Text = "1,2-" + totalPage.ToString();
            }
            else if (CurrentPage == totalPage)
            {
                SpliteTXT.Text = "1-" + (totalPage - 1).ToString() + "," + totalPage.ToString();
            }
            else
            {
                SpliteTXT.Text = "1-" + CurrentPage.ToString() + "," + (CurrentPage + 1).ToString() + "-" + totalPage.ToString();
            }
            /*if (BaseClass.GetAppConfig("last") != "")
            {
                SelectLB.Text = BaseClass.GetAppConfig("last");
                SavePath = BaseClass.GetAppConfig("last");
            }*/
        }

        private void SlectFileBT_Click(object sender, EventArgs e)
        {
            using (var form = new FolderBrowserDialog())
            {
               /* if (BaseClass.GetAppConfig("last") != "")
                {
                    form.SelectedPath = BaseClass.GetAppConfig("last");
                }*/
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                //BaseClass.SetAppConfig("last", form.SelectedPath);
                SavePath = form.SelectedPath;
                SelectLB.Text = SavePath;
            }
        }

        private void SpiteBT_Click(object sender, EventArgs e)
        {
            if (SpliteTXT.Text.Trim() == "")
            {
                MessageBox.Show("分割设置不能为空！");
                SpliteTXT.Focus();
                return;
            }
            if (SelectLB.Text == "")
            {
                MessageBox.Show("请选择保存路径！");
                SpliteTXT.Focus();
                return;
            }
            SpliteOption = SpliteTXT.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public SplitePdf(int Currentpage, int Totalpage)
        {
            InitializeComponent();
            CurrentPage = Currentpage;
            totalPage = Totalpage;
        }
    }
}
