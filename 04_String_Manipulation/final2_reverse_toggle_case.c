#include<stdio.h>
#include<string.h>
#include<ctype.h>

int main(void)
{
    char str[1000];
    scanf("%s",str);
    int len=strlen(str);

    for(int i=len-1;i>=0;i--){
        if(isupper(str[i])){
            printf("%c",tolower(str[i]));
        }
        else if(islower(str[i])){
            printf("%c",toupper(str[i]));
        }
        else{
            printf("%c",str[i]);
        }
    }
    return 0;
}
