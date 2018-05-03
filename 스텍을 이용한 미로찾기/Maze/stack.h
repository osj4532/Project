#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include <Windows.h>
#define MAX_STACK_SIZE 100
#define MAX_STRING_SIZE 100 
#define MAZE_SIZE 6

typedef struct {
	short c;
	short r;
}element;




//���� �ڷᱸ��
typedef struct {
	//�ڷᰡ ����� �迭 --> element���� int�̹Ƿ�, �׳� ���� �迭
	element stack[MAX_STACK_SIZE];

	//����Ǿ� �ִ� �ڷ��� ��
	int top;
}stackType;

extern void init(stackType *);
extern int is_empty(stackType *);
extern int is_full(stackType *);
extern void push(stackType *, element);
extern element pop(stackType *);
extern element peek(stackType *);
extern int push_loc(stackType *, int, int);
extern int push_locb(stackType *, int, int);
extern void printStack(stackType *);
extern void printfmaze(char[MAZE_SIZE][MAZE_SIZE]);
extern void goback(stackType *, stackType *, stackType *, stackType *, char[MAZE_SIZE][MAZE_SIZE]);
extern void goexit(stackType *, stackType *, char[MAZE_SIZE][MAZE_SIZE]);