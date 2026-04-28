#python 2 3
import math
import sys

def is_prime(n):
    if n <= 1: return False
    if n == 2: return True
    if n % 2 == 0: return False
    
    for i in range(3, int(math.sqrt(n)) + 1, 2):
        if n % i == 0:
            return False
    return True

input_data = sys.stdin.read().split()
if input_data:
    t = int(input_data[0])
    for i in range(1, t + 1):
        n = int(input_data[i])
        if is_prime(n):
            print("Prime")
        else:
            print("Not prime")
