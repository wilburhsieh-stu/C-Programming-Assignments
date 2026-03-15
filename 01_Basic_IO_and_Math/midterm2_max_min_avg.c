#include <stdio.h>

int main(void)
{
    int a,b,c;
    int max,mini;
    double avg;

    scanf("%d %d %d",&a,&b,&c);

    max=a;
    if(b>max)
    {
        max=b;
    }
    if(c>max)
    {
        max=c;
    }
    mini=a;
    if(b<mini)
    {
        mini=b;
    }
    if(c<mini)
    {
        mini=c;
    }
    avg=(a+b+c)/3.0;
    printf("%d %d %.2f\n",max,mini,avg);
}



