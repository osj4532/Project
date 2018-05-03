#include "stack.h"
extern element here;
extern element entry;
extern element fin;
extern char maze[MAZE_SIZE][MAZE_SIZE];



void init(stackType *s) {
	s->top = -1;
}

//����ִ��� �˻�
int is_empty(stackType *s) {
	if (s->top == -1)
		return 1;
	else
		return 0;//top�� -1�̸� 1�� ���� �ƴϸ� 0 �� ����
}

//���� á���� �˻�
int is_full(stackType *s) {
	if (s->top == (MAX_STACK_SIZE - 1))
		return 1;
	else
		return 0;;//����Ǿ� �ִ� �������� ���� �ִ� ���� ������ ���� ���� ���� ���ٸ� ���� ���� �ȴ�

}
//������ ��Ҹ� �߰�
void push(stackType *s, element item) {
	int top = 0;
	if (is_full(s)) {
		fprintf(stderr, "[ErrOER ��ȭ�ַ�\n]");
		exit(1);
	}

	top = ++(s->top);	//top�� 1���� ��Ų��
	s->stack[top] = item;//top�� ���� ��ġ�� �����Ͱ�  ����� ��ġ
}

//������ ��Ҹ� ���� - �������� ��ȯ���� ����
element pop(stackType *s) {
	int top = 0;
	if (is_empty(s)) {
		fprintf(stderr, "[ERROR] ������ ��� ���� \n");
		exit(1);
	}
	top = (s->top)--;//����� ������ �� 1����
	return s->stack[top];//���� ��ȯ��
}

//������ ��Ҹ� �������� �ʰ� ��ȯ
element peek(stackType *s) {
	if (is_empty(s)) {
		fprintf(stderr, "[ERROR] ������ ��� ���� \n");
		exit(1);
	}
	//������ ������ ����(ī������ ���� ��ȭ ����)
	return s->stack[s->top];
}

int push_loc(stackType *s, int r, int c) {
	if (r<0 || c<0) return 0;
	if (maze[r][c] != '1'&&maze[r][c] != '.') {
		element tmp;
		tmp.r = r;
		tmp.c = c;
		push(s, tmp);
		return 1;
	}
	return 0;


}
int push_locb(stackType *s, int r, int c) {
	if (r<0 || c<0) return 0;
	if (maze[r][c] != '1') {
		element tmp;
		tmp.r = r;
		tmp.c = c;
		push(s, tmp);
		return 1;
	}
	return 0;


}
void printStack(stackType *s) {
	int i;
	for (i = 5; i>s->top; i--)
		printf("|      |\n");
	for (i = s->top; i >= 0; i--)
		printf("|(%01d,%01d)|\n", s->stack[i].c, s->stack[i].r);
	printf("---------\n");

}
void printfmaze(char m[MAZE_SIZE][MAZE_SIZE]) {
	int r, c;
	for (r = 0; r<MAZE_SIZE; r++) {
		for (c = 0; c<MAZE_SIZE; c++) {
			if (c == here.c&&r == here.r)// COORD Cur; Cur.X = 0, Cur.
				printf(" m");
			else {
				if (m[r][c] == 0)
					printf("0 ");
				else {
					switch (m[r][c]) {
					case '1':printf("��"); break;
					case '0':printf("��"); break;
					case 'e': printf("��"); break;
					case 'x': printf("��"); break;
					case 't': printf("��"); break;
					case '.': printf("��"); break;
					}

				}
			}
		}
		printf("\n");
	}
	printf("\n\n");

}
void goback(stackType *s, stackType *way, stackType *wayfin, stackType *allpath, char m[MAZE_SIZE][MAZE_SIZE]) {
	while (1) {
		if (((here.r + 1 == peek(s).r) && (here.c == peek(s).c)) || ((here.r == peek(s).r) && (here.c + 1 == peek(s).c)) ||
			((here.r - 1 == peek(s).r) && (here.c == peek(s).c)) || ((here.r == peek(s).r) && (here.c - 1 == peek(s).c))) {
			push_locb(way, here.r, here.c);
			here = pop(s);
			push(allpath, here);
			printfmaze(maze);
			//system("cls");
			push_locb(way, here.r, here.c);
			break;
		}
		else {
			here = pop(way);
			push(allpath, here);
			push_locb(wayfin, here.r, here.c);
			system("cls");
			printfmaze(maze);
			getchar();
			system("cls");
		}
	}
}
void goexit(stackType *wayfin, stackType *allpath, char m[MAZE_SIZE][MAZE_SIZE]) {
	while (1) {
		if (here.r == fin.r&&here.c == fin.c) {
			getchar();
			system("cls");
			break;
		}
		else {
			getchar();
			system("cls");
			here = pop(wayfin);
			push(allpath, here);
			printfmaze(maze);
		}
	}

}