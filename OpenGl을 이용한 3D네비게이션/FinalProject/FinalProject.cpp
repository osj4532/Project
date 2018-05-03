#include <stdio.h>
#include <math.h>
#include <gl/glut.h>					
#include <gl/gl.h>						
#include <gl/glu.h>

GLfloat MyVertices[8][3] = { { -5,0,5 },{ -5,30,5 },{ 5,30,5 },{ 5,0,5 },
{ -5,0,-5 },{ -5,30,-5 },{ 5,30,-5 },{ 5,0,-5 } };

GLfloat MyColors[8][3] = { { 0.8,0.8,0.8 },{ 0.0,0.3,0.5 },{ 0.0,0.3,0.5 },{ 0.0,0.3,0.5 },
{ 0.0,0.3,0.5 },{ 0.0,0.3,0.5 },{ 0.0,0.3,0.5 },{ 0.8,0.8,0.8 } };

GLubyte MyVertexList[24] = { 0,3,2,1, 2,3,7,6, 0,4,7,3, 1,2,6,5, 4,5,6,7, 0,1,5,4 };

float lx = 0.0f, lz = -1.0f; //삼각함수 적용 변수
float x = 0.0f, z = 0.0f;	//카메라 위치
float angle = 0.0f;			//회전 각도


void InitLight() {
	GLfloat global_ambient[] = { 0.1, 0.1, 0.1, 1.0 };	//전역 주변반사

	//0번 광원 특성
	GLfloat light0_ambient[] = { 0.4, 0.4, 0.4, 1.0 }; 	//주변광
	GLfloat light0_diffuse[] = { 0.7, 0.7, 0.7, 1.0 };	//발산광
	GLfloat light0_specular[] = { 1.0, 1.0, 1.0, 1.0 }; //반사광

	
	glShadeModel(GL_SMOOTH);	//구로 셰이딩
	
	glEnable(GL_LIGHTING);		//조명 활성

	glEnable(GL_LIGHT0);		//0번 광원 활성

	glLightfv(GL_LIGHT0, GL_AMBIENT, light0_ambient);	//0번 광원 특성할당
	glLightfv(GL_LIGHT0, GL_DIFFUSE, light0_diffuse);
	glLightfv(GL_LIGHT0, GL_SPECULAR, light0_specular);
	
	glEnable(GL_COLOR_MATERIAL); //물체 색을 보여준다.

	
}
//단일 충돌 체크
void CheckCollision(float cx, float cz) {
	if (x - cx < 6 && x - cx > -6 && z - cz < 6 && z - cz > -6) {
		x -= lx * 1.0f;
		z -= lz * 1.0f;
	}
}
//줄단위 충돌 체크(시작 부터 Z방향으로)
void CollisionLine(float cx, float cz) {
	float gap = 0;

	CheckCollision(cx, cz);
	for (int i = 0; i < 10; i++) {
		if (i == 5)
			gap -= 10;
		CheckCollision(cx, cz + gap);
		gap -= 20;
	}
}
//단일 건물 그리기
void DrawObject() {
	glEnableClientState(GL_COLOR_ARRAY);			//이것들을써야 정점배열을 사용할수 있다.(준비)
	glEnableClientState(GL_VERTEX_ARRAY);

	glColorPointer(3, GL_FLOAT, 0, MyColors);		//컬러는 MyColors라는 배열에 들어있다.
	glVertexPointer(3, GL_FLOAT, 0, MyVertices);	//점은 MyVertices라는 배열에 들어있다.

	for (GLint i = 0; i < 6; i++) {
		glDrawElements(GL_POLYGON, 4, GL_UNSIGNED_BYTE, &MyVertexList[4 * i]);
		//폴리곤으로, 4개의 점을, 한바이트로된, MyVertexList[0의 주소값부터 4개의 점을]에 있는
	}
}
//줄단위 건물 그리기(Z방향)
void DrawObjLine(float dx, float dz) {
	
	glPushMatrix();//원점 0,0,0

	glTranslatef(dx, 0, dz);
	
	for (int i = 0; i < 10; i++) {
		if (i == 5){
			glTranslatef(0, 0, -10);
		}
		DrawObject();	
		glTranslatef(0, 0, -20);
		
	}
	glPopMatrix();//원점 0,0,0 복귀
}

