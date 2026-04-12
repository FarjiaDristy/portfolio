#python-2
#!/bin/python
import math
import os
import random
import re
import sys

def factorial(n):
    if n <= 1:
        return 1
    return n * factorial(n - 1)
    
if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    n = int(raw_input().strip())
    result = factorial(n)
    fptr.write(str(result) + '\n')
    fptr.close()

#python-3
#!/bin/python3
import math
import os
import random
import re
import sys

def factorial(n):
    # Write your code here
    if n <= 1:
        return 1
    return n * factorial(n - 1)

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    n = int(input().strip())
    result = factorial(n)
    fptr.write(str(result) + '\n')
    fptr.close()
