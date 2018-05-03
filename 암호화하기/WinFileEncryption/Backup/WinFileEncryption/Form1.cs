using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WinFileEncryption
{
    public partial class Form1 : Form
    {
        private int[,] iCH = new int[26,2];
        private Hashtable charTable = new Hashtable();
        private ArrayList lineList = new ArrayList();
        private ArrayList keyList = new ArrayList();

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 26; i++)
            {
                this.iCH[i, 0] = 97 + i;
                this.iCH[i, 1] = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.charTable = new Hashtable();
                this.lineList = new ArrayList();
                this.keyList = new ArrayList();

                string strline = "";
                StreamReader sr = new StreamReader(this.openFileDialog1.FileName, Encoding.Default);
                while ((strline = sr.ReadLine()) != null)
                {
                    this.richTextBox1.AppendText(strline + "\n");
                    this.lineList.Add(strline);
                    char[] chSTR = strline.ToLower().ToCharArray();
                    for (int i = 0; i < chSTR.Length; i++)
                    {
                        if ((int)chSTR[i] >= 97 && (int)chSTR[i] <= 122)
                        {
                            //this.iCH[(int)chSTR[i] - 97, 0] = (int)chSTR[i];
                            this.iCH[(int)chSTR[i] - 97, 1]++;
                        }
                    }
                }

                for (int i = 0; i < this.iCH.GetLength(0); i++)
                {
                    //this.richTextBox1.AppendText(((char)this.iCH[i, 0]).ToString() + " : " + this.iCH[i, 1].ToString() + "\n");
                    this.keyList.Add(((char)this.iCH[i, 0]).ToString() + " : " + this.iCH[i, 1].ToString());
                }

                this.richTextBox1.AppendText("==================================================\n");

                for (int i = 0; i < this.iCH.GetLength(0); i++)
                    for (int j = 0; j < this.iCH.GetLength(0) - 1; j++)
                    {
                        int temp1 = this.iCH[j, 0];
                        int temp2 = this.iCH[j, 1];

                        if (this.iCH[j, 1] > this.iCH[j + 1, 1])
                        {
                            this.iCH[j, 0] = this.iCH[j + 1, 0];
                            this.iCH[j + 1, 0] = temp1;
                            this.iCH[j, 1] = this.iCH[j + 1, 1];
                            this.iCH[j + 1, 1] = temp2;
                        }
                    }

                for (int i = 0; i < this.iCH.GetLength(0); i++)
                {
                    //this.richTextBox1.AppendText(((char)this.iCH[i, 0]).ToString() + " : " + this.iCH[i, 1].ToString() + "\n");
                    this.charTable.Add(((char)(i + 97)).ToString(), ((char)this.iCH[i, 0]).ToString());
                }

                //this.richTextBox1.AppendText("==================================================\n");

                for (int i = 0; i < this.charTable.Count; i++)
                {
                    string strValue = this.charTable[((char)(i + 97)).ToString()].ToString();
                    //this.richTextBox1.AppendText(((char)(i + 97)).ToString() + " : " + strValue + "\n");
                }

                // 이곳부터 텍스트 변환 시작
                for (int i = 0; i < this.lineList.Count; i++)
                {
                    string strENC = "";
                    string strTEMP = this.lineList[i].ToString();

                    for (int j = 0; j < strTEMP.Length - 1; j++)
                    {
                        string s1 = strTEMP.Substring(j, 1).ToLower();
                        if (((int)s1.ToCharArray()[0]) >= 97 && ((int)s1.ToCharArray()[0]) <= 122)
                        {
                            string s2 = this.charTable[s1].ToString();
                            strENC += s2;
                        }
                        else
                            strENC += s1;
                    }

                    this.richTextBox2.AppendText(strENC + "\n");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(Application.StartupPath + "\\key.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);

            for (int i = 0; i < this.keyList.Count; i++)
                sw.WriteLine(this.keyList[i].ToString());

            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
