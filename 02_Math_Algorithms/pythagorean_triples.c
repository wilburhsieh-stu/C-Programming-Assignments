#include <stdio.h>

int main (void)
{
    int i,j,s;
    for(int i=1;i>0 && i<=500;i++)
        for(int j=1;j>0 && j<=500;j++)
            for(int s=1;s>0 && s<=500;s++)
                if(i*i==j*j+s*s)
                    printf("(%d,%d,%d)\n",i,j,s);
}
