#include<stdio.h>
#include<stdlib.h>
#include<string.h>

#define MaxStringSize 100

typedef struct element{
	int stdnum,kor,eng,math;
	char name[MaxStringSize];
}element;

typedef struct ListNode{
	element data;
	struct ListNode *link;
}ListNode;

void error(char *message){
	fprintf(stderr,"%s\n",message);
	exit(1);
}
void insert_node(ListNode **phead, ListNode *p, ListNode *new_node){
	if(*phead==NULL)
	{
		new_node->link=NULL;
		*phead = new_node;
	}
	else if(p==NULL)
	{
		new_node->link =*phead;
		*phead = new_node;
	}
	else
	{
		new_node->link=p->link;
		p->link = new_node;
	}

}

void remove_node(ListNode **phead, ListNode *p,ListNode *removed){

	if(p==NULL)
		*phead=(*phead)->link;
	else
		p->link =removed->link;
	if(removed->link==NULL)
		p->link = NULL;
	free(removed);

}

void display(ListNode *head){
	ListNode *p = head;
	int cnt=1;
	printf("   이름   학번 국어 영어 수학\n");
	while(p != NULL){
		printf("%d) %s %d  %d  %d  %d \n",cnt ,p->data.name,p->data.stdnum,p->data.kor,p->data.eng,p->data.math);
		p=p->link;
		cnt++;
	}
	printf("\n");

}

ListNode *concat(ListNode *head1, ListNode *head2)
{
	ListNode *p;
	if( head1 == NULL) return head2;
	else if( head2 == NULL) return head1;
	else
	{
		p = head1;
		while( p->link != NULL)
			p = p->link;
		p->link = head2;
		return head1;
	}
}

ListNode *search(ListNode *head,char *name, int stdnum,ListNode **prep){
	ListNode *p;
	p=head;
	while(p!=NULL){

		if((strcmp(p->data.name,name)==0)&&(p->data.stdnum==stdnum)){

			return p;
		}
		(*prep) = p;
		p=p->link;
	}
	printf("찾는 데이터가 없습니다\n");
	return p;
}

ListNode *reverse(ListNode *head)
{
	ListNode *p, *q, *r;
	p = head;
	q = NULL;
	while(p != NULL)
	{
		r = q;
		q = p;
		p = p->link;
		q->link = r;
	}
	return q;
}
ListNode *create_node(char *name,int stdnum,int kor,int eng,int math, ListNode *link){
	ListNode *new_node;
	new_node = (ListNode*)malloc(sizeof(ListNode));
	if(new_node == NULL)
		error("메모리 할당에러");
	strcpy(new_node->data.name,name);
	new_node->data.stdnum=stdnum;
	new_node->data.kor= kor;
	new_node->data.eng=eng;
	new_node->data.math=math;
	new_node->link=link;
	return new_node;
}

int menu(){
	int choice;
	while(1){
		printf("1.학생 데이터 입력 2.데이터 삭제 3.검색 4.목록보기 5.데이터 역순 6.리스트 합치기 0.종료\n");
		scanf("%d",&choice);
		if(choice<0||choice>6)
			printf("잘못입력 하셨습니다 0부터 6까지의 수를 다시 입력하세요\n");
		else
			break;
	}
	return choice;

}
void input(char *name,int *stdnum,int *kor,int *eng,int* math){
	printf("이름: ");
	scanf("%s",name);
	printf("학번: ");
	scanf("%d",stdnum);
	printf("국어 성적: ");
	scanf("%d",kor);
	printf("영어 성적: ");
	scanf("%d",eng);
	printf("수학 성적: ");
	scanf("%d",math);

}

int main(void){
	char name[10];
	int kor,eng,math,stdnum;
	int choice=0;

	ListNode *list1 = NULL, *list2=NULL;
	ListNode *p,*prep=NULL;

	insert_node(&list2, NULL, create_node("조윤기", 2013, 99, 99, 99, NULL));
	insert_node(&list2, NULL, create_node("오승주", 2013, 99, 92, 97, NULL));


	while(1){
		printf("성적 관리 프로그램\n");
		choice = menu();
		if(choice == 1){
			input(name,&stdnum,&kor,&eng,&math);
			insert_node(&list1,NULL,create_node(name,stdnum,kor,eng,math,NULL));	
		}
		else if(choice==2){
			printf("삭제할 학생의 이름과 학번을 입력하세요");
			scanf("%s",name);
			scanf("%d",&stdnum);
			p=search(list1,name,stdnum,&prep);
			remove_node(&list1,prep,p);
		}
		else if(choice==3){
			printf("검색할 학생의 이름과 학번을 입력하세요");
			scanf("%s",name);
			scanf("%d",&stdnum);
			p=search(list1,name,stdnum,&prep);
			printf("%s %d %d %d %d\n",p->data.name,p->data.stdnum,p->data.kor,p->data.eng,p->data.math);
		}
		else if(choice==4)
			display(list1);
		else if(choice==5)
		{
			list1=  reverse(list1);
			display(list1);
		}
		else if(choice==6)
		{
			concat(list1, list2);
			display(list1);
		}
		else
			break;


	}

}
