#include<stdio.h>

#define MAX_LIST_SIZE 100 //���������� ������ �� �ִ� �ڷ��� �ִ� ũ��
#define Max_String_Size 100
//���������� �����ϱ� ���� �ڷ��� Ÿ�� ����

typedef struct{
	int stdnum;
	char name[Max_String_Size];
	char add[Max_String_Size];
}element;


// List�ڷᱸ���� ���� ����ü ����
typedef struct {
	element list[MAX_LIST_SIZE];
	//element list[MAX_LIST_SIZE]; //�ڷᰡ ����� �迭 ���� element �� ���� �ٲٸ� �����Ҽ� �ִ� ���� �ٲܼ� �ִ�
	int length;// ���� ����Ǿ� �ִ� �ڷ��� ��

}ArrayList;
