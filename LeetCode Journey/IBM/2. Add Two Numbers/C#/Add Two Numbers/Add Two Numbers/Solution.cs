namespace Add_Two_Numbers;

public class Solution {
    public Solution() {}

    /*
        Solution
        Time complexity: O(n)
        Space complexity: O(1)
        Runtime: 84ms
        Memory: 49.63MB
    */
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode l3 = new ListNode(0);
        ListNode tempHead = l3;
        int carry = 0;
        while (l1 != null && l2 != null) {
            int currentValue = l1.val + l2.val + carry;
            carry = currentValue / 10;
            l3.next = new ListNode((currentValue % 10));
            l3 = l3.next;
            l1 = l1.next;
            l2 = l2.next;
        }
        while (l1 != null) {
            int currentValue = l1.val + carry;
            carry = currentValue / 10;
            l3.next = new ListNode((currentValue % 10));
            l3 = l3.next;
            l1 = l1.next;
        }

        while (l2 != null) {
            int currentValue = l2.val + carry;
            carry = currentValue / 10;
            l3.next = new ListNode((currentValue % 10));
            l3 = l3.next;
            l2 = l2.next;
        }

        if (carry != 0) {
            l3.next = new ListNode(carry);
        }

        return tempHead.next;
    }
}