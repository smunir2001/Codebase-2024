namespace Doubly_Linkedlists;

public class DoublyLinkedlist {
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
            Console.Write("\t\tHEAD <-> NULL\n");
        } else {
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

    public void InsertFirst(int data) {
        Console.WriteLine("\ninsertFirst(" + data + ") called...");
        if (IsEmpty()) {
            head = new Node();
            head.SetData(data);
            head.SetNext(null);
            head.SetPrev(null);
            tail = head;
            totalElements++;
            headPointer++;
            tailPointer++;
        } else {
            Node tempHead = head;
            Node newNode = new Node();
            newNode.SetData(data);
            tempHead.SetPrev(newNode);
            if (tempHead.GetNext() == null) {
                tail = tempHead;
            }
            newNode.SetNext(tempHead);
            newNode.SetPrev(null);
            head = newNode;
            totalElements++;
            tailPointer++;
        }
        PrintStats();
    }

    public void RemoveFirst() {}

    public void InsertTail() {}

    public void RemoveTail() {}

    override public string ToString() {
        PrintDS();
        return "";
    }
}