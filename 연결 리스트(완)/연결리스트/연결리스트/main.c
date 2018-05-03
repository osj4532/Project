#include<stdio.h>
#include"connted_list_cal.h"

int main(void)
{
	char name[10];
	int stdnum;
	int choice=0;

	element element1;
	ListNode *list1 = NULL, *list2=NULL;
	ListNode *p,*prep=NULL;

	strcpy(element1.name,"조윤기");
	element1.stdnum=2013;
	element1.kor=99;
	element1.eng=99;
	element1.math=99;
	insert_node(&list2, NULL, create_node(element1, NULL));
	strcpy(element1.name,"오승주");
	element1.stdnum=2013;
	element1.kor=99;
	element1.eng=92;
	element1.math=97;
	insert_node(&list2, NULL, create_node(element1, NULL));


	while(1)
	{
		printf("성적 관리 프로그램\n");
		choice = menu();
		
		if(choice == 1)
		{
			input(&element1);
			insert_node(&list1,NULL,create_node(element1,NULL));	
		}
		
		else if(choice==2)
		{
			printf("삭제할 학생의 이름과 학번을 입력하세요");
			scanf("%s",name);
			scanf("%d",&stdnum);
			p=search(list1,name,stdnum,&prep);
			remove_node(&list1,prep,p);
		}
		
		else if(choice==3)
		{
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
