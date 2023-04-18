//https://leetcode.com/problems/add-two-numbers/
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2, int carry = 0)
    {
        var i1 = l1 == null ? 0 : l1.val;
        var i2 = l2 == null ? 0 : l2.val;
        var sum = i1 + i2 + carry;
        var currentNum = sum % 10;
        carry = sum >= 10 ? 1 : 0;

        if (l1?.next == null && l2?.next == null)
            return new ListNode(currentNum, carry == 1 ? new ListNode(1) : null);

        var nextNdoe = AddTwoNumbers(l1?.next ?? null, l2?.next ?? null, carry);

        return new ListNode(currentNum, nextNdoe);
    }
}