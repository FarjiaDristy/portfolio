if __name__ == "__main__":
    n = 5 
    m = 3 
    
    allocation = [[1, 2, 0], [2, 0, 0], [3, 0, 2], [2, 1, 1], [0, 0, 2]]
    
    max_need = [[7, 5, 3], [3, 2, 2], [9, 0, 2], [2, 2, 2], [4, 3, 3]]
    
    available = [2, 2, 2] 
    
    finished = [0] * n
    sequence = [0] * n
    index = 0
    for k in range(n):
        finished[k] = 0
        
    need = [[0 for i in range(m)] for i in range(n)]
    for i in range(n):
        for j in range(m):
            need[i][j] = max_need[i][j] - allocation[i][j]
    
    for k in range(5):
        for i in range(n):
            if finished[i] == 0:
                flag = 0
                for j in range(m):
                    if need[i][j] > available[j]:
                        flag = 1
                        break
                
                if flag == 0:
                    sequence[index] = i
                    index += 1
                    for y in range(m):
                        available[y] += allocation[i][y]
                    finished[i] = 1
                    
    print("Following is the SAFE Sequence:")
    
    for i in range(n - 1):
        print(" P", sequence[i], " ->", sep="", end="")
    print(" P", sequence[n - 1], sep="")
