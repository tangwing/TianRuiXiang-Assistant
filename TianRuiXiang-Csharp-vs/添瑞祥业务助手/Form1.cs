using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace 添瑞祥业务助手
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists("pattern.ini"))
            {
                StreamWriter sw = new StreamWriter("pattern.ini");
                sw.Write("111100*");
                sw.Close();
            }
            StreamReader sr = new StreamReader("pattern.ini");
            txtPattern.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("pattern.ini");
            sw.Write(txtPattern.Text);
            sw.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //rtxtData.Text = "q\nqd\nc";
            


            String[] items = rtxtData.Text.Trim().Split(new char[1] { '\n' });
            ArrayList sameItemList = new ArrayList();
            ArrayList shortItems = new ArrayList();
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals("-")) continue;
                if (items[i].Length < 8)
                {
                    shortItems.Add((i + 1) + " ： " + items[i]);
                    continue;
                }
                
                ArrayList lineNo = new ArrayList();
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[i].Equals(items[j]))
                    {
                        if (lineNo.Count == 0)
                            lineNo.Add(i);
                        lineNo.Add(j);
                        items[j] = "-";
                    }
                }
                if (lineNo.Count > 0)
                    sameItemList.Add(lineNo);
            }
            
            rtxtInfo.Text = "";
            if (sameItemList.Count == 0 && shortItems.Count == 0)
            {
                rtxtInfo.Text = "检测通过，未发现问题";
                return;
            }

            //处理重复数据
            if( sameItemList.Count > 0 )
            {
                for(int i=0; i<sameItemList.Count;i++)
                {
                    ArrayList lineNos = (ArrayList)sameItemList[i];
                    rtxtInfo.SelectionFont = new Font(rtxtInfo.SelectionFont, FontStyle.Bold);
                    rtxtInfo.AppendText("重复数据" + (i + 1) + "\n");
                    rtxtInfo.AppendText("数值：" + items[(int)lineNos[0]] + "\n行号：");
                    foreach (int number in lineNos)
                    {
                        rtxtInfo.AppendText( number+1 + ", ");

                    }
                    rtxtInfo.Select(rtxtInfo.TextLength-2, 2);
                    rtxtInfo.SelectedText="\n\n";
                }
                
            }
            //处理过短数据
            if (shortItems.Count > 0)
            {
                rtxtInfo.SelectionFont = new Font(rtxtInfo.SelectionFont, FontStyle.Bold);
                rtxtInfo.AppendText("缺位数据(行号：数值)\n");
                foreach (string shorts in shortItems)
                {
                    rtxtInfo.AppendText(" "+shorts + "\n");
                    //rtxtInfo.s;
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            rtxtData.SelectAll();
            rtxtData.Copy();
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            String[] items = rtxtData.Text.Trim().Split(new char[1] { '\n' });
            rtxtData.Clear();
            for (int i = 0; i < items.Length; i++)
            {
                rtxtData.AppendText(txtPattern.Text.Replace("*", items[i]) + "\n");
            }
        }
    }
}
