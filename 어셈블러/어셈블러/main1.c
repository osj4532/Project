#include <stdio.h>
#include <string.h>
#include <ctype.h>
#include <math.h>
#include <stdlib.h> //��� �κ�

//�ڷᱸ��
struct reg
{
	char reg_name[3]; //AX
	char reg_num[4]; //010
}Reg[20]; //�������Ϳ� ���� �̸��� ��ȣ�� �����ϴ� ����ü

struct ins
{
	char instruct[6]; //MOV
	char dest[2]; //�������� Ÿ�� R M
	char sour[2]; //������� Ÿ�� R M I
	char word_type[2]; //W B
	char ins_code[3]; //8A
	char ins_len[2]; //2����Ʈ
	char mod_reg[9]; //111???10
}Instr[100], modInstr[100]; //�� �ν�Ʈ������ ������ �����ϴ� ����ü, obj ����ü

int MaxI, InstrP = 0;

struct symbol_tbl
{
	char symbol[10]; //DATA
	char word_type[2]; //W
	int lc; //�ּҰ�
	char data[10]; //57
}Symbol[30];
int MaxS = 0;

struct sentence
{
	char label[10]; //���̺�
	char _operator[10]; //��ɾ�
	char operand[3][10]; //AX, SUM
} Sen; //���� �ڵ� �ӽ� ���� ����ü
int LC; //�����̼� ī����

FILE *ObjSave; //objcode.txt ����
FILE *SymbolSave; //symbol.txt ����

//����� �Լ�
//���Ͽ��� �������Ϳ� �ν�Ʈ������ ������ �д´�.
void Initialize(void)
{
	int i = 0, j = 1;
	FILE *regi, *inst;

	regi = fopen("reg.tbl", "r");
	inst = fopen("inst.tbl", "r");

	while (!feof(regi))
	{
		fscanf(regi, "%s %s\n", Reg[i].reg_name, Reg[i].reg_num);
		i++;
	} //�������� ���̺� �ۼ�

	while (!feof(inst))
	{
		fscanf(inst, "%6s%2s%2s%4s%3s%2s%9s\n", Instr[j].instruct, Instr[j].dest, Instr[j].sour, Instr[j].word_type, Instr[j].ins_code, Instr[j].ins_len, Instr[j].mod_reg);
		j++;
	} //��ɾ� ���̺� �ۼ�
	MaxI = j - 1; //��ɾ��� ����
	fclose(regi);
	fclose(inst);
}

int Analyze(char *operand)
{
	int i = 0;
	char *regist[] = { "AX", "BX", "CX", "DX", "AL", "BL", "CL", "DL", "AH", "BH", "CH", "DH", "SP", "BP", "SI", "DI", "ES", "CS", "SS", "DS", 0x00 };
	//�������� �̸� ����

	if (isdigit(operand[0])) return 0; //immediate ��巹�� ��带 ����
	else
	{
		while (regist[i] != 0x00)
		{
			if (!strcmp(operand, regist[i]))
			{
				if (i <= 3) return 1; //�������� ��� + ����
				else if(i >= 4 && i <= 11) return 2; //�������� ��� + ����Ʈ
				else if (i >= 12) return 3; //���׸�Ʈ �������� ���� ���
			}
			else i++;
		}
	}
	return 4; //�޸� ���� ���
}

#define MAX_INS 3 //��ɾ� �ִ� ������ ����, ����� MOV�� ����

