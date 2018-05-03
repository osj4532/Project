#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include "list.h"

//오류처리 함수
void error(char *message) {
	fprintf(stderr, "%s\n", message);
	exit(1);
}

//리스트 초기화
void init(ArrayList *L)
{
	L->length = 0;
}

//리스트가 비어 있으면 true, 그렇지 않으면 false를 반환
int is_empty(ArrayList *L)
{
	return L->length == 0;
}


//리스트가 가득 차 있으면 true(1), 그렇지 않으면 false(0)를 반환
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

//position: 삽입하고자 하는 위치 
void insert(ArrayList *L, int position, int num,char name[],char add[])
{
	int i;
	//데이터가 가득 찬 경우, 저장 위치가 0보다 작은 경우
	if (!is_full(L)&&(position>=0)&&(position <= L->length)) {
		for (i = L->length - 1; i >= position; i--) // lenth -1=저장되있는 마지막 데이터의 위치
		{
			L->list[i + 1] = L->list[i];
		}
		L->list[position].stdnum = num;
		strcpy(L->list[position].name,name);
		strcpy(L->list[position].add,add);

		L->length++;
	}
}

//특정 위치의 데이터 삭제
void del(ArrayList *L,int position)
{
	int i;

	if (position < 0 || position >= L->length)
	{
		error("삭제 위치 오류");
	}
	//삭제될 위치부터 맨 끝까지 값을 하나씩 끌어당긴다
	for (i = position; i < (L->length - 1); i++)
	{
		L->list[i] = L->list[i + 1];
	}
	//맨 마지막 값은 0
	L->length--;
}
