#python-2
n = int(raw_input())
phonebook = {}

for _ in range(n):
    name, number = raw_input().split()
    phonebook[name] = number

while True:
    try:
        query = raw_input()
        if query in phonebook:
            print query + "=" + phonebook[query]
        else:
            print "Not found"
    except EOFError:
        break

#python-3
n = int(input())
phonebook = {}

for _ in range(n):
    name, number = input().split()
    phonebook[name] = number

while True:
    try:
        query = input()
        print(f"{query}={phonebook[query]}" if query in phonebook else "Not found")
    except EOFError:
        break
