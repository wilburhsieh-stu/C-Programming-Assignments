#include <stdio.h>

int main(void)
{
    int  secend;
    int h,m,s;

    scanf("%d",&secend);

    h=secend/3600;
    m=(secend%3600)/60;
    s=secend%60;

    printf("%02d:%02d:%02d\n",h,m,s);
}
