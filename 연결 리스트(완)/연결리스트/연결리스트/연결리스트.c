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
	printf("   �̸�   �й� ���� ���� ����\n");
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
	printf("ã�� �����Ͱ� �����ϴ�\n");
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
		error("�޸� �Ҵ翡��");
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
		printf("1.�л� ������ �Է� 2.������ ���� 3.�˻� 4.��Ϻ��� 5.������ ���� 6.����Ʈ ��ġ�� 0.����\n");
		scanf("%d",&choice);
		if(choice<0||choice>6)
			printf("�߸��Է� �ϼ̽��ϴ� 0���� 6������ ���� �ٽ� �Է��ϼ���\n");
		else
			break;
	}
	return choice;

}
void input(char *name,int *stdnum,int *kor,int *eng,int* math){
	printf("�̸�: ");
	scanf("%s",name);
	printf("�й�: ");
	scanf("%d",stdnum);
	printf("���� ����: ");
	scanf("%d",kor);
	printf("���� ����: ");
	scanf("%d",eng);
	printf("���� ����: ");
	scanf("%d",math);

}

int main(void){
	char name[10];
	int kor,eng,math,stdnum;
	int choice=0;

	ListNode *list1 = NULL, *list2=NULL;
	ListNode *p,*prep=NULL;

	insert_node(&list2, NULL, create_node("������", 2013, 99, 99, 99, NULL));
	insert_node(&list2, NULL, create_node("������", 2013, 99, 92, 97, NULL));


	while(1){
		printf("���� ���� ���α׷�\n");
		choice = menu();
		if(choice == 1){
			input(name,&stdnum,&kor,&eng,&math);
			insert_node(&list1,NULL,create_node(name,stdnum,kor,eng,math,NULL));	
		}
		else if(choice==2){
			printf("������ �л��� �̸��� �й��� �Է��ϼ���");
			scanf("%s",name);
			scanf("%d",&stdnum);
			p=search(list1,name,stdnum,&prep);
			remove_node(&list1,prep,p);
		}
		else if(choice==3){
			printf("�˻��� �л��� �̸��� �й��� �Է��ϼ���");
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
