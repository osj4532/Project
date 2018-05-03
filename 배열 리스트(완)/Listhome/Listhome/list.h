#include<stdio.h>

#define MAX_LIST_SIZE 100 //내부적으로 보관하 수 있는 자료의 최대 크기
#define Max_String_Size 100
//내부적으로 보관하기 위한 자료의 타입 정의

typedef struct{
	int stdnum;
	char name[Max_String_Size];
	char add[Max_String_Size];
}element;


// List자료구조를 위한 구조체 정의
typedef struct {
	element list[MAX_LIST_SIZE];
	//element list[MAX_LIST_SIZE]; //자료가 정장될 배열 정의 element 위 형을 바꾸면 저장할수 있는 형을 바꿀수 있다
	int length;// 현제 저장되어 있는 자료의 수

}ArrayList;
