print("Shortest Job First Scheduling (Non-Preemptive)")

n = int(input("Enter the number of processes: "))
processes = []

# Input for arrival time and burst time for each process
for i in range(n):
    arrival_time = int(input(f"Enter arrival time for process P{i + 1}: "))
    burst_time = int(input(f"Enter burst time for process P{i + 1}: "))
    processes.append({"process": f"P{i + 1}", "arrival_time": arrival_time, "burst_time": burst_time})

# Sort processes based on arrival time and burst time (SJF)
processes.sort(key=lambda x: (x["arrival_time"], x["burst_time"]))

completion_time = [0] * n
turnaround_time = [0] * n
waiting_time = [0] * n

completion_time[0] = processes[0]["arrival_time"] + processes[0]["burst_time"]

for i in range(1, n):
    completion_time[i] = completion_time[i - 1] + processes[i]["burst_time"]

for i in range(n):
    turnaround_time[i] = completion_time[i] - processes[i]["arrival_time"]
    waiting_time[i] = turnaround_time[i] - processes[i]["burst_time"]

avg_waiting_time = sum(waiting_time) / n

# Display only the average waiting time
print("Average Waiting Time:", avg_waiting_time)