void DrawCrossWalk() {
	glPushMatrix();
	glTranslatef(0.0, 0.0, 4.5);
	for(int i=0;i<10;i++){
	glBegin(GL_QUADS);
		glColor3ub(255, 255, 255);
		glVertex3f(5.0, 0.11, 0.2);
		glVertex3f(5.0, 0.11, -0.2);
		glVertex3f(10.0, 0.11, -0.2);
		glVertex3f(10.0, 0.11, 0.2);
	glEnd();
	glTranslatef(0.0, 0.0, -1.0);
	}
	glPopMatrix();

	glPushMatrix();
	glTranslatef(0.0, 0.0, 4.5);
	for (int i = 0; i<10; i++) {
		glBegin(GL_QUADS);
			glColor3ub(255, 255, 255);
			glVertex3f(-5.0, 0.11, 0.2);
			glVertex3f(-5.0, 0.11, -0.2);
			glVertex3f(-10.0, 0.11, -0.2);
			glVertex3f(-10.0, 0.11, 0.2);
		glEnd();
		glTranslatef(0.0, 0.0, -1.0);
	}
	glPopMatrix(); 
	
	glPushMatrix();
	glTranslatef(4.5, 0.0, 0.0);
	for (int i = 0; i<10; i++) {
		glBegin(GL_QUADS);
		glColor3ub(255, 255, 255);
		glVertex3f(0.2, 0.11, 5.0);
		glVertex3f(-0.2, 0.11, 5.0);
		glVertex3f(-0.2, 0.11, 10.0);
		glVertex3f(0.2, 0.11, 10.0);
		glEnd();
		glTranslatef(-1.0, 0.0, 0.0);
	}
	glPopMatrix();

	glPushMatrix();
	glTranslatef(4.5, 0.0, -15.0);
	for (int i = 0; i<10; i++) {
		glBegin(GL_QUADS);
		glColor3ub(255, 255, 255);
		glVertex3f(0.2, 0.11, 5.0);
		glVertex3f(-0.2, 0.11, 5.0);
		glVertex3f(-0.2, 0.11, 10.0);
		glVertex3f(0.2, 0.11, 10.0);
		glEnd();
		glTranslatef(-1.0, 0.0, 0.0);
	}
	glPopMatrix();

}

void BaseObject() {
	//밑판 200x200
	glBegin(GL_QUADS);
		glColor3ub(69, 91, 59);
		glVertex3f(100.0, 0.0, 100.0);
		glVertex3f(100.0, 0.0, -100.0);
		glVertex3f(-100.0, 0.0, -100.0);
		glVertex3f(-100.0, 0.0, 100.0);
	glEnd();

	//중앙 세로 도로
	glBegin(GL_QUADS);
		glColor3ub(100, 100, 100);
		glVertex3f(5.0, 0.1, 100.0);
		glVertex3f(5.0, 0.1, -100.0);
		glVertex3f(-5.0, 0.1, -100.0);
		glVertex3f(-5.0, 0.1, 100.0);
	glEnd();

	//세로 중앙선
	glBegin(GL_QUADS);
		glColor3ub(230, 218, 0);
		glVertex3f(0.2, 0.11, 100.0);
		glVertex3f(0.2, 0.11, 10.0);
		glVertex3f(-0.2, 0.11, 10.0);
		glVertex3f(-0.2, 0.11, 100.0);
	glEnd();

	//세로 중앙선
	glBegin(GL_QUADS);
		glColor3ub(230, 218, 0);
		glVertex3f(0.2, 0.11, -100.0);
		glVertex3f(0.2, 0.11, -10.0);
		glVertex3f(-0.2, 0.11, -10.0);
		glVertex3f(-0.2, 0.11, -100.0);
	glEnd();

	//중앙 가로 도로
	glBegin(GL_QUADS);
		glColor3ub(100, 100, 100);
		glVertex3f(100.0, 0.09, 5.0);
		glVertex3f(100.0, 0.09, -5.0);
		glVertex3f(-100.0, 0.09, -5.0);
		glVertex3f(-100.0, 0.09, 5.0);
	glEnd();

	//중앙 가로 중앙선
	glBegin(GL_QUADS);
		glColor3ub(230, 218, 100);
		glVertex3f(100.0, 0.11, 0.2);
		glVertex3f(100.0, 0.11, -0.2);
		glVertex3f(10.0, 0.11, -0.2);
		glVertex3f(10.0, 0.11, 0.2);
	glEnd();

	//중앙 가로 중앙선
	glBegin(GL_QUADS);
		glColor3ub(230, 218, 100);
		glVertex3f(-100.0, 0.11, 0.2);
		glVertex3f(-100.0, 0.11, -0.2);
		glVertex3f(-10.0, 0.11, -0.2);
		glVertex3f(-10.0, 0.11, 0.2);
	glEnd();

	//횡단보도
	DrawCrossWalk();
}

