#include<stdio.h>
#include "ex1_cal.h"


int main()
{
	int i=0,num=0,*cnt=&i;
	struct student data[size];

	char subject[4][6];
	FILE *fpr;
	fpr = fopen("¼ºÀûÇ¥.txt","r");
	
	if (fpr == NULL)
	{
		printf("error fopen");
		return;
	}
	
	else
		read_data(data,subject,fpr,cnt);

	print_data(data,subject,cnt);
	Make_file(data,subject,cnt);
	getchar();

	return 0;
}