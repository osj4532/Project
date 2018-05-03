#include <stdio.h>
#include "connected.h"

void error(char *message)
{
	fprintf(stderr,"%s\n",message);
	exit(1);
}
void insert_node(ListNode **phead, ListNode *p, ListNode *new_node)
{
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

void remove_node(ListNode **phead, ListNode *p,ListNode *removed)
{

	if(p==NULL)
		*phead=(*phead)->link;
	
	else
		p->link =removed->link;
	
	if(removed->link==NULL)
		p->link = NULL;
	free(removed);

}

void display(ListNode *head)
{
	ListNode *p = head;
	int cnt=1;
	
	printf("   �̸� \t�й�\t\t����\t����\t����\n");

	
	while(p != NULL){
		printf("%d) %s\t%d\t%d\t%d\t%d\n",cnt ,p->data.name,p->data.stdnum,p->data.kor,p->data.eng,p->data.math);
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

ListNode *search(ListNode *head,char *name, int stdnum,ListNode **prep)
{
	ListNode *p;
	p=head;
	
	while(p!=NULL)
	{

		if((strcmp(p->data.name,name)==0)&&(p->data.stdnum==stdnum))
		{
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
ListNode *create_node(element element1, ListNode *link)
{
	ListNode *new_node;
	new_node = (ListNode*)malloc(sizeof(ListNode));
	
	if(new_node == NULL)
		error("�޸� �Ҵ翡��");

	strcpy(new_node->data.name,element1.name);
	new_node->data.stdnum=element1.stdnum;
	new_node->data.kor= element1.kor;
	new_node->data.eng=element1.eng;
	new_node->data.math=element1.math;
	new_node->link=link;
	
	return new_node;
}

int menu()
{
	int choice;
	
	while(1)
	{
		printf("1.�л� ������ �Է� 2.������ ���� 3.�˻� 4.��Ϻ��� 5.������ ���� 6.����Ʈ ��ġ�� 0.����\n");
		scanf("%d",&choice);
		if(choice<0||choice>6)
			printf("�߸��Է� �ϼ̽��ϴ� 0���� 6������ ���� �ٽ� �Է��ϼ���\n");
		else
			break;
	}
	
	return choice;
}
void input(element *element)
{
	printf("�̸�: ");
	scanf("%s",&element->name);
	printf("�й�: ");
	scanf("%d",&element->stdnum);
	printf("���� ����: ");
	scanf("%d",&element->kor);
	printf("���� ����: ");
	scanf("%d",&element->eng);
	printf("���� ����: ");
	scanf("%d",&element->math);
}
