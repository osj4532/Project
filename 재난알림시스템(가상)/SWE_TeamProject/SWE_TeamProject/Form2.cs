using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_TeamProject
{

    public partial class CellPhone : Form
    {
        Application App;
        public String location="", power = "", time = "", currentLocation = "";
        public String door, valve, win1, win2;
        public bool autoControl = false;
        String temp = "";
        bool[] checkdRadioBtn = new bool[4];
        
        private void Form2_Load(object sender, EventArgs e)
        {
            

            InitData();



            //지진
            if (checkdRadioBtn[0] == true)
            {
                Earthquake();
            }

            //해일
            else if (checkdRadioBtn[1] == true)
            {
                Tsunami();
            }
            //황사
            else if (checkdRadioBtn[2] == true)
            {
                YellowDust();
            }
            //태풍
            else if (checkdRadioBtn[3] == true) {

                Tornado();

            }
        }

        public CellPhone()
        {
            InitializeComponent();
            this.Text = "사용자 핸드폰";
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(380, 300);


        }

        private void AppBtn_Click(object sender, EventArgs e)
        {
            currentLocation = currentLocation_TextBox.Text;

            //어플리케이션 실행
            if (currentLocation != "")
            {
                App = new Application();
                App.Owner = this;
                App.Show();
            }
            else
                MessageBox.Show("현재 위치 값을 입력해주세요.");
        }

        public void InitData() {

            Simulrator f1 = (Simulrator)this.Owner;
            this.location = f1.locate;
            this.power = f1.power;
            this.time = f1.time;
            checkdRadioBtn = f1.radioValue;
           
        }

        public void Tsunami() {

            if (float.Parse(power) >= 0.5 && float.Parse(power) < 1.0)
            {
                playSound("file://D:\\주의보.wav");
                temp = "주의보";
            }
            else if (float.Parse(power) >= 1.0)
            {
                playSound("file://D:\\경보.wav");
                temp = "경보";
            }
            //경보음 추가 하기
            currentLocation_TextBox.Text = "강원도 강릉시 내곡동 522";
            temp = "해일" + temp + "\n" + "발생 지역 : " + location + "\n" + "해일 높이 : " + power + "m\n" + "발생 시각 : " + time;
            MessageBox.Show(temp, "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        public void Earthquake() {

            if (float.Parse(power) < 3.5)
            {
                playSound("file://D:\\주의보.wav");
                temp = "약진";
            }
                
            else if (float.Parse(power) >= 3.5)
            {
                playSound("file://D:\\경보.wav");
                temp = "강진";
            }
            currentLocation_TextBox.Text = "경기도 안양시 만안구 삼덕로37번길 22 안양대학교";
            temp = temp +"발생!" + "\n" + "발생 지역 : " + location + "\n" + "지진 강도 : " + power + "\n" + "발생 시각 : " + time ;
            MessageBox.Show(temp, "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void YellowDust() {

            switch (power) {
                case "4":
                    temp = "황사 발생! \n황사 지역: " + location + "\n발생 시각: " + time + "\n황사 농도: 심함";
                    MessageBox.Show(temp, "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "5":
                    temp = "황사 발생! \n황사 지역: " + location + "\n발생 시각: " + time + "\n황사 농도: 매우 심함" ;
                    MessageBox.Show(temp, "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
   
            }
            currentLocation_TextBox.Text = "안양시";

        }

        public void Tornado() {

            if (float.Parse(power) < 33)
            {
                playSound("file://D:\\주의보.wav");
                temp = "2급";
            }
                
            else if (float.Parse(power) >= 33)
            {
                playSound("file://D:\\경보.wav");
                temp = "1급";
            }
                

            currentLocation_TextBox.Text = "안양시";
            temp = temp + "태풍 발생!" + "\n" + "접근 지역 : " + location + "\n" + "바람 세기 : " + power + "m/s\n" + "접근 시각 : " + time;
           MessageBox.Show(temp, "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
        }

        private void playSound(string path)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }

    }
}
