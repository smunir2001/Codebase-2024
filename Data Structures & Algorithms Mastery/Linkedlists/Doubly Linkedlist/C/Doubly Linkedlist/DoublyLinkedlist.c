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

struct Node {
    int data;
    struct Node *next;
    struct Node *prev;
} *head, *tail;

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
        struct Node *currentNode = (struct Node*) malloc(sizeof(struct Node*));
        while (currentNode != NULL) {
            printf("%d <-> ", currentNode -> data);
            currentNode = currentNode -> next;
        }
        printf("TAIL\n");
    }
}

void printStats() {
    printf("\nDS Stats...\n");
    printf("total elements: %d\n", totalElements);
    printf("headPointer: %d\n", headPointer);
    printf("tailPointer: %d\n", tailPointer);
    printDS();
}

int main(int argc, char* argv[]) {
    printf("Doubly Linkedlists in C\n");
    printf("-----------------------\n");

    printStats();
    return EXIT_SUCCESS;
}