#python-2
#!/bin/python

import math
import os
import random
import re
import sys

if __name__ == '__main__':
    n = int(raw_input().strip())

    a = map(int, raw_input().rstrip().split())

totalSwaps = 0

for i in range(n):
    numberOfSwaps = 0

    for j in range(n - 1):
        if a[j] > a[j + 1]:
            a[j], a[j + 1] = a[j + 1], a[j]
            numberOfSwaps += 1
            totalSwaps += 1

    if numberOfSwaps == 0:
        break

print "Array is sorted in %d swaps." % totalSwaps
print "First Element: %d" % a[0]
print "Last Element: %d" % a[n - 1]


#python-3
#!/bin/python3

import math
import os
import random
import re
import sys

if __name__ == '__main__':
    n = int(input().strip())

    a = list(map(int, input().rstrip().split()))

    totalSwaps = 0

for i in range(n):
    numberOfSwaps = 0

    for j in range(n - 1):
        if a[j] > a[j + 1]:
            a[j], a[j + 1] = a[j + 1], a[j]
            numberOfSwaps += 1
            totalSwaps += 1

    if numberOfSwaps == 0:
        break

print(f"Array is sorted in {totalSwaps} swaps.")
print(f"First Element: {a[0]}")
print(f"Last Element: {a[-1]}")
