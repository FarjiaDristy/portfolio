#Python-2
#!/bin/python
import math
import os
import random
import re
import sys

if __name__ == '__main__':
    n = int(raw_input().strip())

    arr = map(int, raw_input().rstrip().split())
    print ' '.join(map(str, arr[::-1]))


#Python-3
#!/bin/python3
import math
import os
import random
import re
import sys

if __name__ == '__main__':
    n = int(input().strip())

    arr = list(map(int, input().rstrip().split()))
    print(*arr[::-1])
