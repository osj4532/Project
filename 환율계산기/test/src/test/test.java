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
	
	String[] selc1={"-��-","10��","11��"};
	String[] selc2={"-��-","1��","2��","3��","4��","5��","6��","7��","8��","9��","10��","11��","12��","13��","14��","15��",
			"16��","17��","18��","19��","20��","21��","22��","23��","24��","25��","26��","27��","28��","29��","30��","31��"};
	String[] selc3={"-���� ����-","�̱�(�޷�)","�Ϻ�(��)","�߱�(����)","EU(����)","�ѱ�(��)","ȣ��(�޷�)"};
	
	JLabel l1 = new JLabel("�ݾ� �Է�");
	JLabel l2 = new JLabel("���� �ݾ�");
	JLabel l3 = new JLabel(" => ");
	JLabel l4 = new JLabel("��¥ ����");
	
	JButton bt1;
	
	public test(){
	
	//������ �⺻ Ʋ ����
	super("ȯ�� ����");
	setSize(800,700);//������ ������
	setResizable(false);//ũ�� ����
	setAlwaysOnTop(true); //�׻�����
	setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	frm.setBackground(Color.LIGHT_GRAY);
	frm.setLayout(new FlowLayout());
	
	//���� ���� �޴�
	add(l4);
	month = new JComboBox(selc1);
	data = new JComboBox(selc2);
	add(month);
	add(data);
	
	//�ݾ� �Է� ��
	add(l1);
	add(input1);
	
	//�ٲ� ���� ���ö�
	nara1 = new JComboBox(selc3);
	add(nara1);
	
	add(l3);
	
	//�ٲ� �ݾ� ǥ�ö�
	add(l2);
	input2.setEditable(false);
	add(input2);
	
	//�ٲ� ���� ���ö�
	nara2 = new JComboBox(selc3);
	add(nara2);
	
	bt1 = new JButton("��ȯ");
	bt1.addActionListener(new exc());
	add(bt1);
	
	input3 = new JTextArea(20,70);
	add(input3);
	setVisible(true);
	}
	
	
	public static void main(String[] args) {
		test m = new test();
		
	}
	
	//�׼� ������ ����
	class exc implements ActionListener 
	{	
		@Override
		public void actionPerformed (ActionEvent e)
		{
			if(month.getSelectedIndex()==1 && data.getSelectedIndex()==31){ //10�� 31��
				readdate("10.31");
			}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==1){ //11�� 1��
				readdate("11.01");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==2){ //11�� 2��
				readdate("11.02");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==3){ //11�� 3��
				readdate("11.03");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==4){ //11�� 4��
				readdate("11.04");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==7){ //11�� 7��
				readdate("11.07");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==8){ //11�� 8��
				readdate("11.08");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==9){ //11�� 9��
				readdate("11.09");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==10){ //11�� 10��
				readdate("11.10");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==11){ //11�� 11��
				readdate("11.11");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==14){ //11�� 14��
				readdate("11.14");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==15){ //11�� 15��
				readdate("11.15");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==16){ //11�� 16��
				readdate("11.16");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==17){ //11�� 17��
				readdate("11.17");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==18){ //11�� 18��
				readdate("11.18");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==21){ //11�� 21��
				readdate("11.21");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==22){ //11�� 22��
				readdate("11.22");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==23){ //11�� 23��
				readdate("11.23");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==24){ //11�� 24��
				readdate("11.24");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==25){ //11�� 25��
				readdate("11.25");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==28){ //11�� 28��
				readdate("11.28");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==29){ //11�� 29��
				readdate("11.29");
		}
			else if(month.getSelectedIndex()==2 && data.getSelectedIndex()==30){ //11�� 30��
				
				readdate("11.30");
		}
			else
			{
				input2.setText("���ǥ�� �����ϴ�.");
				input3.setText("�ָ��̰ų� ���ǥ�� �����ϴ�.");
			}
	}//������ ����
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
			
			if(nara1.getSelectedIndex() == 1 && nara2.getSelectedIndex() == 1)// �̱� -> �̱�
			{
				input2.setText(money1+"�޷�");
			}
		
			else if(nara1.getSelectedIndex() == 1 && nara2.getSelectedIndex() == 2)// �̱� -> �Ϻ�
			{
				money2 = money1 * usd / (jyp/100);
				input2.setText(money2+"��");
			}
		
			else if(nara1.getSelectedIndex() == 1 && nara2.getSelectedIndex() == 3)// �̱� -> �߱�
			{
				money2 = money1 * usd / cny;
				input2.setText(money2+"����");
			}
		
			else if(nara1.getSelectedIndex() == 1 && nara2.getSelectedIndex() == 4)// �̱� -> EU
			{
				money2 = money1 * usd / eur;
				input2.setText(money2+"����");
			}
		
			else if(nara1.getSelectedIndex() == 1 && nara2.getSelectedIndex() == 5)// �̱� -> �ѱ�
			{
				money2 = money1 * usd;
				input2.setText(money2+"��");
			}
			
			else if(nara1.getSelectedIndex() == 1 && nara2.getSelectedIndex() == 6)// �̱� -> ȣ��
			{
				money2 = money1 * aud;
				input2.setText(money2+"�޷�");
			}
			
			// �Ϻ� ȯ��
			if(nara1.getSelectedIndex() == 2 && nara2.getSelectedIndex() == 1)// �Ϻ� -> �̱�
			{
				money2 = money1 * (jyp/100) / usd;
				input2.setText(money2+"�޷�");
			}
			
			else if(nara1.getSelectedIndex() == 2 && nara2.getSelectedIndex() == 2)// �Ϻ� -> �Ϻ�
			{
				input2.setText(money1+"��");
			}
			
			else if(nara1.getSelectedIndex() == 2 && nara2.getSelectedIndex() == 3)// �Ϻ� -> �߱�
			{
				money2 = money1 * (jyp/100) / cny;
				input2.setText(money2+"����");
			}
			
			else if(nara1.getSelectedIndex() == 2 && nara2.getSelectedIndex() == 4)// �Ϻ� -> EU
			{
				money2 = money1 * (jyp/100) / eur;
				input2.setText(money2+"����");
			}
			
			else if(nara1.getSelectedIndex() == 2 && nara2.getSelectedIndex() == 5)// �Ϻ� -> �ѱ�
			{
				money2 = money1 * (jyp/100);
				input2.setText(money2+"��");
			}
			
			else if(nara1.getSelectedIndex() == 2 && nara2.getSelectedIndex() == 6)// �Ϻ� -> ȣ��
			{
				money2 = money1 * (jyp/100) / aud;
				input2.setText(money2+"�޷�");
			}
			
			// �߱� ȯ��
			if(nara1.getSelectedIndex() == 3 && nara2.getSelectedIndex() == 1)// �߱� -> �̱�
			{
				money2 = money1 * cny / usd;
				input2.setText(money2+"�޷�");
			}
			
			else if(nara1.getSelectedIndex() == 3 && nara2.getSelectedIndex() == 2)// �߱� -> �Ϻ�
			{
				money2 = money1 * cny / (jyp/100);
				input2.setText(money2+"�޷�");
			}
			
			else if(nara1.getSelectedIndex() == 3 && nara2.getSelectedIndex() == 3)// �߱� -> �߱�
			{
				input2.setText(money1+"����");
			}
			
			else if(nara1.getSelectedIndex() == 3 && nara2.getSelectedIndex() == 4)// �߱� -> EU
			{
				money2 = money1 * cny / eur;
				input2.setText(money2+"����");
			}
			
			else if(nara1.getSelectedIndex() == 3 && nara2.getSelectedIndex() == 5)// �߱� -> �ѱ�
			{
				money2 = money1 * cny;
				input2.setText(money2+"��");
			}
			
			else if(nara1.getSelectedIndex() == 3 && nara2.getSelectedIndex() == 6)// �߱� -> ȣ��
			{
				money2 = money1 * cny / aud;
				input2.setText(money2+"�޷�");
			}
		
			// EU ȯ��
			if(nara1.getSelectedIndex() == 4 && nara2.getSelectedIndex() == 1)// EU -> �̱�
			{
				money2 = money1 * eur / usd;
				input2.setText(money2+"�޷�");
			}
			
			else if(nara1.getSelectedIndex() == 4 && nara2.getSelectedIndex() == 2)// EU -> �Ϻ�
			{
				money2 = money1 * eur / (jyp/100);
				input2.setText(money2+"��");
			}
			
			else if(nara1.getSelectedIndex() == 4 && nara2.getSelectedIndex() == 3)// EU -> �߱�
			{
				money2 = money1 * eur / cny;
				input2.setText(money2+"����");
			}
			
			else if(nara1.getSelectedIndex() == 4 && nara2.getSelectedIndex() == 4)// EU -> EU
			{
				input2.setText(money1+"����");
			}
			
			else if(nara1.getSelectedIndex() == 4 && nara2.getSelectedIndex() == 5)// EU-> �ѱ�
			{
				money2 = money1 * eur;
				input2.setText(money2+"��");
			}
			
			else if(nara1.getSelectedIndex() == 4 && nara2.getSelectedIndex() == 6)// EU -> ȣ��
			{
				money2 = money1 * eur / aud;
				input2.setText(money2+"�޷�");
			}
			
			// �ѱ� ȯ��
			if(nara1.getSelectedIndex() == 5 && nara2.getSelectedIndex() == 1)// �ѱ� -> �̱�
			{
				money2 = money1 / usd;
				input2.setText(money2+"�޷�");
			}
			
			else if(nara1.getSelectedIndex() == 5 && nara2.getSelectedIndex() == 2)// �ѱ� -> �Ϻ�
			{
				money2 = money1 / (jyp/100);
				input2.setText(money2+"��");
			}
			
			else if(nara1.getSelectedIndex() == 5 && nara2.getSelectedIndex() == 3)// �ѱ� -> �߱�
			{
				money2 = money1 / cny;
				input2.setText(money2+"����");
			}
			
			else if(nara1.getSelectedIndex() == 5 && nara2.getSelectedIndex() == 4)// �ѱ� -> EU
			{
				money2 = money1 / eur;
				input2.setText(money2+"����");
			}
		
			else if(nara1.getSelectedIndex() == 5 && nara2.getSelectedIndex() == 5)// �ѱ� -> �ѱ�
			{
				input2.setText(money1+"��");
			}
		
			else if(nara1.getSelectedIndex() == 5 && nara2.getSelectedIndex() == 6)// �ѱ� -> ȣ��
			{
				money2 = money1 / aud;
				input2.setText(money2+"�޷�");
			}
			
			//	ȣ�� ȯ��
			if(nara1.getSelectedIndex() == 6 && nara2.getSelectedIndex() == 1)// ȣ�� -> �̱�
			{
				money2 = money1 * aud / usd;
				input2.setText(money2+"�޷�");
			}
			
			else if(nara1.getSelectedIndex() == 6 && nara2.getSelectedIndex() == 2)// ȣ�� -> �Ϻ�
			{
				money2 = money1 * aud / (jyp/100);
				input2.setText(money2+"��");
			}
		
			else if(nara1.getSelectedIndex() == 6 && nara2.getSelectedIndex() == 3)// ȣ�� -> �߱�
			{
				money2 = money1 * aud / cny;
				input2.setText(money2+"����");
			}
			
			else if(nara1.getSelectedIndex() == 6 && nara2.getSelectedIndex() == 4)// ȣ�� -> EU
			{
				money2 = money1 * aud / eur;
				input2.setText(money2+"����");
			}
			
			else if(nara1.getSelectedIndex() == 6 && nara2.getSelectedIndex() == 5)// ȣ�� -> �ѱ�
			{
				money2 = money1 * aud;
				input2.setText(money2+"��");
			}
			
			else if(nara1.getSelectedIndex() == 6 && nara2.getSelectedIndex() == 6)// ȣ��-> ȣ��
			{
				input2.setText(money1+"�޷�");
			}
	}
}
	
