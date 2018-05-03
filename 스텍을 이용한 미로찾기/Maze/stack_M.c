#include "stack.h"
extern element here;
extern element entry;
extern element fin;
extern char maze[MAZE_SIZE][MAZE_SIZE];



void init(stackType *s) {
	s->top = -1;
}

//비어있는지 검사
int is_empty(stackType *s) {
	if (s->top == -1)
		return 1;
	else
		return 0;//top이 -1이면 1이 리턴 아니면 0 이 리턴
}

//가득 찼는지 검사
int is_full(stackType *s) {
	if (s->top == (MAX_STACK_SIZE - 1))
		return 1;
	else
		return 0;;//저장되어 있는 데이터의 수가 최대 저장 가능한 수에 대한 값과 같다면 참이 리턴 된다

}
//맨위에 요소를 추가
void push(stackType *s, element item) {
	int top = 0;
	if (is_full(s)) {
		fprintf(stderr, "[ErrOER 포화애러\n]");
		exit(1);
	}

	top = ++(s->top);	//top를 1증가 시킨다
	s->stack[top] = item;//top의 현재 위치가 데이터가  저장될 위치
}

//맨위에 요소를 삭제 - 삭제전에 반환먼저 수행
element pop(stackType *s) {
	int top = 0;
	if (is_empty(s)) {
		fprintf(stderr, "[ERROR] 스택이 비어 있음 \n");
		exit(1);
	}
	top = (s->top)--;//저장된 데이터 수 1갑소
	return s->stack[top];//값을 반환함
}

//맨위에 요소를 삭제하지 않고 반환
element peek(stackType *s) {
	if (is_empty(s)) {
		fprintf(stderr, "[ERROR] 스택이 비어 있음 \n");
		exit(1);
	}
	//마지막 데이터 리턴(카운터의 수는 변화 없음)
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
					case '1':printf("■"); break;
					case '0':printf("□"); break;
					case 'e': printf("○"); break;
					case 'x': printf("＠"); break;
					case 't': printf("★"); break;
					case '.': printf("□"); break;
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