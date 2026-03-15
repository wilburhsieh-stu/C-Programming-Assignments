#include<stdio.h>

int isPerfect(int num);

int main(void)
{
    for(int i=0;i<=1000;i++) {
        if(isPerfect(i)){
            printf("%d ",i);
        }
    }
    printf("\n");
    return 0;
}


int isPerfect(int num){
    int sum=0;
        for(int x=1;x<num;++x)
        if(num%x==0){
            sum=sum+x;
        }
        if(sum==num && num !=0){
            return 1;
        }
        else {
            return 0;
        }
}
