namespace Doubly_Linkedlists;

public class DoublyLinkedlist {
    private Node head;
    private Node tail;
    private int totalElements = 0;
    private int headPointer = -1;
    private int tailPointer = -1;

    public DoublyLinkedlist() {}

    private Boolean isEmpty() {
        if (head == null || tail == null) {
            return true;
        } else {
            return false;
        }
    }

    private void printDS() {
        if (isEmpty()) {
            Console.Write("\tHEAD <-> NULL");
        } else {
            Console.Write("\tHEAD <-> ");
            Node currentNode = this.head;
            while (currentNode != null) {
                Console.Write(currentNode.getData() + " <-> ");
                currentNode = currentNode.getNext();
            }
            Console.Write("NULL");
        }
    }

    private void printStats() {
        if (isEmpty()) {
            Console.WriteLine("HEAD.getData(): N/A");
            Console.WriteLine("TAIL.getData(): N/A");
        } else {
            Console.WriteLine("HEAD.getData(): " + head.getData());
            Console.WriteLine("TAIL.getData(): " + tail.getData());
        }
        Console.WriteLine("total elements: " + totalElements);
        Console.WriteLine("HEAD pointer: " + headPointer);
        Console.WriteLine("TAIL pointer: " + tailPointer);
        printDS();
    }

    public void insertFirst(int data) {}

    public void removeFirst() {}

    public void insertTail() {}

    public void removeTail() {}
}