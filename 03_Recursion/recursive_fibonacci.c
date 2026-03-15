#include<stdio.h>

unsigned long long int fibonacci(unsigned int n);

int main(void)
{
    unsigned int num;
    scanf("%d",&num);

    unsigned long long int result=fibonacci(num);

    printf("%llu\n",result);
}

unsigned long long int fibonacci(unsigned int n)
{
    if(0==n || 1==n){
        return n;
    }
    else {
        return fibonacci(n-1)+fibonacci(n-2);
    }
}
