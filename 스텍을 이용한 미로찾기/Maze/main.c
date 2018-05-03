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
			printf("t%d를 찾았습니다", cnt); //t를 먹을대 마다 출력
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
		if ((cnt == 2 && cnt2 == 0) && is_empty(&s)) { //갈곳없고 보물 다 먹었고 스택이 비었을때 갈림길로 이동

			goexit(&wayfin, &allpath, maze);

			break;
		}






		if ((((here.r + 1 == fin.r) && (here.c == fin.c)) || ((here.r == fin.r) && (here.c + 1 == fin.c)) || ((here.r - 1 == fin.r) && (here.c == fin.c)) || ((here.r == fin.r) && (here.c - 1 == fin.c))) && cnt != 2) { //t를 다못먹고 목적지에 도착했을 경우 다시 스택에 추가
			push_locb(&wayfin, fin.r, fin.c);
			goback(&s, &way, &wayfin, &allpath, maze);

		}



		if (cnt2 == 0 && cnt != 2) {			//갈곳없고 보물 다 못먹었을때 갈림길로 이동
			goback(&s, &way, &wayfin, &allpath, maze);
			system("cls");
			printfmaze(maze);

		}

		else if ((cnt2 == 0 && cnt == 2) && !is_empty(&s)) { //갈곳없고 보물 다 먹었을때 갈림길로 이동
			goback(&s, &way, &wayfin, &allpath, maze);
			push_locb(&wayfin, here.r, here.c);
			system("cls");
			printfmaze(maze);

		}

	}
	printf("성공\n");
	printf("지나간 경로\n");
	printStack(&allpath);
	return 0;
}
