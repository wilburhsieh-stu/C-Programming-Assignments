#include <stdio.h>

int main(void)
{
    int num;
    int sum=0;
    int counter=0;

    scanf("%d",&num);
    while(num>0)
    {
        sum+=num%10;
        counter++;
        num/=10;
    }
    printf("%d %d\n",counter,sum);
}


