#py 3
#!/bin/python3
import math
import os
import random
import re
import sys

def superDigit(n, k):
    initial_sum = sum(int(digit) for digit in n)
    
    total_sum = initial_sum * k
    
    def get_super_digit(val):
        if val < 10:
            return val

        next_val = sum(int(d) for d in str(val))
        return get_super_digit(next_val)
    
    return get_super_digit(total_sum)


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    first_multiple_input = input().rstrip().split()
    n = first_multiple_input[0]
    k = int(first_multiple_input[1])
    result = superDigit(n, k)
    fptr.write(str(result) + '\n')
    fptr.close()


