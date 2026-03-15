#include<stdio.h>

int main(void)
{
    int i,j,s;
    int n=9;

    for(i=n;i>=1;--i)
    {
        for(s=1; s<=n-i;++s)
            printf(" ");
            {
                for(j=1;j<=i;++j)
                    printf("%d",j);
                for(j=i-1;j>=1;--j)
                    printf("%d",j);
            }
            printf("\n");
    }
}
