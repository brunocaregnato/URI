#include<stdio.h>
int main()
{
	int a,ano,mes,dias;
	scanf("%d",&a);
	ano=a/365;
	mes=a%365/30;
	dias=a%365%30;
	printf("%d ano(s)\n%d mes(es)\n%d dia(s)\n",ano,mes,dias);
	return 0;
}