#python 2, python 3
import sys

d1, m1, y1 = map(int, sys.stdin.readline().split())
d2, m2, y2 = map(int, sys.stdin.readline().split())

fine = 0

if y1 > y2:
    fine = 10000
elif y1 == y2:
    if m1 > m2:
        fine = 500 * (m1 - m2)
    elif m1 == m2:
        if d1 > d2:
            fine = 15 * (d1 - d2)

print(fine)