int Add_Chk(char *sen) //���۷����� ��巹�� ��带 ����
{
	register k = MaxI;
	int i = 0, j = 0, l = 0, wp = 0;
	char op[6][10], *opcode[] = { "mov", "add", "sub", "" }; //�м��ϰ����ϴ� ��ɾ�
	while (sen[wp] != '\n')
	{
		while (sen[wp] == ' ' || sen[wp] == '\t' || sen[wp] == ',' ) wp++; //����, ��, �޸��� ���

		while (sen[wp] != ' ' && sen[wp] != '\t' && sen[wp] != ',' && sen[wp] != '\n')
		{
			*(op[j] + i) = sen[wp];
			i++;
			wp++;
		}
		*(op[j] + i) = '\0'; //�������� NULL ����
		i = 0;
		j++;
	}
	i = 0;

	while (strcmp(opcode[i], "")) //��ϵ� ��ɾ��� ������ ��
	{
		if (stricmp(opcode[i], op[0])) i++; //mov ��ɾ�� op[0]�� �ٸ���, ���� ��ɾ� ��ȸ
		else
		{
			strcpy(Sen._operator, op[0]); //��ɾ _operator�� ����
			for (l = 1; l < j; l++)
				strcpy(Sen.operand[l - 1], op[l]); //��ɾ� �� ������ operand�� ����
			break;
		}
	}
	if (i == MAX_INS) //i = 1�̸�, ��ɾ ã�� ���� ��(��ɾ� 1�� ����)  
	{
		strcpy(Sen.label, op[0]); //�� ��� ù �ܾ ���̺� ���
		strcpy(Sen._operator, op[1]); //�� ��° �ܾ ��ɾ ���
		for (l = 2; l < j; l++)
			strcpy(Sen.operand[l - 2], op[l]); //�� ���� ������ operand�� ����
	} //�� ������ �м��Ͽ� ���̺�, ���۷����Ϳ� ���۷���� �з��Ѵ�.

	strcpy(Instr[0].instruct, op[0]); //��ɾ instruct�� ����

	switch (Analyze(op[1])) //������ �м�
	{
	case 0: strcpy(Instr[0].dest, "i"); //�� ��� �Է� ���
		break;

	case 1: strcpy(Instr[0].dest, "r"); //�������� ��� + ����
		strcpy(Instr[0].word_type, "w");
		break;

	case 2: strcpy(Instr[0].dest, "r"); //�������� ��� + ����Ʈ
		strcpy(Instr[0].word_type, "b");
		break;

	case 3: strcpy(Instr[0].dest, "s");
		break;

	case 4: strcpy(Instr[0].dest, "m"); //�޸� ���� ���
		break;
	}

	switch (Analyze(op[2])) //����� �м�
	{
	case 0: strcpy(Instr[0].sour, "i"); //�� ��� �Է� ���
		break;

	case 1: strcpy(Instr[0].sour, "r"); //�������� ��� + ����
		strcpy(Instr[0].word_type, "w");
		break;

	case 2: strcpy(Instr[0].sour, "r"); //�������� ��� + ����Ʈ
		strcpy(Instr[0].word_type, "b");
		break;

	case 3: strcpy(Instr[0].sour, "s");
		break;

	case 4: strcpy(Instr[0].sour, "m"); //�޸� ���� ���
		break;
	}

	while (stricmp(Instr[k].instruct, Instr[0].instruct) || strcmp(Instr[k].dest, Instr[0].dest) || strcmp(Instr[k].sour, Instr[0].sour) || strcmp(Instr[k].word_type, Instr[0].word_type))
	{//instruct, �� ���� ��ɾ�� inst.tbl���� ������ ��ɾ ��
		k--; //���� ���� ã�� ������, k�� �����ϸ� ��
	}
	return k;
}

void pass1(char *buf)
{
	int i;
	static int j = 0;

	i = Add_Chk(buf); //���� �ڵ��� ��ɾ� �ּ� ����� ���Ϲ���

	if (i) //mov ��ɾ ���� ó��
	{
		printf("%04X: %s", LC, buf); //�ּҰ�, ���� �ڵ� ���
		LC += atoi(Instr[i].ins_len); //LC = LC + ��ɾ� ����
	}
	else //��ȣ�� ���� ó��
	{
		if (!stricmp(Sen._operator, "DW"))
			strcpy(Symbol[j].word_type, "w"); //dw��� w�� ����

		else if (!stricmp(Sen._operator, "DB"))
			strcpy(Symbol[j].word_type, "b"); //db��� b�� ����

		strcpy(Symbol[j].symbol, Sen.label); //���̺��� �ɺ��� ����
		strcpy(Symbol[j].data, Sen.operand[0]); //���̺��� ���� ����
		Symbol[j].lc = LC; //�ּҰ��� ����
		printf("%04X: %s", LC, buf); //�ּҰ�, ���� �ڵ� ���

		if (*Symbol[j].word_type == 'w') LC += 2; //�ּҰ��� w=2, b=1��ŭ ����
		else if (*Symbol[j].word_type == 'b') LC += 1;

		j++; // j�� �������� ���� �� �ɺ� �ε����� ������
		MaxS++;
	}
}

