#include <stdio.h>
#include "ex1.h"

void read_data(struct student data[],char subject[4][6], FILE *fpr,int *i)
{
	fscanf(fpr,"%s %s %s %s",subject[0],subject[1], subject[2],subject[3]);
	while(fscanf(fpr,"%s %d %d %d",data[*i].name, &data[*i].score1,&data[*i].score2,&data[*i].score3)!=EOF)
	{
		data[*i].hap= data[*i].score1+ data[*i].score2+ data[*i].score3;
		data[*i].ave= data[*i].hap/3;	
		*i = (*i)+1;
	}
}

void print_data(struct student *data,char subject[4][6],int *i)
{
	int num=0,t_num=0;
	double t_ave=0,s1_ave=0,s2_ave=0,s3_ave=0;	

	printf("\t\t¼ºÀûÇ¥\n\n");

	for(num=0;num< *i;num++)
	{
		if(num==0)
		{
			printf("%s\t%s\t%s\t%s\tÇÕ\tÆò±Õ\n",subject[0],subject[1],subject[2],subject[3]);
			printf("**************************************************\n");
		}
		printf("%s \t",data[num].name);
		printf("%d \t",data[num].score1);
		printf("%d \t",data[num].score2);
		printf("%d \t",data[num].score3);
		printf("%d \t",data[num].hap);
		printf("%.2f \n",data[num].ave);
		t_ave+=data[num].ave;
		s1_ave+= data[num].score1;
		s2_ave+= data[num].score2;
		s3_ave+= data[num].score3;
		t_num+=data[num].hap;
	}
	
	s1_ave/= *i;
	s2_ave/= *i;
	s3_ave/= *i;
	printf("**************************************************\n");
	t_ave/= *i;
	printf("ÀüÃ¼Æò±Õ: %.1f\t%.1f\t%.1f\t%d\t%.2f\n",s1_ave,s2_ave,s3_ave,t_num/ *i,t_ave);
}

void Make_file(struct student *data,char subject[4][6], int *i)
{
	int num=0,t_num=0;
	double t_ave=0,s1_ave=0,s2_ave=0,s3_ave=0;
	FILE *fp;
	fp=fopen("result.txt","w");
	fprintf(fp,"\t\t¼ºÀûÇ¥\n");

	for(num=0;num<*i;num++)
	{
		if(num==0)
		{
			fprintf(fp,"%s\t%s\t%s\t%s\tÇÕ\tÆò±Õ\n",subject[0],subject[1],subject[2],subject[3]);
			fprintf(fp,"**************************************************\n");
		}
		
		fprintf(fp,"%s \t",data[num].name);
		fprintf(fp,"%d \t",data[num].score1);
		fprintf(fp,"%d \t",data[num].score2);
		fprintf(fp,"%d \t",data[num].score3);
		fprintf(fp,"%d \t",data[num].hap);
		fprintf(fp,"%.2f \n",data[num].ave);
		t_ave+=data[num].ave;
		t_num+=data[num].hap;
	}
	
	s1_ave/= *i;
	s2_ave/= *i;
	s3_ave/= *i;
	fprintf(fp,"**************************************************\n");
	t_ave/= *i;
	fprintf(fp,"ÀüÃ¼Æò±Õ: %.1f\t%.1f\t%.1f\t%d\t%.2f\n",s1_ave,s2_ave,s3_ave,t_num/ *i,t_ave);
}
