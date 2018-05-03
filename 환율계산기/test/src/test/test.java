package test;

import javax.swing.*;
import javax.swing.event.*;
import java.awt.*;
import java.awt.event.*;
import java.io.*;
import java.util.Scanner;
import java.util.StringTokenizer;


public class test extends JFrame {
	
	Container frm = getContentPane();
	JTextField input1 = new JTextField(10);
	JTextField input2 = new JTextField(10);
	JTextArea input3;
	
	JComboBox nara1, nara2, month, data;
	
	String[] selc1={"-월-","10월","11월"};
	String[] selc2={"-일-","1일","2일","3일","4일","5일","6일","7일","8일","9일","10일","11일","12일","13일","14일","15일",
			"16일","17일","18일","19일","20일","21일","22일","23일","24일","25일","26일","27일","28일","29일","30일","31일"};
	String[] selc3={"-국가 선택-","미국(달러)","일본(엔)","중국(위안)","EU(유로)","한국(원)","호주(달러)"};
	
	JLabel l1 = new JLabel("금액 입력");
	JLabel l2 = new JLabel("변경 금액");
	JLabel l3 = new JLabel(" => ");
	JLabel l4 = new JLabel("날짜 선택");
	
	JButton bt1;
	
	public test(){
	
	//프레임 기본 틀 설정
	super("환율 계산기");
	setSize(800,700);//프레인 싸이즈
	setResizable(false);//크기 고정
	setAlwaysOnTop(true); //항상위에
	setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	frm.setBackground(Color.LIGHT_GRAY);
	frm.setLayout(new FlowLayout());
	
	//요일 선택 메뉴
	add(l4);
	month = new JComboBox(selc1);
	data = new JComboBox(selc2);
	add(month);
	add(data);
	
	//금액 입력 란
	add(l1);
	add(input1);
	
	//바꿀 나라 선택란
	nara1 = new JComboBox(selc3);
	add(nara1);
	
	add(l3);
	
	//바꾼 금액 표시란
	add(l2);
	input2.setEditable(false);
	add(input2);
	
	//바뀐 나라 선택란
	nara2 = new JComboBox(selc3);
	add(nara2);
	
	bt1 = new JButton("변환");
	bt1.addActionListener(new exc());
	add(bt1);
	
	input3 = new JTextArea(20,70);
	add(input3);
	setVisible(true);
	}
	
	
	public static void main(String[] args) {
		test m = new test();
		
	}
	
