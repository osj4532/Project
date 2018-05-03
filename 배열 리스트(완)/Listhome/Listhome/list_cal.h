#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include "list.h"

//����ó�� �Լ�
void error(char *message) {
	fprintf(stderr, "%s\n", message);
	exit(1);
}

//����Ʈ �ʱ�ȭ
void init(ArrayList *L)
{
	L->length = 0;
}

//����Ʈ�� ��� ������ true, �׷��� ������ false�� ��ȯ
int is_empty(ArrayList *L)
{
	return L->length == 0;
}


//����Ʈ�� ���� �� ������ true(1), �׷��� ������ false(0)�� ��ȯ
int is_full(ArrayList *L)
{
	return (L->length == MAX_LIST_SIZE);
}

void add(ArrayList *L, int num,char name[],char add[])
{ 
	if (!is_full(L))
	{
		L->list[L->length].stdnum = num;
		strcpy(L->list[L->length].name,name);
		strcpy(L->list[L->length++].add,add);

	}
}

//position: �����ϰ��� �ϴ� ��ġ 
void insert(ArrayList *L, int position, int num,char name[],char add[])
{
	int i;
	//�����Ͱ� ���� �� ���, ���� ��ġ�� 0���� ���� ���
	if (!is_full(L)&&(position>=0)&&(position <= L->length)) {
		for (i = L->length - 1; i >= position; i--) // lenth -1=������ִ� ������ �������� ��ġ
		{
			L->list[i + 1] = L->list[i];
		}
		L->list[position].stdnum = num;
		strcpy(L->list[position].name,name);
		strcpy(L->list[position].add,add);

		L->length++;
	}
}

//Ư�� ��ġ�� ������ ����
void del(ArrayList *L,int position)
{
	int i;

	if (position < 0 || position >= L->length)
	{
		error("���� ��ġ ����");
	}
	//������ ��ġ���� �� ������ ���� �ϳ��� �������
	for (i = position; i < (L->length - 1); i++)
	{
		L->list[i] = L->list[i + 1];
	}
	//�� ������ ���� 0
	L->length--;
}
