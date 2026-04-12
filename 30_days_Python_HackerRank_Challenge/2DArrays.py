#python-2
#!/bin/python

import math
import os
import random
import re
import sys

if __name__ == '__main__':

    arr = []

    for _ in xrange(6):
        arr.append(map(int, raw_input().rstrip().split()))
        max_sum = -1000

for i in range(4):
    for j in range(4):
        s = arr[i][j] + arr[i][j+1] + arr[i][j+2] \
            + arr[i+1][j+1] \
            + arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2]

        max_sum = max(max_sum, s)

print max_sum


#python-3
#!/bin/python3

import math
import os
import random
import re
import sys

if __name__ == '__main__':

    arr = []

    for _ in range(6):
        arr.append(list(map(int, input().rstrip().split())))
        max_sum = -1000

for i in range(4):
    for j in range(4):
        s = arr[i][j] + arr[i][j+1] + arr[i][j+2] \
            + arr[i+1][j+1] \
            + arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2]

        max_sum = max(max_sum, s)

print(max_sum)
