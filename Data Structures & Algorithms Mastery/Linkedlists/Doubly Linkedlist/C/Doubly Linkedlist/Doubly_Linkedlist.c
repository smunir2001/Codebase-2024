/*
    Sami Munir
    smunir2001@gmail.com
    November 12, 2023
    Rutgers University
    Data Structures & Algorithms Mastery
    - Doubly Linkedlists: C
*/

#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

struct Node {
    int data;
    struct Node *next;
    struct Node *prev;
} *head=NULL, *tail=NULL;

int totalElements = 0;
int headPointer = -1;
int tailPointer = -1;

int isEmpty() {
    if (head == NULL || tail == NULL) {
        return 1;
    } else {
        return 0;
    }
}

void printDS() {
    if (isEmpty() == 1) {
        printf("\tHEAD <-> TAIL\n");
    } else {
        printf("\tHEAD <-> ");
        struct Node *currentNode = head;
        while (currentNode != NULL) {
            printf("%d <-> ", currentNode -> data);
            currentNode = currentNode -> next;
        }
        printf("TAIL\n");
    }
}

void printStats() {
    printf("\nDS Stats -->\n");
    if (!isEmpty()) {
        printf("HEAD -> data: %d\n", head -> data);
        printf("TAIL -> data: %d\n", tail -> data);
    }
    printf("total elements: %d\n", totalElements);
    printf("headPointer: %d\n", headPointer);
    printf("tailPointer: %d\n", tailPointer);
    printDS();
}

void insertFirst(int data) {
    printf("\ninsertFirst(%d) called...", data);
    if (isEmpty()) {
        head = (struct Node*) malloc(sizeof(struct Node));
        head -> data = data;
        head -> next = NULL;
        head -> prev = NULL;
        tail = head;
        totalElements++;
        headPointer++;
        tailPointer++;
    } else {
        struct Node *tempHead = head;
        struct Node *newNode = (struct Node*) malloc(sizeof(struct Node));
        newNode -> data = data;
        tempHead -> prev = newNode;
        if (tempHead -> next == NULL) {
            tail = tempHead;
        }
        newNode -> next = tempHead;
        newNode -> prev = NULL;
        head = newNode;
        totalElements++;
        tailPointer++;
    }
    printStats();
}

void removeFirst() {
    if (isEmpty()) {
        printf("\nremoveFirst() called...");
        printf("\n\t--<ERROR>-- linkedlist is empty.");
    } else {
        printf("\nremoveFirst(%d) called...", head -> data);
        if (head -> next == NULL) {
            head = tail = NULL;
            totalElements = 0;
            headPointer = tailPointer = -1;
            free(head);
            free(tail);
        } else {
            head -> next -> prev = NULL;
            head = head -> next;
            totalElements--;
            tailPointer--;
        }
    }
    printStats();
}

void insertLast(int data) {
    printf("\ninsertLast(%d) called...", data);
    if (isEmpty()) {
        head = tail = (struct Node*) malloc(sizeof(struct Node));
        head -> data = data;
        head -> next = head -> prev = NULL;
        totalElements = 1;
        headPointer = tailPointer = 0;
    } else {
        if (head -> next == NULL) {
            struct Node *newNode = (struct Node*) malloc(sizeof(struct Node));
            newNode -> data = data;
            newNode -> next = NULL;
            newNode -> prev = head;
            tail = newNode;
            head -> next = newNode;
            totalElements++;
            tailPointer++;
        } else {
            struct Node *tempHead = head;
            struct Node *currentNode = tempHead;
            while (currentNode != NULL) {
                if (currentNode -> next == NULL) {
                    break;
                }
                currentNode = currentNode -> next;
            }
            struct Node *newNode = (struct Node*) malloc(sizeof(struct Node));
            newNode -> data = data;
            newNode -> prev = currentNode;
            newNode -> next = NULL;
            currentNode -> next = newNode;
            tail = currentNode -> next;
            totalElements++;
            tailPointer++;
        }
    }
    printStats();
}

void removeLast() {
    if (isEmpty()) {
        printf("\nremoveLast() called...");
        printf("\n\t--<ERROR>-- linkedlist is empty.");
    } else {
        printf("\nremoveLast(%d) called...", tail -> data);
        if (head -> next == NULL) {
            head = tail = NULL;
            totalElements = 0;
            headPointer = tailPointer = -1;
            free(head);
            free(tail);
        } else {
            struct Node *tempHead = head;
            struct Node *currentNode = tempHead;
            while (currentNode != NULL) {
                if (currentNode -> next -> next == NULL) {
                    break;
                }
                currentNode = currentNode -> next;
            }
            tail = tail -> prev;
            currentNode -> next = NULL;
            head = tempHead;
            totalElements--;
            tailPointer--;
        }
    }
    printStats();
}

int main(int argc, char* argv[]) {
    printf("Doubly Linkedlists in C\n");
    printf("-----------------------\n");

    printStats();

    // testing function insertFirst()
    insertFirst(2);
    insertFirst(-11);
    insertFirst(65);

    // testing function removeFirst()
    removeFirst();
    removeFirst();
    removeFirst();
    removeFirst(); // ERROR expected --> NULL linkedlist removal

    // testing function insertLast()
    insertLast(2);
    insertLast(-11);
    insertLast(65);

    // testing function removeLast()
    removeLast();
    removeLast();
    removeLast();
    removeLast(); // ERROR expected --> NULL linkedlist removal

    return EXIT_SUCCESS;
}