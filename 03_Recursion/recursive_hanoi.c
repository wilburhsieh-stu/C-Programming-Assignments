#include<stdio.h>

void hanoi(int n,char a,char b,char c);

int main(void)
{
    int n;

    scanf("%d", &n);

    hanoi(n,'1', '2', '3');

    return 0;
}

void hanoi(int n,char begin,char aux,char last)
{
    if(n==1){
        printf("%c to %c\n",begin,last);
        return ;
    }
    hanoi(n-1,begin,last,aux);
    printf("%c to %c\n",begin,last);
    hanoi(n-1,aux,begin,last);
}
