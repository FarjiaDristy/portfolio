#include <stdio.h>

int main() {
    char s[10];
    scanf("%s", s);

    int num;
    if (sscanf(s, "%d", &num) == 1)
        printf("%d\n", num);
    else
        printf("Bad String\n");

    return 0;
}
