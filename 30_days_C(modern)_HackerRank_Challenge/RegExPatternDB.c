#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int compareStrings(const void *a, const void *b) {
    return strcmp(*(const char **)a, *(const char **)b);
}

int main() {
    int N;
    scanf("%d", &N);
    
    char **names = malloc(N * sizeof(char *));
    int count = 0;
    
    for (int i = 0; i < N; i++) {
        char firstName[21], emailID[51];
        scanf("%s %s", firstName, emailID);
        
        char *domain = "@gmail.com";
        char *ptr = strstr(emailID, domain);
        
        if (ptr != NULL && strlen(ptr) == strlen(domain)) {
            names[count] = strdup(firstName);
            count++;
        }
    }
    
    qsort(names, count, sizeof(char *), compareStrings);
    
    for (int i = 0; i < count; i++) {
        printf("%s\n", names[i]);
        free(names[i]);
    }
    free(names);
    
    return 0;
}
