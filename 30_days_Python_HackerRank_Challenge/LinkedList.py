#python-2
class Node:
    def __init__(self,data):
        self.data = data
        self.next = None
class Solution:
    def display(self,head):
        current = head
        while current:
            print current.data,
            current = current.next
            
    def insert(self, head, data):
        """
        Inserts a new node with 'data' at the tail of the list.
        """
        new_node = Node(data)
        
        # Scenario 1: The list is empty
        if head is None:
            return new_node
        
        # Scenario 2: The list has elements
        current = head
        # Walk to the last node (the one where .next is None)
        while current.next:
            current = current.next
        
        # Link the new node to the end
        current.next = new_node
        
        return head
            
            
mylist= Solution()
T=int(input())
head=None
for i in range(T):
    data=int(input())
    head=mylist.insert(head,data)    
mylist.display(head);
