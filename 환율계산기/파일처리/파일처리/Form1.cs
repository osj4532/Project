using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 파일처리
{
    public partial class Form1 : Form
    {
        StreamReader mdata, graph;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (comboBox6.SelectedIndex==0 && comboBox3.SelectedIndex == 0 && comboBox4.SelectedIndex == 30)
            {
                readdate("10.31.txt");
                grapselect("10.31.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 0)
            {
                readdate("11.01.txt");
                grapselect("11.01.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 1)
            {
                readdate("11.02.txt");
                grapselect("11.02.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 2)
            {
                readdate("11.03.txt");
                grapselect("11.03.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 3)
            {
                readdate("11.04.txt");
                grapselect("11.04.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 6)
            {
                readdate("11.07.txt");
                grapselect("11.07.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 7)
            {
                readdate("11.08.txt");
                grapselect("11.08.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 8)
            {
                readdate("11.09.txt");
                grapselect("11.09.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 9)
            {
                readdate("11.10.txt");
                grapselect("11.10.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 10)
            {
                readdate("11.11.txt");
                grapselect("11.11.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 13)
            {
                readdate("11.14.txt");
                grapselect("11.14.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 14)
            {
                readdate("11.15.txt");
                grapselect("11.15.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 15)
            {
                readdate("11.16.txt");
                grapselect("11.16.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 16)
            {
                readdate("11.17.txt");
                grapselect("11.17.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 17)
            {
                readdate("11.18.txt");
                grapselect("11.18.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 20)
            {
                readdate("11.21.txt");
                grapselect("11.21.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 21)
            {
                readdate("11.22.txt");
                grapselect("11.22.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 22)
            {
                readdate("11.23.txt");
                grapselect("11.23.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 23)
            {
                readdate("11.24.txt");
                grapselect("11.24.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 24)
            {
                readdate("11.25.txt");
                grapselect("11.25.txt");
            }
            else if (comboBox6.SelectedIndex == 0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 27)
            {
                readdate("11.28.txt");
                grapselect("11.28.txt");
            }
            else if (comboBox6.SelectedIndex==0 && comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 28)
            {
                readdate("11.29.txt");
                grapselect("11.29.txt");
            }
            else if (comboBox6.SelectedIndex==0 &&comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 29)
            {
                readdate("11.30.txt");
                grapselect("11.30.txt");
            }
            else
                textBox2.Text="주말이거나 고시표가 없습니다.";

        }


        public void readdate(String date)
        {
            string[] temp = new string[6];
            string[,] temp2 = new string[7, 6];
            double[,] rate = new double[7, 6];
            int cnt = 0;

            mdata = new StreamReader(date);
            for (int i = 0; mdata.Peek() >= 0; i++)
            {
                temp = mdata.ReadLine().Split('\t');
                for (int j = 0; j < 6; j++)
                {
                    temp2[i, j] = temp[j];
                }
                cnt++;
            }
            for (int i = 0; i < cnt; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    rate[i, j] = Convert.ToDouble(temp2[i, j]);
                }
            }
            selectedmeun(rate[6, 1], rate[6, 2], rate[6, 3], rate[6, 4], rate[6, 5]);
        }

        public void selectedmeun(double usd, double jyp, double cny, double eur, double aud)
        {
            double money1 = Convert.ToDouble(textBox1.Text);
            double money2;

            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)// 미국 -> 미국
            {
                textBox2.Text=money1 + "달러";
                
            }

            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)// 미국 -> 일본
            {
                money2 = money1 * usd / (jyp / 100);
                textBox2.Text=money2 + "엔";
                
            }

            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)// 미국 -> 중국
            {
                money2 = money1 * usd / cny;
                textBox2.Text=money2 + "위안";
                
            }

            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3)// 미국 -> EU
            {
                money2 = money1 * usd / eur;
                textBox2.Text=money2 + "유로";
                
            }

            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 4)// 미국 -> 한국
            {
                money2 = money1 * usd;
                textBox2.Text=money2 + "원";
                
            }

            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 5)// 미국 -> 호주
            {
                money2 = money1 * usd / aud;
                textBox2.Text=money2 + "달러";
               
            }

            // 일본 환전
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)// 일본 -> 미국
            {
                money2 = money1 * (jyp / 100) / usd;
                textBox2.Text=money2 + "달러";
                
            }

            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)// 일본 -> 일본
            {
                textBox2.Text=money1 + "엔";
                
            }

            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)// 일본 -> 중국
            {
                money2 = money1 * (jyp / 100) / cny;
                textBox2.Text=money2 + "위안";
                
            }

            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3)// 일본 -> EU
            {
                money2 = money1 * (jyp / 100) / eur;
                textBox2.Text=money2 + "유로";
                
            }

            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 4)// 일본 -> 한국
            {
                money2 = money1 * (jyp / 100);
                textBox2.Text=money2 + "원";
                
            }

            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 5)// 일본 -> 호주
            {
                money2 = money1 * (jyp / 100) / aud;
                textBox2.Text=money2 + "달러";
                
            }

            // 중국 환전
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)// 중국 -> 미국
            {
                money2 = money1 * cny / usd;
                textBox2.Text=money2 + "달러";
                
            }

            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)// 중국 -> 일본
            {
                money2 = money1 * cny / (jyp / 100);
                textBox2.Text=money2 + "달러";
                
            }

            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 2)// 중국 -> 중국
            {
                textBox2.Text=money1 + "위안";
                
            }

            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 3)// 중국 -> EU
            {
                money2 = money1 * cny / eur;
                textBox2.Text=money2 + "유로";
                
            }

            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 4)// 중국 -> 한국
            {
                money2 = money1 * cny;
                textBox2.Text=money2 + "원";
                
            }

            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 5)// 중국 -> 호주
            {
                money2 = money1 * cny / aud;
                textBox2.Text=money2 + "달러";
                
            }

            // EU 환전
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 0)// EU -> 미국
            {
                money2 = money1 * eur / usd;
                textBox2.Text=money2 + "달러";
                
            }

            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 1)// EU -> 일본
            {
                money2 = money1 * eur / (jyp / 100);
                textBox2.Text =money2 + "엔";
                
            }

            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 2)// EU -> 중국
            {
                money2 = money1 * eur / cny;
                textBox2.Text = money2 + "위안";
                
            }

            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 3)// EU -> EU
            {
                textBox2.Text = money1 + "유로";
               
            }

            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 4)// EU-> 한국
            {
                money2 = money1 * eur;
                textBox2.Text =money2 + "원";
                
            }

            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 5)// EU -> 호주
            {
                money2 = money1 * eur / aud;
                textBox2.Text = money2 + "달러";
                
            }

            // 한국 환전
            if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 0)// 한국 -> 미국
            {
                money2 = money1 / usd;
                textBox2.Text = money2 + "달러";
            }

            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 1)// 한국 -> 일본
            {
                money2 = money1 / (jyp / 100);
                textBox2.Text = money2 + "엔";
            }

            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 2)// 한국 -> 중국
            {
                money2 = money1 / cny;
                textBox2.Text = money2 + "위안";
            }

            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 3)// 한국 -> EU
            {
                money2 = money1 / eur;
                textBox2.Text =money2 + "유로";
            }

            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 4)// 한국 -> 한국
            {
                textBox2.Text = money1 + "원";
            }

            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 5)// 한국 -> 호주
            {
                money2 = money1 / aud;
                textBox2.Text = money2 + "달러";
            }

            //	호주 환전
            if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 0)// 호주 -> 미국
            {
                money2 = money1 * aud / usd;
                textBox2.Text = money2 + "달러";
                
            }

            else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 1)// 호주 -> 일본
            {
                money2 = money1 * aud / (jyp / 100);
                textBox2.Text = money2 + "엔";
                
            }

            else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 2)// 호주 -> 중국
            {
                money2 = money1 * aud / cny;
                textBox2.Text = money2 + "위안";
                
            }

            else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 3)// 호주 -> EU
            {
                money2 = money1 * aud / eur;
                textBox2.Text = money2 + "유로";
               
            }

            else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 4)// 호주 -> 한국
            {
                money2 = money1 * aud;
                textBox2.Text = money2 + "원";
                
            }

            else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 5)// 호주-> 호주
            {
                textBox2.Text = money1 + "달러";
                
            }

        }

        public void grapselect(String date)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                chart1.Series[0].Points.Clear();
                usdgraph(date);
            }
            if (comboBox5.SelectedIndex == 1)
            {
                chart1.Series[0].Points.Clear();
                jpygraph(date);
            }
            if (comboBox5.SelectedIndex == 2)
            {
                chart1.Series[0].Points.Clear();
                cnygraph(date);
            }
            if (comboBox5.SelectedIndex == 3)
            {
                chart1.Series[0].Points.Clear();
                eurgraph(date);
            }
            if (comboBox5.SelectedIndex == 4)
            {
                chart1.Series[0].Points.Clear();
                audgraph(date);
            }
        }
        public void usdgraph(String date)
        { 
            graph = new StreamReader(date);
            string[] rate = new string[6];
            string[,] rate1 = new string[7, 6];
            chart1.ChartAreas[0].AxisY.Maximum = 1205;
            chart1.ChartAreas[0].AxisY.Minimum = 1150;

            for (int i = 0; graph.Peek() >= 0; i++)
            {
                rate = graph.ReadLine().Split('\t');
                for (int j = 0; j < 6; j++)
                {
                    rate1[i, j] = rate[j];
                }
            }

            for (int i = 0; i < 7; i++)
            {
                chart1.Series[0].Points.AddXY(rate1[i, 0], rate1[i, 1]);
            }
            graph.Close();
        }
        public void jpygraph(String date)
        {
            graph = new StreamReader(date);
            string[] rate = new string[6];
            string[,] rate1 = new string[7, 6];
            chart1.ChartAreas[0].AxisY.Maximum = 1135;
            chart1.ChartAreas[0].AxisY.Minimum = 1050;

            for (int i = 0; graph.Peek() >= 0; i++)
            {
                rate = graph.ReadLine().Split('\t');
                for (int j = 0; j < 6; j++)
                {
                    rate1[i, j] = rate[j];
                }
            }

            for (int i = 0; i < 7; i++)
            {
                chart1.Series[0].Points.AddXY(rate1[i, 0], rate1[i, 2]);
            }
            graph.Close();
        }
        public void cnygraph(String date)
        {
            graph = new StreamReader(date);
            string[] rate = new string[6];
            string[,] rate1 = new string[7, 6];
            chart1.ChartAreas[0].AxisY.Maximum = 180;
            chart1.ChartAreas[0].AxisY.Minimum = 150;

            for (int i = 0; graph.Peek() >= 0; i++)
            {
                rate = graph.ReadLine().Split('\t');
                for (int j = 0; j < 6; j++)
                {
                    rate1[i, j] = rate[j];
                }
            }

            for (int i = 0; i < 7; i++)
            {
                chart1.Series[0].Points.AddXY(rate1[i, 0], rate1[i, 3]);
            }
            graph.Close();
        }
        public void eurgraph(String date)
        {
            graph = new StreamReader(date);
            string[] rate = new string[6];
            string[,] rate1 = new string[7, 6];
            chart1.ChartAreas[0].AxisY.Maximum = 1300;
            chart1.ChartAreas[0].AxisY.Minimum = 1250;

            for (int i = 0; graph.Peek() >= 0; i++)
            {
                rate = graph.ReadLine().Split('\t');
                for (int j = 0; j < 6; j++)
                {
                    rate1[i, j] = rate[j];
                }
            }

            for (int i = 0; i < 7; i++)
            {
                chart1.Series[0].Points.AddXY(rate1[i, 0], rate1[i, 4]);
            }
            graph.Close();
        }
        public void audgraph(String date)
        {
            graph = new StreamReader(date);
            string[] rate = new string[6];
            string[,] rate1 = new string[7, 6];
            chart1.ChartAreas[0].AxisY.Maximum = 910;
            chart1.ChartAreas[0].AxisY.Minimum = 880;

            for (int i = 0; graph.Peek() >= 0; i++)
            {
                rate = graph.ReadLine().Split('\t');
                for (int j = 0; j < 6; j++)
                {
                    rate1[i, j] = rate[j];
                }
            }

            for (int i = 0; i < 7; i++)
            {
                chart1.Series[0].Points.AddXY(rate1[i, 0], rate1[i, 5]);
            }
            graph.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
