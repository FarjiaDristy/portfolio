#python-2
#!/bin/python

import math
import os
import random
import re
import sys

if __name__ == '__main__':
    n = int(raw_input().strip())

max_count = 0
current = 0

while n > 0:
    if n & 1:
        current += 1
        max_count = max(max_count, current)
    else:
        current = 0
    n >>= 1

print max_count

#python-3
#!/bin/python3

import math
import os
import random
import re
import sys

if __name__ == '__main__':
    n = int(input().strip())
    binary = bin(n)[2:]
    print(max(len(x) for x in binary.split('0')))
    
