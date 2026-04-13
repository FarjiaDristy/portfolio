# Python 2 version
import sys
S = raw_input().strip()

try:
    print int(S)
except ValueError:
    print "Bad String"

#python 3 version
import sys

# Python 2 version
S = input().strip()

try:
    print (int(S))
except ValueError:
    print ("Bad String")
