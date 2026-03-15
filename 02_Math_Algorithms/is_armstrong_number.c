#include<stdio.h>

int main(void)
{
    for(int number=100;number<=999;number++)
    {
        int a=number/100;
        int b=(number/10)%10;
        int c=number%10;

        int t=a*a*a+b*b*b+c*c*c;
        if(t==number)
        {
            printf("%d\n",number);
        }
    }
}

