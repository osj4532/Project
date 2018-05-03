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

float lx = 0.0f, lz = -1.0f; //�ﰢ�Լ� ���� ����
float x = 0.0f, z = 0.0f;	//ī�޶� ��ġ
float angle = 0.0f;			//ȸ�� ����


void InitLight() {
	GLfloat global_ambient[] = { 0.1, 0.1, 0.1, 1.0 };	//���� �ֺ��ݻ�

	//0�� ���� Ư��
	GLfloat light0_ambient[] = { 0.4, 0.4, 0.4, 1.0 }; 	//�ֺ���
	GLfloat light0_diffuse[] = { 0.7, 0.7, 0.7, 1.0 };	//�߻걤
	GLfloat light0_specular[] = { 1.0, 1.0, 1.0, 1.0 }; //�ݻ籤

	
	glShadeModel(GL_SMOOTH);	//���� ���̵�
	
	glEnable(GL_LIGHTING);		//���� Ȱ��

	glEnable(GL_LIGHT0);		//0�� ���� Ȱ��

	glLightfv(GL_LIGHT0, GL_AMBIENT, light0_ambient);	//0�� ���� Ư���Ҵ�
	glLightfv(GL_LIGHT0, GL_DIFFUSE, light0_diffuse);
	glLightfv(GL_LIGHT0, GL_SPECULAR, light0_specular);
	
	glEnable(GL_COLOR_MATERIAL); //��ü ���� �����ش�.

	
}
//���� �浹 üũ
void CheckCollision(float cx, float cz) {
	if (x - cx < 6 && x - cx > -6 && z - cz < 6 && z - cz > -6) {
		x -= lx * 1.0f;
		z -= lz * 1.0f;
	}
}
//�ٴ��� �浹 üũ(���� ���� Z��������)
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
//���� �ǹ� �׸���
void DrawObject() {
	glEnableClientState(GL_COLOR_ARRAY);			//�̰͵������ �����迭�� ����Ҽ� �ִ�.(�غ�)
	glEnableClientState(GL_VERTEX_ARRAY);

	glColorPointer(3, GL_FLOAT, 0, MyColors);		//�÷��� MyColors��� �迭�� ����ִ�.
	glVertexPointer(3, GL_FLOAT, 0, MyVertices);	//���� MyVertices��� �迭�� ����ִ�.

	for (GLint i = 0; i < 6; i++) {
		glDrawElements(GL_POLYGON, 4, GL_UNSIGNED_BYTE, &MyVertexList[4 * i]);
		//����������, 4���� ����, �ѹ���Ʈ�ε�, MyVertexList[0�� �ּҰ����� 4���� ����]�� �ִ�
	}
}
//�ٴ��� �ǹ� �׸���(Z����)
void DrawObjLine(float dx, float dz) {
	
	glPushMatrix();//���� 0,0,0

	glTranslatef(dx, 0, dz);
	
	for (int i = 0; i < 10; i++) {
		if (i == 5){
			glTranslatef(0, 0, -10);
		}
		DrawObject();	
		glTranslatef(0, 0, -20);
		
	}
	glPopMatrix();//���� 0,0,0 ����
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
	//���� 200x200
	glBegin(GL_QUADS);
		glColor3ub(69, 91, 59);
		glVertex3f(100.0, 0.0, 100.0);
		glVertex3f(100.0, 0.0, -100.0);
		glVertex3f(-100.0, 0.0, -100.0);
		glVertex3f(-100.0, 0.0, 100.0);
	glEnd();

	//�߾� ���� ����
	glBegin(GL_QUADS);
		glColor3ub(100, 100, 100);
		glVertex3f(5.0, 0.1, 100.0);
		glVertex3f(5.0, 0.1, -100.0);
		glVertex3f(-5.0, 0.1, -100.0);
		glVertex3f(-5.0, 0.1, 100.0);
	glEnd();

	//���� �߾Ӽ�
	glBegin(GL_QUADS);
		glColor3ub(230, 218, 0);
		glVertex3f(0.2, 0.11, 100.0);
		glVertex3f(0.2, 0.11, 10.0);
		glVertex3f(-0.2, 0.11, 10.0);
		glVertex3f(-0.2, 0.11, 100.0);
	glEnd();

	//���� �߾Ӽ�
	glBegin(GL_QUADS);
		glColor3ub(230, 218, 0);
		glVertex3f(0.2, 0.11, -100.0);
		glVertex3f(0.2, 0.11, -10.0);
		glVertex3f(-0.2, 0.11, -10.0);
		glVertex3f(-0.2, 0.11, -100.0);
	glEnd();

	//�߾� ���� ����
	glBegin(GL_QUADS);
		glColor3ub(100, 100, 100);
		glVertex3f(100.0, 0.09, 5.0);
		glVertex3f(100.0, 0.09, -5.0);
		glVertex3f(-100.0, 0.09, -5.0);
		glVertex3f(-100.0, 0.09, 5.0);
	glEnd();

	//�߾� ���� �߾Ӽ�
	glBegin(GL_QUADS);
		glColor3ub(230, 218, 100);
		glVertex3f(100.0, 0.11, 0.2);
		glVertex3f(100.0, 0.11, -0.2);
		glVertex3f(10.0, 0.11, -0.2);
		glVertex3f(10.0, 0.11, 0.2);
	glEnd();

	//�߾� ���� �߾Ӽ�
	glBegin(GL_QUADS);
		glColor3ub(230, 218, 100);
		glVertex3f(-100.0, 0.11, 0.2);
		glVertex3f(-100.0, 0.11, -0.2);
		glVertex3f(-10.0, 0.11, -0.2);
		glVertex3f(-10.0, 0.11, 0.2);
	glEnd();

	//Ⱦ�ܺ���
	DrawCrossWalk();
}

