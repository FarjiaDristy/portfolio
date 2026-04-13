#include <stdio.h>

char stack[1000];
char queue[1000];
int top = -1, front = 0, rear = -1;

void pushCharacter(char ch) {
    stack[++top] = ch;
}

void enqueueCharacter(char ch) {
    queue[++rear] = ch;
}

char popCharacter() {
    return stack[top--];
}

char dequeueCharacter() {
    return queue[front++];
}
