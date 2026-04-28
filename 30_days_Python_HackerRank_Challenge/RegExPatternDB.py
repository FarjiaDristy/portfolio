#py 2
#!/bin/python
import sys
n = int(raw_input().strip())
names = []
for _ in xrange(n):
    firstName, emailID = raw_input().strip().split()
    
    if emailID.endswith("@gmail.com"):
        names.append(firstName)

names.sort()
for name in names:
    print name

#py 3
#!/bin/python3
import sys
n = int(input().strip())
names = []
for _ in range(n):
    firstName, emailID = input().strip().split()
    
    if emailID.endswith("@gmail.com"):
        names.append(firstName)
names.sort()

for name in names:
    print(name)