//���÷��� �ݹ��Լ�
void MyDisplay() {
	GLfloat LightPosition0[] = { 10.0, 10.0, 10.0, 0.0 };	//0�� ������ġ

	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	glEnable(GL_DEPTH_TEST);//�������� ����
	
	glLightfv(GL_LIGHT0, GL_POSITION, LightPosition0);	//��ġ�� ����

	glLoadIdentity();


	//glTranslatef(0,0,-100);
	//glRotatef(90, 1.0, 0.0, 0.0);
	
	
	gluLookAt(x, 5.0f, z,			//ī�޶� ��ġ, ���� ��, ����
		x + lx, 5.0f, z + lz,
		0.0f, 1.0f, 0.0f);
	

	BaseObject();	//���� �� ������ �׸���.

	int objLineX = 15;
	//������ �ǹ� ����    
	for (int i = 0; i < 5; i++) {
		DrawObjLine(objLineX, 95); //15, 0, 95 ����(0, 0, -20)��
		objLineX += 20;
	}
	
	objLineX = -15;
	//���� �ǹ� ���� 
	for (int i = 0; i < 5; i++) {
		DrawObjLine(objLineX, 95); //-15,0,95 ���� (0,0,-20)��
		objLineX -= 20;
	}
	
	int collLineX = 15;
	//������ �ǹ� ���� �浹 �˻�
	for(int i = 0; i<5;i++){
		CollisionLine(collLineX, 95);
		collLineX += 20;
	}

	collLineX = -15;
	//���� �ǹ� ���� �浹 �˻�
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

	glMatrixMode(GL_PROJECTION);	//��Ʈ������ ����ؼ� ȭ�鿡 ��� �Ѹ��� ���
	glLoadIdentity();

	glViewport(0, 0, w, h);

	gluPerspective(45.0f, aspect, 0.1f, 300.0f);	//��������

	glMatrixMode(GL_MODELVIEW); // ��Ʈ������ ���ؼ� �������� ��ġ ����.
}

void processNormalKeys(unsigned char key, int x, int y)
{
	//ESC�ƽ�Ű�ڵ�
	if (key == 27)
		exit(0);
}

void processSpecialKeys(int key, int xx, int yy)
{

	float fraction = 1.0f;
	//�ﰢ�Լ��� ���� ����
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
	//gl�ʱ�ȭ
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGBA | GLUT_DEPTH);
	glutInitWindowSize(800, 600);
	glutCreateWindow("3D Navigation");

	InitLight();

	//�ݹ��Լ� ���
	glutDisplayFunc(MyDisplay);
	glutReshapeFunc(Reshape);
	glutKeyboardFunc(processNormalKeys);
	glutSpecialFunc(processSpecialKeys);

	//�޽��� ����
	glutMainLoop();

	return 1;
}