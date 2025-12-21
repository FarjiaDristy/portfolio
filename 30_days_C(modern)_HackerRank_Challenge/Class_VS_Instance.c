#include <stdio.h>

typedef struct {
    int age;
} Person;

void initPerson(Person *p, int initialAge) {
    if (initialAge < 0) {
        p->age = 0;
        printf("Age is not valid, setting age to 0.\n");
    } else {
        p->age = initialAge;
    }
}

void amIOld(Person *p) {
    if (p->age < 13)
        printf("You are young.\n");
    else if (p->age < 18)
        printf("You are a teenager.\n");
    else
        printf("You are old.\n");
}

void yearPasses(Person *p) {
    p->age++;
}

int main() {
    int T, age;
    scanf("%d", &T);
    for (int i = 0; i < T; i++) {
        scanf("%d", &age);
        Person p;
        initPerson(&p, age);
        amIOld(&p);
        for (int j = 0; j < 3; j++)
            yearPasses(&p);
        amIOld(&p);
        printf("\n");
    }
    return 0;
}
