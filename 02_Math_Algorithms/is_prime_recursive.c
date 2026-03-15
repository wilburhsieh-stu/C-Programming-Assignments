#include<stdio.h>

int isPrime(int num);

int main(void)
{
    int num;
    scanf("%d",&num);
    if(isPrime(num)){
        printf("%d is Prime",num);
    }
    else {
        printf("%d is not Prime",num);
    }
}

int isPrime(int num)
{
    if(num<=1){
        return 0;
    }
    for(int i=2; i<num;i++)
        if(num%i==0){
            return 0;
        }
    return 1;
}
