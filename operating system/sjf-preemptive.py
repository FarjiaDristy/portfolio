n = int(input('Enter the number of processes: '))
burst_times = [0] * (n + 1)
arrival_times = [0] * (n + 1)
actual_burst_times = [0] * (n + 1)

# Input burst time and arrival time for each process
for i in range(n):
    actual_burst_times[i] = int(input('Enter the burst time for process {}: '.format(i + 1)))
    arrival_times[i] = int(input('Enter the arrival time for process {}: '.format(i + 1)))
    burst_times[i] = [actual_burst_times[i], arrival_times[i], i]

burst_times.pop(-1)

total_burst_time = 0
schedule = []

# Perform preemptive shortest job first scheduling
for i in range(0, sum(actual_burst_times)):
    arrived_processes = [j for j in burst_times if j[1] <= i]
    if arrived_processes:
        arrived_processes.sort(key=lambda x: x[0])
        burst_times[burst_times.index(arrived_processes[0])][0] -= 1
        for k in burst_times:
            if k[0] == 0:
                t = burst_times.pop(burst_times.index(k))
                schedule.append([k, i + 1])

completion_times = [0] * (n + 1)
turnaround_times = [0] * (n + 1)
waiting_times = [0] * (n + 1)

# Calculate completion time, turnaround time, and waiting time for each process
for i in schedule:
    completion_times[i[0][2]] = i[1]

for i in range(len(completion_times)):
    turnaround_times[i] = completion_times[i] - arrival_times[i]
    waiting_times[i] = turnaround_times[i] - actual_burst_times[i]

completion_times.pop(-1)
waiting_times.pop(-1)
turnaround_times.pop(-1)
actual_burst_times.pop(-1)
arrival_times.pop(-1)

average_waiting_time = sum(waiting_times) / len(waiting_times)

print('Average Waiting Time = {:.2f}'.format(average_waiting_time))
