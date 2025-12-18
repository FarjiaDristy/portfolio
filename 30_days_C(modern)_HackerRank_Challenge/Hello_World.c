#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() {
    char input_string[105]; 

    scanf("%[^\n]", input_string); 
    
    printf("Hello, World.\n");
    printf(input_string, "%s\n");
    
    return 0;
}
