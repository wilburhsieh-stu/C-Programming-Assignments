#include<stdio.h>

int gcd(int x,int y);

int main(void)
{
    int x,y;
    int result;
    scanf("%d %d",&x,&y);
    result=gcd(x,y);
    printf("%d\n",result);
    return 0;
}

int gcd(int x,int y)
{
    int num=(x<y)?x:y;
    if(y==0){
        return x;
    }
    else {
        return gcd(y,x%y);
    }
}
