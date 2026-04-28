#py 2
#!/bin/python
def bitwiseAnd(N, K):
    if ((K - 1) | K) <= N:
        return K - 1
    else:
        return K - 2

t = int(raw_input().strip())
for _ in xrange(t):
    n, k = map(int, raw_input().split())
    print bitwiseAnd(n, k)


#py 3
#!/bin/python3
def bitwiseAnd(N, K):
    if ((K - 1) | K) <= N:
        return K - 1
    else:
        return K - 2

if __name__ == '__main__':
    t = int(input().strip())
    for _ in range(t):
        n, k = map(int, input().split())
        print(bitwiseAnd(n, k))
