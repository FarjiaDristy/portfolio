n = int(input('Enter no of processes: '))
bt = [0] * (n + 1)
at = [0] * (n + 1)
abt = [0] * (n + 1)

for i in range(n):
    abt[i] = int(input('Enter the burst time for process {}: '.format(i + 1)))
    at[i] = int(input('Enter the arrival time for process {}: '.format(i + 1)))
    bt[i] = [abt[i], at[i], i]

bt.pop(-1)

sumbt = 0
i = 0
ll = []

for i in range(0, sum(abt)):
    l = [j for j in bt if j[1] <= i]
    l.sort(key=lambda x: x[0])
    bt[bt.index(l[0])][0] -= 1
    for k in bt:
        if k[0] == 0:
            t = bt.pop(bt.index(k))
            ll.append([k, i + 1])

ct = [0] * (n + 1)
tat = [0] * (n + 1)
wt = [0] * (n + 1)

for i in ll:
    ct[i[0][2]] = i[1]

for i in range(len(ct)):
    tat[i] = ct[i] - at[i]
    wt[i] = tat[i] - abt[i]

ct.pop(-1)
wt.pop(-1)
tat.pop(-1)
abt.pop(-1)
at.pop(-1)

print('Average Waiting Time = {:.2f}'.format(sum(wt) / len(wt)))
