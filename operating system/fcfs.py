
print("FIRST COME FIRST SERVE SCHEDULING")
n = int(input("Enter number of processes: "))
d = dict()

# Input for arrival time and burst time for each process
for i in range(n):
    key = "P" + str(i + 1)
    arrival_time = int(input("Enter arrival time of process " + str(i + 1) + ": "))
    burst_time = int(input("Enter burst time of process " + str(i + 1) + ": "))
    l = [arrival_time, burst_time]
    d[key] = l

# Sort processes based on arrival time
d = sorted(d.items(), key=lambda item: item[1][0])

ET = []
for i in range(len(d)):
    # First process
    if i == 0:
        ET.append(d[i][1][1])
    else:
        ET.append(ET[i - 1] + d[i][1][1])

TAT = []
for i in range(len(d)):
    TAT.append(ET[i] - d[i][1][0])

WT = []
for i in range(len(d)):
    WT.append(TAT[i] - d[i][1][1])

avg_WT = sum(WT) / n  # Average Waiting Time

# Display only the average waiting time
print("Average Waiting Time:", avg_WT)
