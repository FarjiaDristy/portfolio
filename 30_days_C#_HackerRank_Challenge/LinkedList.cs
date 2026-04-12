using System;
class Node
{
	public int data;
	public Node next;
    public Node(int d){
        data=d;
        next=null;
    }
		
}
class Solution {
    public static Node insert(Node head, int data) {
        Node newNode = new Node(data);

        // If the list is empty, the new node becomes the head
        if (head == null) {
            return newNode;
        }

        // Traverse to the end of the list
        Node current = head;
        while (current.next != null) {
            current = current.next;
        }

        // Link the last node to our new node
        current.next = newNode;
        return head;
    }


	public static void display(Node head)
	{
		Node start=head;
		while(start!=null)
		{
			Console.Write(start.data+" ");
			start=start.next;
		}
	}
    static void Main(String[] args) {
	
		Node head=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            head=insert(head,data);
        }
		display(head);
	}
}
	