//2������ 10������ ��ȯ
int btoi(char *dig)
{
	register i = 0, ret = 0;

	while (*(dig + i) != '\0')
	{
		if (*(dig + i) == '1') ret += pow(2, strlen(dig + i) - 1);
		//dig+i�� ���̴� dig(8)+i(0)���� -1�ϸ� 7�̴�.
		//�������� i�� �����ϹǷ�, 7, 6, 5, 4, 3, 2, 1, 0���� �پ���.

		i++;
	}
	return ret;
}

void pass2(char *buf)
{
	int i, j = 0, k = 0;
	char tmp[8];
	ObjSave = fopen("objCode.txt", "a+");

	i = Add_Chk(buf);

	if (i) //i != 0�� ��, �� ��ɾ��� ���,
	{
		modInstr[InstrP] = Instr[i];

		printf("%04X: %3s", LC, Instr[i].ins_code); //LC�� ��ɾ� �ڵ� ���
		fprintf(ObjSave, "%04X: %3s", LC, Instr[i].ins_code);

		if (!strcmp(Instr[i].dest, "r") || !strcmp(Instr[i].dest, "s")) //�������� r �Ǵ� s�̸�
		{
			while (stricmp(Reg[j].reg_name, Sen.operand[0])) j++;//�������� �������� �̸��� ���� ����

			strncpy(strchr(modInstr[InstrP].mod_reg, '?'), Reg[j].reg_num, 3);
		}

		j = 0;

		if (!strcmp(Instr[i].sour, "r") || !strcmp(Instr[i].sour, "s")) //������� r �Ǵ� s�̸�
		{
			while (stricmp(Reg[j].reg_name, Sen.operand[1])) j++;//�������� �������� �̸��� ���� ����

			strncpy(strchr(modInstr[InstrP].mod_reg, '?'), Reg[j].reg_num, 3);
			//???�� �������� ǥ�� ������ ä��
		}

		if (!strcmp(Instr[i].instruct, "mov") && !strcmp(Instr[i].dest, "r") && !strcmp(Instr[i].sour, "i"))
			strcpy(modInstr[InstrP].mod_reg, itoa(atoi(Sen.operand[1]), tmp, 2));

		if (strcmp(Instr[i].dest, "m") && strcmp(Instr[i].sour, "m")) //������, ������� �Ѵ� m�� �ƴϸ� 
		{
			printf("%02X\t\t%s", btoi(modInstr[InstrP].mod_reg), buf);
			//Instr�� ��ɾ� �ڵ带 16������ ��ȯ �� ���, ���� �ڵ� ���
			fprintf(ObjSave, "%02X\t\t%s", btoi(modInstr[InstrP].mod_reg), buf);
		}
		else //������ or ������� ��ȣ�� �� ���
		{
			if (!strcmp(Instr[i].dest, "m")) //�������� m�� ���
				while (strcmp(Symbol[k].symbol, Sen.operand[0])) k++;
			//�ɺ��� ���� operand�� ã��. �� ��ȣ�� ã��

			else if (!strcmp(Instr[i].sour, "m")) //������� m�� ���
				while (strcmp(Symbol[k].symbol, Sen.operand[1])) k++;
			//�ɺ��� ���� operand�� ã��. �� ��ȣ�� ã��

			if (Symbol[k].lc == (atoi(Symbol[k].data))) //������ ���ġ ���ʿ�
			{
				printf("  %02X\t%04X\t%s", btoi(modInstr[InstrP].mod_reg), Symbol[k].lc, buf);
				fprintf(ObjSave, "  %02X\t%04X\t%s", btoi(modInstr[InstrP].mod_reg), Symbol[k].lc, buf);
			}
			else //�ٸ��� ���ġ �ʿ�
			{
				printf("  %02X\t%04X R\t%s", btoi(modInstr[InstrP].mod_reg), Symbol[k].lc, buf);
				fprintf(ObjSave, "  %02X\t%04X R\t%s", btoi(modInstr[InstrP].mod_reg), Symbol[k].lc, buf);
				//Instr�� ��ɾ� �ڵ带 16���� ��ȯ �� ���, ���� �ڵ� ���
			}
		}
		LC += atoi(Instr[i].ins_len); //LC = LC + ��ɾ� ����
	}

	else //��ȣ�� ���
	{
		k = 0;

		while (strcmp(Symbol[k].symbol, Sen.label)) k++; //symbol�� label�� ���� �� ���� ����, ���� ����

		if (!strcmp(Symbol[k].word_type, "w")) //Ÿ���� w�̸�
		{
			printf("%04X:%04X\t\t%s", LC, atoi(Symbol[k].data), buf);
			fprintf(ObjSave, "%04X:%04X\t\t%s", LC, atoi(Symbol[k].data), buf);
		}

		if (!strcmp(Symbol[k].word_type, "b")) //Ÿ���� b�̸�
		{
			printf("%04X:%04X\t\t%s", LC, atoi(Symbol[k].data), buf);
			fprintf(ObjSave, "%04X:%04X\t\t%s", LC, atoi(Symbol[k].data), buf);
		}

		if (*Symbol[k].word_type == 'w') LC += 2; //w�� �ּҰ� 2 ����, b�� �ְ� 1����

		else if (*Symbol[k].word_type == 'b') LC += 1;
	}
	InstrP++;
	fclose(ObjSave);
}

