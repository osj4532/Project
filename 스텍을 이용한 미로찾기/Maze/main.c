#include "maze.h"

int main() {
	int r, c;
	int cnt = 0, cnt2 = 0;
	stackType s, way, wayfin, allpath;
	init(&s);
	init(&way);
	init(&wayfin);
	init(&allpath);
	here = entry;

	printfmaze(maze);
	printf("\n\n");


	while (maze[here.r][here.c] != 'x' || cnt != 2) {
		cnt2 = 0;
		r = here.r;
		c = here.c;
		getchar();
		system("cls");

		if (maze[r][c] == 't') {
			cnt++;
			printf("t%d�� ã�ҽ��ϴ�", cnt); //t�� ������ ���� ���
		}

		maze[r][c] = '.';
		if (push_loc(&s, r - 1, c) == 1)
			cnt2++;
		if (push_loc(&s, r + 1, c) == 1)
			cnt2++;
		if (push_loc(&s, r, c - 1) == 1)
			cnt2++;

		if (push_loc(&s, r, c + 1) == 1)
			cnt2++;


		if (cnt2 != 0) {

			here = pop(&s);
			push(&allpath, here);
			push_loc(&way, here.r, here.c);
			push_locb(&wayfin, here.r, here.c);
			printfmaze(maze);

		}
		if ((cnt == 2 && cnt2 == 0) && is_empty(&s)) { //�������� ���� �� �Ծ��� ������ ������� ������� �̵�

			goexit(&wayfin, &allpath, maze);

			break;
		}






		if ((((here.r + 1 == fin.r) && (here.c == fin.c)) || ((here.r == fin.r) && (here.c + 1 == fin.c)) || ((here.r - 1 == fin.r) && (here.c == fin.c)) || ((here.r == fin.r) && (here.c - 1 == fin.c))) && cnt != 2) { //t�� �ٸ��԰� �������� �������� ��� �ٽ� ���ÿ� �߰�
			push_locb(&wayfin, fin.r, fin.c);
			goback(&s, &way, &wayfin, &allpath, maze);

		}



		if (cnt2 == 0 && cnt != 2) {			//�������� ���� �� ���Ծ����� ������� �̵�
			goback(&s, &way, &wayfin, &allpath, maze);
			system("cls");
			printfmaze(maze);

		}

		else if ((cnt2 == 0 && cnt == 2) && !is_empty(&s)) { //�������� ���� �� �Ծ����� ������� �̵�
			goback(&s, &way, &wayfin, &allpath, maze);
			push_locb(&wayfin, here.r, here.c);
			system("cls");
			printfmaze(maze);

		}

	}
	printf("����\n");
	printf("������ ���\n");
	printStack(&allpath);
	return 0;
}
