#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() {
    int i = 4;
    double d = 4.0;
    char s[] = "HackerRank ";
    
    int i2;
    double d2;
    char s2[100];

    scanf("%d", &i2);
    scanf("%lf", &d2); 
    getchar();  // consume leftover newline

    fgets(s2, sizeof(s2), stdin);
    s2[strcspn(s2, "\n")] = '\0';

    printf("%d\n", i + i2);
    printf("%.1f\n", d + d2);
    printf("%s%s\n", s, s2);

    return 0;
}
