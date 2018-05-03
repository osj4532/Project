#include<stdio.h>
#include<stdlib.h>
#include<string.h>

#define MaxStringSize 100

typedef struct element
{
	int stdnum,kor,eng,math;
	char name[MaxStringSize];
}element;

typedef struct ListNode
{
	element data;
	struct ListNode *link;
}ListNode;