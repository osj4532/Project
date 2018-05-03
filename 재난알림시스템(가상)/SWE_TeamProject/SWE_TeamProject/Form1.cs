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


    public partial class Simulrator : Form
    {
      public String locate="", power = "", time = "";
        public bool[] radioValue = new bool[4];
        public bool[] radioHouseStatus = new bool[4];
        public bool exc = true;
        CellPhone Phone;
        //Form3 Message;

        private void Simulrator_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < radioValue.Length; i++)
                radioValue[i] = false;
        }

        public Simulrator()
        {
            InitializeComponent();
            this.Text = "재난 발생 시뮬레이터";
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500,30);
        }

        private void Earthquake_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Earthquake_radioBtn.Checked == true)
            {
                LocateLabel.Text = "발생 위치";
                PowerLabel.Text = "지진 강도";
                TimeLabel.Text = "발생 시간";
                //기본 설정
                LocateInfo.Text = "경기도 안양시 동안구 시민대로 235 안양시청 ";
                PowerInfo.Text = "2";
                TimeInfo.Text = "오전 11:23";
            }
        }

        private void tsunami_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (tsunami_radioBtn.Checked == true)
            {
                LocateLabel.Text = "발생 지역";
                PowerLabel.Text = "해일 높이";
                TimeLabel.Text = "발생 시간";
                //기본 설정
                LocateInfo.Text = "안양시";
                PowerInfo.Text = "2";
                TimeInfo.Text = "오전 11:23";
            }
        }

        private void yellowDust_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowDust_radioBtn.Checked == true)
            {
                LocateLabel.Text = "황사 지역";
                PowerLabel.Text = "황사 농도";
                TimeLabel.Text = "발생 시간";
                //기본 설정
                LocateInfo.Text = "안양시";
                PowerInfo.Text = "2";
                TimeInfo.Text = "오전 11:23";
            }
        }

        private void tornado_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (tornado_radioBtn.Checked == true)
            {
                LocateLabel.Text = "접근 위치";
                PowerLabel.Text = "바람 세기";
                TimeLabel.Text = "접근 시간";
                //기본 설정
                LocateInfo.Text = "안양시";
                PowerInfo.Text = "2";
                TimeInfo.Text = "오전 11:23";
            }
        }

        private void startDisaster_Btn_Click(object sender, EventArgs e)
        {
            bool checkedRadio = false;

            InitData();

            if (Exception() == true)
                return;
            
           

            for (int i = 0; i < 4; i++) {
                if (radioValue[i] == true)
                    checkedRadio = true;
            }
            if (checkedRadio)
            {
                Phone = new CellPhone();
                Phone.Owner = this;
                Phone.Show();
            }

            else if(!checkedRadio)
                MessageBox.Show("재난 종류를 선택해 주세요.");
        }

        public void InitData() {

            locate = LocateInfo.Text;
            power = PowerInfo.Text;
            time = TimeInfo.Text;

            for (int i = 0; i < radioValue.Length; i++)
                radioValue[i] = false;
            //재난 종류 확인
            if (Earthquake_radioBtn.Checked == true)
                radioValue[0] = true;
            else if (tsunami_radioBtn.Checked == true)
                radioValue[1] = true;
            else if (yellowDust_radioBtn.Checked == true)
                radioValue[2] = true;
            else if (tornado_radioBtn.Checked == true)
                radioValue[3] = true;

            //현관 잠금 확인
            if (doorOpen_Radio.Checked == true)
                radioHouseStatus[0] = true;
            else if (doorClose_Radio.Checked == true)
                radioHouseStatus[0] = false;
            //가스벨브 잠금 확인
            if (valveOpen_Radio.Checked == true)
                radioHouseStatus[1] = true;
            else if (valveClose_Radio.Checked == true)
                radioHouseStatus[1] = false;
            //창문 1 잠금 확인
            if (window1Open_Radio.Checked == true)
                radioHouseStatus[2] = true;
            else if (window1Close_Radio.Checked == true)
                radioHouseStatus[2] = false;
            //창문 2 잠금 확인
            if (window2Open_Radio.Checked == true)
                radioHouseStatus[3] = true;
            else if (window2Close_Radio.Checked == true)
                radioHouseStatus[3] = false;

        }

        public bool Exception()
        {
            if (LocateInfo.Text == "")
            {
                if (Earthquake_radioBtn.Checked == true)
                {
                    MessageBox.Show("발생 위치를 입력하세요");
                    return true;
                }
                if (tsunami_radioBtn.Checked == true)
                {
                    MessageBox.Show("발생 지역을 입력하세요");
                    return true;
                }
                if (yellowDust_radioBtn.Checked == true)
                {
                    MessageBox.Show("황사 지역을 입력하세요.");
                    return true;
                }
                if (tornado_radioBtn.Checked == true)
                {
                    MessageBox.Show("접근 위치를 입력하세요.");
                    return true;
                }
            }

            if (PowerInfo.Text == "")
            {
                if (Earthquake_radioBtn.Checked == true)
                {
                    MessageBox.Show("지진 강도를 입력하세요");
                    return true;
                }
                if (tsunami_radioBtn.Checked == true)
                {
                    MessageBox.Show("해일 높이를 입력하세요");
                    return true;
                }
                if (yellowDust_radioBtn.Checked == true)
                {
                    MessageBox.Show("황사 농도를 입력하세요.");
                    return true;
                }
                if (tornado_radioBtn.Checked == true)
                {
                    MessageBox.Show("바람 세기를 입력하세요.");
                    return true;
                }
            }

            if (NumberOnly(PowerInfo.Text) == false)
            {
                if (Earthquake_radioBtn.Checked == true)
                {
                    MessageBox.Show("지진 강도에 잘못된 값이 들어갔습니다.");
                    return true;
                }
                if (tsunami_radioBtn.Checked == true)
                {
                    MessageBox.Show("해일 높이에 잘못된 값이 들어갔습니다.");
                    return true;
                }
                if (yellowDust_radioBtn.Checked == true)
                {
                    MessageBox.Show("황사 농도에 잘못된 값이 들어갔습니다.");
                    return true;
                }
                if (tornado_radioBtn.Checked == true)
                {
                    MessageBox.Show("바람 세기에 잘못된 값이 들어갔습니다.");
                    return true;
                }

            }

            if (Earthquake_radioBtn.Checked == true)
            {
                    if (double.Parse(PowerInfo.Text) > 10)
                    {
                        MessageBox.Show("10이하의 숫자를 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PowerInfo.Text = "";
                        return true;
                    }
            }
            if (yellowDust_radioBtn.Checked == true)
            {
                
                    if (double.Parse(PowerInfo.Text) > 5)
                    {
                        MessageBox.Show("5이하의 숫자를 입력하시오.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                    }
            }
            if (tornado_radioBtn.Checked == true)
            {
                    if (double.Parse(PowerInfo.Text) < 11)
                    {
                        MessageBox.Show("12이상의 숫자를 입력하시오.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                         return true;
                    }
            }
            
            if (TimeInfo.Text == "")
            {
                if (Earthquake_radioBtn.Checked == true)
                {
                    MessageBox.Show("발생 시간을 입력하세요");
                    return true;
                }
                if (tsunami_radioBtn.Checked == true)
                {
                    MessageBox.Show("발생 시간을 입력하세요");
                    return true;
                }
                if (yellowDust_radioBtn.Checked == true)
                {
                    MessageBox.Show("발생 시간을 입력하세요.");
                    return true;
                }
                if (tornado_radioBtn.Checked == true)
                {
                    MessageBox.Show("접근 시간을 입력하세요.");
                    return true;
                }
            }


            if (TimeException(TimeInfo.Text) == false)
            {
                if (Earthquake_radioBtn.Checked == true)
                {
                    MessageBox.Show("발생 시간이 형식에 맞지 않습니다.\n ex) 오전 09:00");
                    return true;
                }
                if (tsunami_radioBtn.Checked == true)
                {
                    MessageBox.Show("발생 시간이 형식에 맞지 않습니다.\n ex) 오전 09:00");
                    return true;
                }
                if (yellowDust_radioBtn.Checked == true)
                {
                    MessageBox.Show("발생 시간이 형식에 맞지 않습니다.\n ex) 오전 09:00");
                    return true;
                }
                if (tornado_radioBtn.Checked == true)
                {
                    MessageBox.Show("접근 시간이 형식에 맞지 않습니다.\n ex) 오전 09:00");
                    return true;
                }
            }
             return false;
        }

        public bool NumberOnly(string str)
        {
            string tmp = str;

            double Num;

            bool isNum = double.TryParse(tmp, out Num);

            if (isNum)
                return true;
            else
                return false;
            
        }

        public bool TimeException(string str)
        {
            
                string[] tmp;
                tmp = str.Split(' ', ':');
            if(tmp.Length == 3) { 
           
                if (tmp[0] != "오전" && tmp[0] !="오후")
                {
                    return false;
                }
                if(NumberOnly(tmp[1]) == false)
                {
                    return false;
                }
                if(NumberOnly(tmp[2]) == false)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
