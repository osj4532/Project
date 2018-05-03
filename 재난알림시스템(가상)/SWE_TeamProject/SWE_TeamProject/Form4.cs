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
    public partial class Application : Form
    {
        private bool[] AutoFlag = new bool[4];
        private bool[] currentHouseStatus = new bool[4];
        private bool[] disaterRadio = new bool[4];
        private String location, power, time;
        private bool isDisaster, autoControl;
        private String door, valve, win1, win2;

       

        private String act = null;
        private String temp = null;
        public String currentLocation = "";


        public Application()
        {
            InitializeComponent();
            this.Text = "어플리케이션";
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(680, 300);


            for(int i =0; i< 4; i++)
            {
                AutoFlag[i] = false;
            }

            if (richTextBox1.Text != "") { 
                isDisaster = true;
                autoChange();
            }
            else
                isDisaster = false;

            richTextBox1.ReadOnly = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            InitData();

            

            if (location !="" && power != "" && time != "")
            {
                richTextBox1.Text = temp;
              
                richTextBox1.Text += act;
               
            }
        }

        //Auto버튼 true/falase   on/off 로 바뀌고 콘솔에 출력
        public void togleBtn(Button Auto,int i)
        {
            AutoFlag[i] = !AutoFlag[i];
            if (AutoFlag[i] == true)
                Auto.Text = "On";
            else
                Auto.Text = "Off";
            Console.WriteLine(i+"번" + AutoFlag[0]);
        }

        //조건이 만족되면 라이오 버튼을 전부 off로 설정
        public void autoChange()
        {
            for (int i = 0; i < AutoFlag.Length; i++)
            {
                if (isDisaster == true && AutoFlag[i] == true)
                {
                    if (i == 0)
                        doorClose_Radio.Checked = true;
                    else if (i == 1)
                        valveClose_Radio.Checked = true;
                    else if (i == 2)
                        window1Close_Radio.Checked = true;
                    else if (i == 3)
                        window2Close_Radio.Checked = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form shelter = new shelterLocation();
            shelter.Owner = this;
            shelter.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button Auto = (Button)sender;
            if (Auto.Name == "button1")
            {
                togleBtn(Auto, 0);
            }
            else if(Auto.Name == "button2")
            {
                togleBtn(Auto, 1);
            }
            else if (Auto.Name == "button3")
            {
                togleBtn(Auto, 2);
            }
            else if (Auto.Name == "button4")
            {
                togleBtn(Auto, 3);
            }

            autoChange();
        }

        //새로운 소식이 업데이트 되면 바뀜
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isDisaster = true;
            autoChange();
        }

        public void InitData() {

            CellPhone f2 = (CellPhone)this.Owner;
            Simulrator f1 = (Simulrator)this.Owner.Owner;
            this.location = f2.location;
            this.power = f2.power;
            this.time = f2.time;
            this.currentLocation = f2.currentLocation;
            this.currentHouseStatus = f1.radioHouseStatus;
            this.disaterRadio = f1.radioValue;
            this.autoControl = f2.autoControl;
            //지진 발생시 행동요령
            if (disaterRadio[0] == true)
            {

                act = "집안에 있을경우 : 탁자 아래로 들어가 몸을 보호합니다.전기와 가스를 차단하고 출구확보후 밖으로 나갑니다.\n" +
            "집밖에 있을경우 : 가방이나 손으로 머리를 보호하며 건물과 거리를 두고 넓은 공간으로 대피합니다.\n" +
            "지진 발생시 엘리베이터를 이용하면 안되고 안에있다면 가까운층에 내려 계단을 이용합니다.\n" +
            "산이나 바다일 경우 안전한곳으로 이동하고 지진 해일 특보가 발령되면 높은곳으로 이동합니다.";
                temp = "지진 발생!\n발생 위치: " + location + "\n발생 시각: " + time + "\n지진 강도: " + power + "\n";
            }
            //해일 발생시 행동요령
            else if (disaterRadio[1] == true) {

                act = "지진해일 특보 등으로 지진해일 내습이 확인되면 모든 수단을 동원하여 서로에게 알리도록 합시다.\n" +
                    "일본 서해안에서 지진 발생 후 우리나라 동해안에는 약 1~2시간 이내에 지진해일이 도달하므로 해안가에서는 작업을 중단하고, 위험물(부유 가능한 물건, 충돌 때 충격이 큰 물건, 유류 등)을 이동시키며, 신속히 고지대로 대피하도록 합시다.\n" +
                    "항 내 선박은 움직이지 않도록 고정하거나 가능한 한 항 외로 이동시키고, 기상특보를 경청하며 지시에 따르도록 합시다.\n" +
                    "해안가에 있을 때 강한 지진동을 느꼈을 경우는 국지적인 해일의 발생 가능성이 있고, 약 2～3분 이내에 해일이 내습할 수 있으므로 지진해일 특보가 발효되지 않았더라도 신속히 고지대로 이동하도록 합시다.\n";

                temp = "해일 발생!\n발생 지역: " + location + "\n발생 시각: " + time + "\n해일 높이: " + power + "\n";
            }
            //황사 발생시 행동요령
            else if (disaterRadio[2] == true)
            {
                button5.Enabled = false;
                button5.Text = "";
                act = "가정에서 : 황사가 실내로 들어오지 못하도록 창문 등을 점검하고 외출시 필요한 보호안경, 마스크, 긴소매 의복, 위생용기 등을 준비 노약자, 호흡기 질환자의 경우는 실외활동을 자제\n" +
            "학교 등 교육기관에서 : 학교 등 교육기관에서 기상예보를 정취, 지역설정에 맞게 휴업 또는 단축수업 검토 학생 비상연락망 점검 및 연락체계 유지 맞벌이부부 자녀에 대한 자율학습 대책 등 수립 황사대비 행동요령 지도 및 홍보 실시\n" +
            "축산·시설원 등 농가에서 : 가축이 활동하는 운동장 및 방목장의 가축 대피준비 노지에 방치, 이적된 사료용 볏짚 등에 대하나 비닐 등 피복물품준비 동력분무기 등 황사세척용 장비 점검 및 정비 비닐하우스, 온실 등 시설물의 출입문 및 환기창점검\n";

                String pow = null;

                switch (power)
                {
                    case "1":
                        pow = "매우 쾌적";
                        break;
                    case "2":
                        pow = "쾌적";
                        break;
                    case "3":
                        pow = "보통";
                        break;
                    case "4":
                        pow = "심함";
                        break;
                    case "5":
                        pow = "매우 심함";
                        break;
                }

                temp = "황사 발생!\n황사 지역: " + location + "\n발생 시각: " + time + "\n황사 농도: " + pow + "\n";

            }
            //태풍 발생시 행동요령
            else if (disaterRadio[3] == true)
            {
                button5.Text = "태풍 영상 확인";
                act = "도시지역 : 고층아파트 등 대형·고층건물에 거주하고 계신 주민은 유리창에 테이프를 붙여 파손에 대비합시다.\n" +
                        "건물의 간판 및 위험시설물 주변으로 걸어가거나 접근하지 맙시다.\n" +
                        "바람에 날아갈 물건이 집주변에 있다면 미리 제거합시다.\n" +
                        "농촌지역 : 주택주변의 산사태 위험이 있을 경우 미리 대피합시다.\n" +
                        "논둑을 미리 점검하시고 물꼬를 조정합시다. 다리는 안전한지 확인한 후에 이용합시다.\n" +
                        "비닐하우스, 인삼재배시설 등을 단단히 묶어 둡시다.\n" +
                        "해안지역 : 해안가의 위험한 비탈면에 접근하지 맙시다.\n" +
                        "바닷가의 저지대 주민은 안전한 곳으로 대피합시다.\n" +
                        "해수욕장 이용은 하지 맙시다.\n";
                temp = "태풍 발생!\n접근 위치: " + location + "\n접근 시각: " + time + "\n바람 세기: " + power + "\n";
            }


            //현관문
            if (currentHouseStatus[0] == true)
                door = "열림";
            else
                door = "닫힘";

            //가스 벨브
            if (currentHouseStatus[1] == true)
                valve = "열림";
            else
                valve = "닫힘";

            //창문 1
            if (currentHouseStatus[2] == true)
                win1 = "열림";
            else
                win1 = "닫힘";

            //창문 2
            if (currentHouseStatus[3] == true)
                win2 = "열림";
            else
                win2 = "닫힘";

            if (MessageBox.Show("현관: " + door + "\n가스벨브: " + valve + "\n창문1: " + win1 + "\n창문2:" + win2 + "\n자동으로 잠그시겠습니까?",
                "현재 집상황", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                autoControl = true;

            //현관문
            if (currentHouseStatus[0] == true)
                doorOpen_Radio.Checked = true;
            else
                doorClose_Radio.Checked = true;

            //가스 벨브
            if (currentHouseStatus[1] == true)
                valveOpen_Radio.Checked = true;
            else
                valveClose_Radio.Checked = true;
            
            //창문 1
            if (currentHouseStatus[2] == true)
                window1Open_Radio.Checked = true;
            else
                window1Close_Radio.Checked = true;

            //창문 2
            if (currentHouseStatus[3] == true)
                window2Open_Radio.Checked = true;
            else
                window2Close_Radio.Checked = true;

            if(autoControl == true)
            {
                doorClose_Radio.Checked = true;
                valveClose_Radio.Checked = true;
                window1Close_Radio.Checked = true;
                window2Close_Radio.Checked = true;
            }
        }
    }
}