	//액션 리스너 정의
	class exc implements ActionListener 
	{	
		@Override
		public void actionPerformed (ActionEvent e)
		{
			if(month.getSelectedIndex()==1 && data.getSelectedIndex()==31){ //10월 31일
				readdate("10.31");
			}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==1){ //11월 1일
				readdate("11.01");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==2){ //11월 2일
				readdate("11.02");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==3){ //11월 3일
				readdate("11.03");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==4){ //11월 4일
				readdate("11.04");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==7){ //11월 7일
				readdate("11.07");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==8){ //11월 8일
				readdate("11.08");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==9){ //11월 9일
				readdate("11.09");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==10){ //11월 10일
				readdate("11.10");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==11){ //11월 11일
				readdate("11.11");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==14){ //11월 14일
				readdate("11.14");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==15){ //11월 15일
				readdate("11.15");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==16){ //11월 16일
				readdate("11.16");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==17){ //11월 17일
				readdate("11.17");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==18){ //11월 18일
				readdate("11.18");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==21){ //11월 21일
				readdate("11.21");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==22){ //11월 22일
				readdate("11.22");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==23){ //11월 23일
				readdate("11.23");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==24){ //11월 24일
				readdate("11.24");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==25){ //11월 25일
				readdate("11.25");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==28){ //11월 28일
				readdate("11.28");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==29){ //11월 29일
				readdate("11.29");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==30){ //11월 30일
				
				readdate("11.30");
		}
			else
			{
				input2.setText("고시표가 없습니다.");
				input3.setText("주말이거나 고시표가 없습니다.");
			}
	}//리스너 정의
	}
		public void readdate(String date)
		{
			int[] rate = new int[35];
			String temp;
			try{
				 Scanner sc = new Scanner(new File("10.31"));
				 String str = sc.nextLine();
				 StringTokenizer word = new StringTokenizer(str, " ");
				 int i=0;
				for(int j=0;j<7;j++)
				{
					
				 	while(word.hasMoreTokens())
				 	{
				 		temp = word.nextToken();
				 		rate[i] = Integer.parseInt(temp);
				 		System.out.println(rate[i]);
				 		i++;
				 	}
				 	str = sc.nextLine();
				 	word = new StringTokenizer(str, " ");
				}
			}catch (FileNotFoundException v){
				v.printStackTrace();
			}catch(IOException v){
				v.printStackTrace();
			}
				selectedmenu(rate[30],rate[31],rate[32],rate[33],rate[34]);
		}
		public void selectedmenu(int usd, int jyp, int cny, int eur, int aud)
		{
			float money1 = Integer.parseInt(input1.getText());
			float money2;
			
			if(nara1.getSelectedIndex() == 1 && nara2.getSelectedIndex() == 1)// 미국 -> 미국
			{
				input2.setText(money1+"달러");
			}
		
			else if(nara1.getSelectedIndex() == 1 && nara2.getSelectedIndex() == 2)// 미국 -> 일본
			{
				money2 = money1 * usd / (jyp/100);
				input2.setText(money2+"엔");
			}
		
			else if(nara1.getSelectedIndex() == 1 && nara2.getSelectedIndex() == 3)// 미국 -> 중국
			{
				money2 = money1 * usd / cny;
				input2.setText(money2+"위안");
			}
		
			else if(nara1.getSelectedIndex() == 1 && nara2.getSelectedIndex() == 4)// 미국 -> EU
			{
				money2 = money1 * usd / eur;
				input2.setText(money2+"유로");
			}
		
			else if(nara1.getSelectedIndex() == 1 && nara2.getSelectedIndex() == 5)// 미국 -> 한국
			{
				money2 = money1 * usd;
				input2.setText(money2+"원");
			}
			
			else if(nara1.getSelectedIndex() == 1 && nara2.getSelectedIndex() == 6)// 미국 -> 호주
			{
				money2 = money1 * aud;
				input2.setText(money2+"달러");
			}
			
			// 일본 환전
			if(nara1.getSelectedIndex() == 2 && nara2.getSelectedIndex() == 1)// 일본 -> 미국
			{
				money2 = money1 * (jyp/100) / usd;
				input2.setText(money2+"달러");
			}
			
			else if(nara1.getSelectedIndex() == 2 && nara2.getSelectedIndex() == 2)// 일본 -> 일본
			{
				input2.setText(money1+"엔");
			}
			
			else if(nara1.getSelectedIndex() == 2 && nara2.getSelectedIndex() == 3)// 일본 -> 중국
			{
				money2 = money1 * (jyp/100) / cny;
				input2.setText(money2+"위안");
			}
			
			else if(nara1.getSelectedIndex() == 2 && nara2.getSelectedIndex() == 4)// 일본 -> EU
			{
				money2 = money1 * (jyp/100) / eur;
				input2.setText(money2+"유로");
			}
			
			else if(nara1.getSelectedIndex() == 2 && nara2.getSelectedIndex() == 5)// 일본 -> 한국
			{
				money2 = money1 * (jyp/100);
				input2.setText(money2+"원");
			}
			
			else if(nara1.getSelectedIndex() == 2 && nara2.getSelectedIndex() == 6)// 일본 -> 호주
			{
				money2 = money1 * (jyp/100) / aud;
				input2.setText(money2+"달러");
			}
			
			// 중국 환전
			if(nara1.getSelectedIndex() == 3 && nara2.getSelectedIndex() == 1)// 중국 -> 미국
			{
				money2 = money1 * cny / usd;
				input2.setText(money2+"달러");
			}
			
			else if(nara1.getSelectedIndex() == 3 && nara2.getSelectedIndex() == 2)// 중국 -> 일본
			{
				money2 = money1 * cny / (jyp/100);
				input2.setText(money2+"달러");
			}
			
			else if(nara1.getSelectedIndex() == 3 && nara2.getSelectedIndex() == 3)// 중국 -> 중국
			{
				input2.setText(money1+"위안");
			}
			
			else if(nara1.getSelectedIndex() == 3 && nara2.getSelectedIndex() == 4)// 중국 -> EU
			{
				money2 = money1 * cny / eur;
				input2.setText(money2+"유로");
			}
			
			else if(nara1.getSelectedIndex() == 3 && nara2.getSelectedIndex() == 5)// 중국 -> 한국
			{
				money2 = money1 * cny;
				input2.setText(money2+"원");
			}
			
			else if(nara1.getSelectedIndex() == 3 && nara2.getSelectedIndex() == 6)// 중국 -> 호주
			{
				money2 = money1 * cny / aud;
				input2.setText(money2+"달러");
			}
		
			// EU 환전
			if(nara1.getSelectedIndex() == 4 && nara2.getSelectedIndex() == 1)// EU -> 미국
			{
				money2 = money1 * eur / usd;
				input2.setText(money2+"달러");
			}
			
			else if(nara1.getSelectedIndex() == 4 && nara2.getSelectedIndex() == 2)// EU -> 일본
			{
				money2 = money1 * eur / (jyp/100);
				input2.setText(money2+"엔");
			}
			
			else if(nara1.getSelectedIndex() == 4 && nara2.getSelectedIndex() == 3)// EU -> 중국
			{
				money2 = money1 * eur / cny;
				input2.setText(money2+"위안");
			}
			
			else if(nara1.getSelectedIndex() == 4 && nara2.getSelectedIndex() == 4)// EU -> EU
			{
				input2.setText(money1+"유로");
			}
			
			else if(nara1.getSelectedIndex() == 4 && nara2.getSelectedIndex() == 5)// EU-> 한국
			{
				money2 = money1 * eur;
				input2.setText(money2+"원");
			}
			
			else if(nara1.getSelectedIndex() == 4 && nara2.getSelectedIndex() == 6)// EU -> 호주
			{
				money2 = money1 * eur / aud;
				input2.setText(money2+"달러");
			}
			
			// 한국 환전
			if(nara1.getSelectedIndex() == 5 && nara2.getSelectedIndex() == 1)// 한국 -> 미국
			{
				money2 = money1 / usd;
				input2.setText(money2+"달러");
			}
			
			else if(nara1.getSelectedIndex() == 5 && nara2.getSelectedIndex() == 2)// 한국 -> 일본
			{
				money2 = money1 / (jyp/100);
				input2.setText(money2+"엔");
			}
			
			else if(nara1.getSelectedIndex() == 5 && nara2.getSelectedIndex() == 3)// 한국 -> 중국
			{
				money2 = money1 / cny;
				input2.setText(money2+"위안");
			}
			
			else if(nara1.getSelectedIndex() == 5 && nara2.getSelectedIndex() == 4)// 한국 -> EU
			{
				money2 = money1 / eur;
				input2.setText(money2+"유로");
			}
		
			else if(nara1.getSelectedIndex() == 5 && nara2.getSelectedIndex() == 5)// 한국 -> 한국
			{
				input2.setText(money1+"원");
			}
		
			else if(nara1.getSelectedIndex() == 5 && nara2.getSelectedIndex() == 6)// 한국 -> 호주
			{
				money2 = money1 / aud;
				input2.setText(money2+"달러");
			}
			
			//	호주 환전
			if(nara1.getSelectedIndex() == 6 && nara2.getSelectedIndex() == 1)// 호주 -> 미국
			{
				money2 = money1 * aud / usd;
				input2.setText(money2+"달러");
			}
			
			else if(nara1.getSelectedIndex() == 6 && nara2.getSelectedIndex() == 2)// 호주 -> 일본
			{
				money2 = money1 * aud / (jyp/100);
				input2.setText(money2+"엔");
			}
		
			else if(nara1.getSelectedIndex() == 6 && nara2.getSelectedIndex() == 3)// 호주 -> 중국
			{
				money2 = money1 * aud / cny;
				input2.setText(money2+"위안");
			}
			
			else if(nara1.getSelectedIndex() == 6 && nara2.getSelectedIndex() == 4)// 호주 -> EU
			{
				money2 = money1 * aud / eur;
				input2.setText(money2+"유로");
			}
			
			else if(nara1.getSelectedIndex() == 6 && nara2.getSelectedIndex() == 5)// 호주 -> 한국
			{
				money2 = money1 * aud;
				input2.setText(money2+"원");
			}
			
			else if(nara1.getSelectedIndex() == 6 && nara2.getSelectedIndex() == 6)// 호주-> 호주
			{
				input2.setText(money1+"달러");
			}
	}
}
	
