#include<stdio.h>
#include<string.h>
#include "list_cal.h"

//리스트 출력하기
void display(ArrayList *L)
{
	int i;
	printf("\t\t학번\t이름\t\t주소\n");
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
	printf("데이터 수: %d\n\n", L->length);
}


int main(void)
{
	ArrayList list;
	init(&list);

	insert(&list, 0, 2013, "김주안","서울");
	add(&list,2014,"조윤기","서울");
	insert(&list,1,2015,"조휘윤","인천");
	add(&list,2016,"오승주","경기");
	insert(&list,1,2013,"김민석","경기");
	display(&list);
	del(&list,0);
	display(&list);
	

	return 0;

}