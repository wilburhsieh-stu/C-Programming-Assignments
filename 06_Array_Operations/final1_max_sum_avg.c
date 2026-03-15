#include<stdio.h>

int main(void)
{
    int n;
    scanf("%d",&n);

    int arr[n];
    int max;
    int sum=0;

    for(int i=0;i<n;i++){
        scanf("%d",&arr[i]);
        sum+=arr[i];

        if(i==0){
            max=arr[i];
        }
        if(arr[i]>max){
            max=arr[i];
        }
    }
    double avg=(double)sum/n;

    printf("%d %d %.2f",max,sum,avg);

    return 0;
}