//��ȣǥ ���
void Symbol_Print()
{
	int i = 0;
	SymbolSave = fopen("symbol.txt", "w+");
	printf("\n *Symbol Table * \n");
	printf("SYMBOL \tDATA(ADDRESS)\tRELOCATION\n");
	for (i = 0; i < MaxS; i++)
	{
		if (!strcmp(Symbol[i].word_type, "w"))
		{
			printf("%s\t%X\t\t%d\n", Symbol[i].symbol, Symbol[i].lc, (Symbol[i].lc != atoi(Symbol[i].data) ? 1 : 0));
			fprintf(SymbolSave, "%s\t%X\t\t%d\n", Symbol[i].symbol, Symbol[i].lc, (Symbol[i].lc != atoi(Symbol[i].data) ? 1 : 0));
		}
		if (!strcmp(Symbol[i].word_type, "b"))
		{
			printf("%s\t%X\t\t%d\n", Symbol[i].symbol, Symbol[i].lc, (Symbol[i].lc != atoi(Symbol[i].data) ? 1 : 0));
			fprintf(SymbolSave, "%s\t%X\t\t%d\n", Symbol[i].symbol, Symbol[i].lc, (Symbol[i].lc != atoi(Symbol[i].data) ? 1 : 0));
		}
	}
	fclose(SymbolSave);
}

//���� �Լ�
void main(void)
{
	char buf[50];
	FILE *in;

	in = fopen("test1.asm", "r"); //����� �ҽ��ڵ�
	Initialize(); //�������� ǥ, ��ɾ� ǥ ����

	printf("\nPass1:\n");

	while (1) //pass 1
	{
		fgets(buf, 30, in);
		if (feof(in)) break;
		pass1(buf);
	}

	Symbol_Print(); //��ȣǥ ���

	rewind(in); //������ �ʱ�ȭ

	LC = 0;
	ObjSave = fopen("objcode.txt", "w+");

	printf("\nPass2:\n");

	while (1) //pass 2
	{
		fgets(buf, 30, in);
		if (feof(in)) break;
		pass2(buf);
	}

	fclose(in);
}
