#include<stdio.h>
#include<string.h>
#include "list_cal.h"

//����Ʈ ����ϱ�
void display(ArrayList *L)
{
	int i;
	printf("\t\t�й�\t�̸�\t\t�ּ�\n");
	printf("----------------------------------------------------\n");
	if (is_empty(L)) {
		printf("ArrayList is empty!! \n");
	}
	else {
		for (i = 0; i < L->length; i++)
		{
			printf("ArrayList[%03d]=%d\t%s\t\t%s\t\n", i, L->list[i].stdnum,L->list[i].name,L->list[i].add);
			
		}
	}
	printf("----------------------------------------------------\n");
	printf("������ ��: %d\n\n", L->length);
}


int main(void)
{
	ArrayList list;
	init(&list);

	insert(&list, 0, 2013, "���־�","����");
	add(&list,2014,"������","����");
	insert(&list,1,2015,"������","��õ");
	add(&list,2016,"������","���");
	insert(&list,1,2013,"��μ�","���");
	display(&list);
	del(&list,0);
	display(&list);
	

	return 0;

}