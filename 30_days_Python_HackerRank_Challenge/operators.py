#python-2
#!/bin/python
import math
import os
import random
import re
import sys

def solve(meal_cost, tip_percent, tax_percent):

    #solve function and calculation
    tip = meal_cost * tip_percent / 100.0
    tax = meal_cost * tax_percent / 100.0
    total = meal_cost + tip + tax
    
    print int(round(total))

if __name__ == '__main__':
    meal_cost = float(raw_input().strip())
    tip_percent = int(raw_input().strip())
    tax_percent = int(raw_input().strip())
    solve(meal_cost, tip_percent, tax_percent)

#pythn-3
#!/bin/python3
import math
import os
import random
import re
import sys

def solve(meal_cost, tip_percent, tax_percent):
    tip = meal_cost * tip_percent / 100.0
    tax = meal_cost * tax_percent / 100.0
    total = meal_cost + tip + tax
    
    print(round(total))

if __name__ == '__main__':
    meal_cost = float(input().strip())
    tip_percent = int(input().strip())
    tax_percent = int(input().strip())
    solve(meal_cost, tip_percent, tax_percent)
