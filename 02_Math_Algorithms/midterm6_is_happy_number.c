#include <stdio.h>

int main(void) {
    int n;
    scanf("%d", &n);

    int org=n;
    int seen[100];
    int count = 0;

    for (int i = 0; i < 100; i++)
    {
        if (n == 1)
        {
            printf("%d is a happy number\n",org);
            return 0;
        }
        int repeated = 0;
        for (int j = 0; j < count; j++)
        {
            if (seen[j] == n)
            {
                repeated = 1;
                break;
            }
        }
        if (repeated)
        {
            printf("%d is not a happy number\n",org);
            return 0;
        }

        seen[count++] = n;

        int next = 0, temp = n;
        while (temp > 0) {
            int d = temp % 10;
            next += d * d;
            temp /= 10;
        }
        n = next;
    }
    printf("%d is not a happy number\n",org);
    return 0;
}
