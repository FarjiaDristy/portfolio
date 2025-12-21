#python-2
#!/bin/python

import math
import os
import random
import re
import sys

if __name__ == '__main__':
    n = int(raw_input().strip())
    for i in range(1, 11):
        print "%d x %d = %d" % (n, i, n * i)

#python-3
#!/bin/python3

import math
import os
import random
import re
import sys



if __name__ == '__main__':
    n = int(input().strip())
    for i in range (1, 11):
        print(f"{n} x {i} = {n *i}")
