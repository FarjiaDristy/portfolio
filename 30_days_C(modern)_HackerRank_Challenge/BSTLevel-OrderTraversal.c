#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

typedef struct Node{
    struct Node* left;
    struct Node* right;
    int data;
}Node;
Node* newNode(int data){
    Node* node=(Node*)malloc(sizeof(Node));
    node->left=node->right=NULL;
    node->data=data;
    return node;
}

void levelOrder(Node* root){
    if (root == NULL) return;

    // Use an array as a simple queue
    Node* queue[500]; // Size based on constraints
    int head = 0;
    int tail = 0;

    queue[tail++] = root;

    while (head < tail) {
        Node* current = queue[head++];
        printf("%d ", current->data);

        if (current->left != NULL) {
            queue[tail++] = current->left;
        }
        if (current->right != NULL) {
            queue[tail++] = current->right;
        }
    }

}

Node* insert(Node* root,int data){
    if(root==NULL)
        return newNode(data);
    else{
        Node* cur;
        if(data<=root->data){
            cur=insert(root->left,data);
            root->left=cur;                
        }
        else{
            cur=insert(root->right,data);
            root->right=cur;
        }
        
    }
    return root;
}
int main(){
    Node* root=NULL;
    int T,data;
    scanf("%d",&T);
    while(T-->0){
        scanf("%d",&data);
        root=insert(root,data);
    }
    levelOrder(root);
    return 0;
    
}