//디스플레이 콜백함수
void MyDisplay() {
	GLfloat LightPosition0[] = { 10.0, 10.0, 10.0, 0.0 };	//0번 광원위치

	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	glEnable(GL_DEPTH_TEST);//가려진면 제거
	
	glLightfv(GL_LIGHT0, GL_POSITION, LightPosition0);	//위치성 광원

	glLoadIdentity();


	//glTranslatef(0,0,-100);
	//glRotatef(90, 1.0, 0.0, 0.0);
	
	
	gluLookAt(x, 5.0f, z,			//카메라 위치, 보는 곳, 백터
		x + lx, 5.0f, z + lz,
		0.0f, 1.0f, 0.0f);
	

	BaseObject();	//도로 및 차선을 그린다.

	int objLineX = 15;
	//오른쪽 건물 단지    
	for (int i = 0; i < 5; i++) {
		DrawObjLine(objLineX, 95); //15, 0, 95 시작(0, 0, -20)씩
		objLineX += 20;
	}
	
	objLineX = -15;
	//왼쪽 건물 단지 
	for (int i = 0; i < 5; i++) {
		DrawObjLine(objLineX, 95); //-15,0,95 시작 (0,0,-20)씩
		objLineX -= 20;
	}
	
	int collLineX = 15;
	//오른쪽 건물 단지 충돌 검사
	for(int i = 0; i<5;i++){
		CollisionLine(collLineX, 95);
		collLineX += 20;
	}

	collLineX = -15;
	//왼쪽 건물 단지 충돌 검사
	for (int i = 0; i<5; i++) {
		CollisionLine(collLineX, 95);
		collLineX -= 20;
	}

	glutSwapBuffers();
}

void Reshape(int w, int h) {
	if (h == 0)
		h = 1;
	
	GLfloat aspect = (GLfloat)w / (GLfloat)h;

	glMatrixMode(GL_PROJECTION);	//메트릭스를 계산해서 화면에 어떻게 뿌릴지 계산
	glLoadIdentity();

	glViewport(0, 0, w, h);

	gluPerspective(45.0f, aspect, 0.1f, 300.0f);	//원근투상

	glMatrixMode(GL_MODELVIEW); // 매트릭스를 곱해서 실제적인 위치 지정.
}

void processNormalKeys(unsigned char key, int x, int y)
{
	//ESC아스키코드
	if (key == 27)
		exit(0);
}

void processSpecialKeys(int key, int xx, int yy)
{

	float fraction = 1.0f;
	//삼각함수로 방향 조정
	switch (key) {
	case GLUT_KEY_LEFT:
		angle -= 0.1f;
		lx = sin(angle);
		lz = -cos(angle);
		break;
	case GLUT_KEY_RIGHT:
		angle += 0.1f;
		lx = sin(angle);
		lz = -cos(angle);
		break;
	case GLUT_KEY_UP:
		x += lx * fraction;
		z += lz * fraction;
		break;
	case GLUT_KEY_DOWN:
		x -= lx * fraction;
		z -= lz * fraction;
		break;
	}
	printf("%0.2f, %0.2f\n", x, z);
	glutPostRedisplay();
}

int main(int argc, char **argv) {
	//gl초기화
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGBA | GLUT_DEPTH);
	glutInitWindowSize(800, 600);
	glutCreateWindow("3D Navigation");

	InitLight();

	//콜백함수 등록
	glutDisplayFunc(MyDisplay);
	glutReshapeFunc(Reshape);
	glutKeyboardFunc(processNormalKeys);
	glutSpecialFunc(processSpecialKeys);

	//메시지 루프
	glutMainLoop();

	return 1;
}