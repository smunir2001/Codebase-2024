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
}