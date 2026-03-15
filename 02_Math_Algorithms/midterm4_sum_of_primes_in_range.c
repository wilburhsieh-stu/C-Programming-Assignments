#include <stdio.h>

int main(void)
{
    int a,b;
    int sum=0;
    scanf("%d %d",&a,&b);
    {
        for(int n=a;n<=b;n++)
        {
            if(n<=1) continue;

            int Prime=1;
            for(int i=2;i<n;i++)
            {
                if(n%i==0)
                {
                    Prime=0;
                    break;
                }
            }
            if(Prime) sum+=n;
        }
    }
    printf("%d\n",sum);
}

