#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() {
    int T;
    scanf("%d", &T);

    while (T--) {
        char s[10001];
        scanf("%s", s);

        char even[10001], odd[10001];
        int e = 0, o = 0;

        for (int i = 0; s[i] != '\0'; i++) {
            if (i % 2 == 0)
                even[e++] = s[i];
            else
                odd[o++] = s[i];
        }

        even[e] = '\0';
        odd[o] = '\0';

        printf("%s %s\n", even, odd);
    }

    return 0;
}
