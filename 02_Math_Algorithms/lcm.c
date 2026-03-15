#include<stdio.h>

int lcm(int x,int y);

int main(void)
{
    int x,y;
    int result;
    scanf("%d %d",&x,&y);
    result=lcm(x,y);
    printf("%d\n",result);
    return 0;
}

int lcm(int x,int y)
{
    int num=(x>y) ? x : y;
    while(1) {
        if(num%x==0 && num%y==0) {
            return num;
        }
        num++;
    }
}
