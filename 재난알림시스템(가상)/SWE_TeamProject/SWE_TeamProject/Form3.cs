using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace SWE_TeamProject
{
     public partial class shelterLocation : Form
    {
        string location;
        String[] divideText;
        double latitude, destinationLatitude; 
        double longtitude, destinationLongtitude;
        bool[] disasterRadio = new bool[4];

        private void shelterLocation_Web_Load(object sender, EventArgs e)
        {
            Application f4 = (Application)this.Owner;
            Simulrator f1 = (Simulrator)this.Owner.Owner.Owner;

            this.disasterRadio = f1.radioValue;
            this.location = f4.currentLocation;
            shelterLocation_Web.ScriptErrorsSuppressed = true;

            //지진 혹은 해일 일경우 맵 생성
            if (disasterRadio[0] == true || disasterRadio[1] == true)
            {
                MakeMap();
            }
            else if (disasterRadio[3]) {

                shelterLocation_Web.Navigate("http://m.kma.go.kr/m/risk/risk_01.jsp");

            }
                
                
        }

        public shelterLocation()
        {
            InitializeComponent();
            

        }

        //HTML작성
        public void CreateHTML() {

            StreamWriter sw2 = new StreamWriter("D:\\Map.html");

            sw2.WriteLine("<!DOCTYPE html>");
            sw2.WriteLine("<html>");
            sw2.WriteLine("<head>");
            sw2.WriteLine("  <meta charset=\"UTF - 8\">");
            sw2.WriteLine("  <meta http-equiv=\"X - UA - Compatible\" content=\"IE = edge\">");
            sw2.WriteLine("  <meta name=\"viewport\" content=\"width = device - width, initial - scale = 1.0, maximum - scale = 1.0, minimum - scale = 1.0, user - scalable = no\">");
            sw2.WriteLine("  <title>간단한 지도 표시하기</title>");
            sw2.WriteLine("<script type=\"text/javascript\" src=\"https://openapi.map.naver.com/openapi/v3/maps.js?clientId=55niVRO1uQsHVLQ15xDv\"></script>");
            sw2.WriteLine("</head>");
            sw2.WriteLine("<body>");
            sw2.WriteLine("<div id=\"map\" style=\"width: 100 %; height: 400px; \"></div>");
            sw2.WriteLine("<script>");

            sw2.WriteLine("var mapOptions = {  center: new naver.maps.LatLng(" + latitude + "," + longtitude + ")," + "zoom: 8, scaleControl: false, logoControl: false, mapDataControl: false, zoomControl: true, minZoom: 1};");

            sw2.WriteLine("var map = new naver.maps.Map(\'map\', mapOptions);");
            sw2.WriteLine("var marker = new naver.maps.Marker({ position: new naver.maps.LatLng(" + latitude + "," + longtitude + ")," + "map: map});");
            sw2.WriteLine("var marker = new naver.maps.Marker({ position: new naver.maps.LatLng(" + destinationLatitude + "," + destinationLongtitude + ")," + "map: map});");


            sw2.WriteLine("</script>");
            sw2.WriteLine("</body>");
            sw2.WriteLine("</html>");


            sw2.Close();
        }
        public void MakeMap() {

            string[] temp;                          //split 후 저장
            string temp2;                           //LeadLine 데이터 저장
            double[] minimumDistance = new double[2];
            StreamReader sw = null;

            string url = "https://openapi.naver.com/v1/map/geocode?query=" + location; // 결과가 JSON 포맷
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", "N6Q8DVZQz6lIklEsPSZX"); // 클라이언트 아이디
            request.Headers.Add("X-Naver-Client-Secret", "uvDXg5KPMk");       // 클라이언트 시크릿

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string status = response.StatusCode.ToString();

            if (status == "OK")
            {
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                string text = reader.ReadToEnd();
                divideText = text.Split('\n');
                longtitude = double.Parse(divideText[17].Split(':')[1].Split(',')[0]);           //현재위치의 경도
                latitude = double.Parse(divideText[18].Split(':')[1].Split(',')[0]);             //현재위치의 위도(32 ~ 48)
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Error 발생=" + status);
            }

            if (disasterRadio[0] == true) {

                 sw = new StreamReader("EarthquakeShelterLocation.txt");

            }
            else if(disasterRadio[1] == true){

                 sw = new StreamReader("NationalShelterLocation.txt");

            }

            temp2 = sw.ReadLine();
            temp = temp2.Split('\t');

            minimumDistance[0] = Math.Sqrt(Math.Pow(double.Parse(temp[0]) - longtitude, 2.0) + Math.Pow(double.Parse(temp[1]) - latitude, 2.0));
            destinationLongtitude = double.Parse(temp[0]);
            destinationLatitude = double.Parse(temp[1]);

            //현재위치와 비교하여 최단거리 구하기
            while ((temp2 = sw.ReadLine()) != null)
            {
                temp = temp2.Split('\t');

                minimumDistance[1] = Math.Sqrt(Math.Pow(double.Parse(temp[0]) - longtitude, 2.0) + Math.Pow(double.Parse(temp[1]) - latitude, 2.0));
                //128.242557	36.921483
                if (minimumDistance[1] < minimumDistance[0])
                {

                    minimumDistance[0] = minimumDistance[1];
                    destinationLongtitude = double.Parse(temp[0]);
                    destinationLatitude = double.Parse(temp[1]);

                }
            }

            CreateHTML();
            shelterLocation_Web.Navigate("file://D:\\Map.html");
            sw.Close();
        }
    }
}
