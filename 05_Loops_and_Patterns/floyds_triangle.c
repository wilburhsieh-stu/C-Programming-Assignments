#include<stdio.h>

int main(void)
{
    int rows=10;
    {
        int number=1;
        for(int r=1;r<=rows;r++)
        {
            for(int c=1;c<=r;c++)
            {
                printf("%d",number);
                number++;
            }
            printf("\n");
        }
    }
}


