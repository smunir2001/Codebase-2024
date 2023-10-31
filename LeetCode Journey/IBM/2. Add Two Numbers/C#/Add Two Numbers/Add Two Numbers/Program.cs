using Add_Two_Numbers;

public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("2. Add Two Numbers");

        ListNode l1a = new ListNode(2);
        ListNode l1b = new ListNode(4);
        ListNode l1c = new ListNode(3);
        l1a.next = l1b;
        l1b.next = l1c;
        printList(l1a);

        ListNode l2a = new ListNode(5);
        ListNode l2b = new ListNode(6);
        ListNode l2c = new ListNode(4);
        l2a.next = l2b;
        l2b.next = l2c;
        printList(l2a);

        Solution solObj = new Solution();
        ListNode output = solObj.AddTwoNumbers(l1a, l2a);
        printList(output);
    }

    private static void printList(ListNode head) {
        ListNode currentNode = head;
        Console.Write("list --> ");
        while (currentNode != null) {
            Console.Write(currentNode.val + " ");
            currentNode = currentNode.next;
        }
        Console.WriteLine();
    }
}