def find_waiting_time(processes, n, burst_time, wt, quantum):
    remaining_bt = [0] * n
    for i in range(n):
        remaining_bt[i] = burst_time[i]
    t = 0
    while True:
        done = True
        for i in range(n):
            if remaining_bt[i] > 0:
                done = False
                if remaining_bt[i] > quantum:
                    t += quantum
                    remaining_bt[i] -= quantum
                else:
                    t = t + remaining_bt[i]
                    wt[i] = t - burst_time[i]
                    remaining_bt[i] = 0
        if done:
            break

def find_turn_around_time(processes, n, burst_time, wt, tat):
    for i in range(n):
        tat[i] = burst_time[i] + wt[i]

def find_avg_time(processes, n, burst_time, quantum):
    wt = [0] * n
    tat = [0] * n
    find_waiting_time(processes, n, burst_time, wt, quantum)
    find_turn_around_time(processes, n, burst_time, wt, tat)
    print("Processes Burst Time    Waiting",
          "Time Turn-Around Time")
    total_wt = 0
    total_tat = 0
    for i in range(n):
        total_wt = total_wt + wt[i]
        total_tat = total_tat + tat[i]
        print(" ", processes[i], "\t\t", burst_time[i],
              "\t\t", wt[i], "\t\t", tat[i])
    print("\nAverage waiting time = %.5f " % (total_wt / n))
    print("Average turn around time = %.5f " % (total_tat / n))

if __name__ == "__main__":
    proc = [1, 2, 3]
    n = 3
    burst_time = [10, 5, 8]
    quantum = 2

    find_avg_time(proc, n, burst_time, quantum)
