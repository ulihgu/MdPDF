using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iTextSharp.text.pdf.PdfDocument;

namespace MdPDF
{
    public partial class DelPdf : Form
    {
        private int deletePage, totalPage;
        public ArrayList alist;

        private void DelBut_Click(object sender, EventArgs e)
        {
            if (DelTextBox.Text.Trim() == "")
            {
                MessageBox.Show("删除页面不能为空！");
                DelTextBox.Focus();
                return;
            }

            alist = new ArrayList();
            string[] selectOp = DelTextBox.Text.Split(',');
            for (int i = 0; i < selectOp.Length; i++)
            {
                if (string.IsNullOrEmpty(selectOp[i]) || selectOp[i].IndexOf('-') == 0)
                {
                    MessageBox.Show("删除页码输入有误！");
                    DelTextBox.Focus();
                    return;
                }
                int result = IsNumeric(selectOp[i]);
                if (result != -1)
                {
                    alist.Add(result);
                }
                else if (selectOp[i].IndexOf('-') > 0)
                {
                    string[] tempArea = selectOp[i].Split('-');
                    if (tempArea.Length == 2)
                    {
                        int temp0 = IsNumeric(tempArea[0]);//获取起点数值
                        int temp1 = IsNumeric(tempArea[1]);//获取终点数值
                        if (temp0 <= temp1)
                        {
                            for (int k = temp0; k <= temp1; k++)
                            {
                                alist.Add(k);
                            }
                        }
                        else
                        {
                            for (int k = temp1; k <= temp0; k++)
                            {
                                alist.Add(k);
                            }
                        }

                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public DelPdf(int delete, int total)
        {
            InitializeComponent();
            deletePage = delete;
            totalPage = total;
        }

        private void DelPdf_Load(object sender, EventArgs e)
        {
            DelLabel.Text = "本文档共" + totalPage.ToString() + "页，准备删除:";
            DelTextBox.Text = (deletePage+1).ToString();
        }

        private void DelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        public int IsNumeric(string str)
        {
            int i;
            if (str != null && Regex.IsMatch(str, @"^\d+$"))
                i = int.Parse(str);
            else
                i = -1;
            return i;
        }
    }
}
