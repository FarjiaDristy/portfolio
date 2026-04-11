#python-2
T = int(raw_input())

for _ in range(T):
    s = raw_input()
    even = ""
    odd = ""

    for i in range(len(s)):
        if i % 2 == 0:
            even += s[i]
        else:
            odd += s[i]

    print even + " " + odd

#python-3
T = int(input())

for _ in range(T):
    s = input()
    even = s[::2]
    odd = s[1::2]
    print(even, odd)
