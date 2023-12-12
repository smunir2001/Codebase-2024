namespace Linkedlist_Queue;

public class LLQueue {
    private Node head;
    private Node tail;
    private int totalElements = 0;
    private int headPointer = -1;
    private int tailPointer = -1;
    
    private Boolean IsEmpty() {
        if (head == null || tail == null) {
            return true;
        } else {
            return false;
        }
    }

    private void PrintDS() {
        if (IsEmpty()) {
            Console.Write("\t\tHEAD <-> ");
            Node currentNode = this.head;
            while (currentNode != null) {
                Console.Write(currentNode.GetData() + " <-> ");
                currentNode = currentNode.GetNext();
            }
            Console.Write("NULL\n");
        }
    }

    private void PrintStats() {
        if (IsEmpty()) {
            Console.WriteLine("\tHEAD.getData(): N/A");
            Console.WriteLine("\tTAIL.getData(): N/A");
        } else {
            Console.WriteLine("\tHEAD.getData(): " + head.GetData());
            Console.WriteLine("\tTAIL.getData(): " + tail.GetData());
        }
        Console.WriteLine("\ttotal elements: " + totalElements);
        Console.WriteLine("\tHEAD pointer: " + headPointer);
        Console.WriteLine("\tTAIL pointer: " + tailPointer);
        PrintDS();
    }
}