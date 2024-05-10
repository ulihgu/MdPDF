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
    public partial class InstPdf : Form
    {
        public string SelectFile = "";
        public int CurrentPage;
        private int totalPage;
        public InstPdf(int Currentpage, int Totalpage)
        {
            InitializeComponent();
            CurrentPage = Currentpage;
            totalPage = Totalpage;
        }

        private void SelectBT_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                ofd.RestoreDirectory = true;
                ofd.Title = "选择合并文件";
                if (ofd.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }
                SelectFile = SelectTxtLB.Text = ofd.FileName;
            }
        }

        private void InstPdf_Load(object sender, EventArgs e)
        {
            PdfInfoLB.Text = "本文档共" + totalPage + "页，准备在";
            InSertPageTXT.Text = CurrentPage.ToString();
        }

        private void InSertPageTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void OKBT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectFile))
            {
                MessageBox.Show("请选择合并的文件");
                return;
            }
            if (Convert.ToInt32(InSertPageTXT.Text.Trim()) > totalPage)
            {
                InSertPageTXT.Text = totalPage.ToString();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
