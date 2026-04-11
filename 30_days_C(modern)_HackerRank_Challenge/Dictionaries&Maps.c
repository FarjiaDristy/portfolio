#include <stdio.h>
#include <string.h>

#define SIZE 100003

typedef struct Node {
    char name[20];
    char number[20];
    struct Node* next;
} Node;

Node* table[SIZE];

// simple hash function
unsigned int hash(char* s) {
    unsigned int h = 0;
    while (*s)
        h = (h * 31 + *s++) % SIZE;
    return h;
}

void insert(char* name, char* number) {
    unsigned int idx = hash(name);

    Node* newNode = (Node*)malloc(sizeof(Node));
    strcpy(newNode->name, name);
    strcpy(newNode->number, number);
    newNode->next = table[idx];
    table[idx] = newNode;
}

char* find(char* name) {
    unsigned int idx = hash(name);
    Node* curr = table[idx];

    while (curr) {
        if (strcmp(curr->name, name) == 0)
            return curr->number;
        curr = curr->next;
    }
    return NULL;
}

int main() {
    int n;
    scanf("%d", &n);

    for (int i = 0; i < SIZE; i++)
        table[i] = NULL;

    char name[20], number[20];

    for (int i = 0; i < n; i++) {
        scanf("%s %s", name, number);
        insert(name, number);
    }

    while (scanf("%s", name) != EOF) {
        char* result = find(name);
        if (result)
            printf("%s=%s\n", name, result);
        else
            printf("Not found\n");
    }

    return 0;
}
