#CPP 11 14
#include <iostream>
#include <cstddef>
using namespace std;	
class Node
{
    public:
        int data;
        Node *next;
        Node(int d){
            data=d;
            next=NULL;
        }
};
class Solution{
    public:

      Node* insert(Node *head, int data) {
        // Use 'new' in C++ to call the constructor properly
        Node* newNode = new Node(data);

        // If the list is empty, the new node is the head
        if (head == NULL) {
            return newNode;
        }

        // Traverse to the end of the list
        Node* current = head;
        while (current->next != NULL) {
            current = current->next;
        }

        // Link the last node to the new node
        current->next = newNode;
        return head;
    }

      void display(Node *head)
      {
          Node *start=head;
          while(start)
          {
              cout<<start->data<<" ";
              start=start->next;
          }
      }
};
int main()
{
	Node* head=NULL;
  	Solution mylist;
    int T,data;
    cin>>T;
    while(T-->0){
        cin>>data;
        head=mylist.insert(head,data);
    }	
	mylist.display(head);
		
}

#CPP 20
#include <iostream>
#include <cstddef>
using namespace std;

class Node {
public:
    int data;
    Node *next;
    Node(int d) {
        data = d;
        next = NULL;
    }
};

class Solution {
public:
    Node* insert(Node *head, int data) {
        // Use 'new' in C++ to call the constructor properly
        Node* newNode = new Node(data);

        // If the list is empty, the new node is the head
        if (head == NULL) {
            return newNode;
        }

        // Traverse to the end of the list
        Node* current = head;
        while (current->next != NULL) {
            current = current->next;
        }

        // Link the last node to the new node
        current->next = newNode;
        return head;
    }

    void display(Node *head) {
        Node *start = head;
        while (start) {
            cout << start->data << " ";
            start = start->next;
        }
    }
}; // Closing the Solution class properly

int main() {
    Node* head = NULL;
    Solution mylist;
    int T, data;
    cin >> T;
    while (T-- > 0) {
        cin >> data;
        head = mylist.insert(head, data);
    }
    mylist.display(head);
    return 0;
}
