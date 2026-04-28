#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>
#include <stdbool.h>


void solve() {
    int n;
    scanf("%d", &n);
    
    if (n <= 1) { printf("Not prime\n"); return; }
    if (n == 2) { printf("Prime\n"); return; }
    if (n % 2 == 0) { printf("Not prime\n"); return; }

    bool isPrime = true;
    for (int i = 3; i <= sqrt(n); i += 2) {
        if (n % i == 0) {
            isPrime = false;
            break;
        }
    }
    printf(isPrime ? "Prime\n" : "Not prime\n");
}

int main() {
    int t;
    scanf("%d", &t);
    while (t--) { solve(); }
    return 0;
}
