using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.LinkedList
{
    // Source: https://leetcode.com/problems/odd-even-linked-list/solutions/6516707/simple-best-solution-beats-100-31-by-iqb-9iqa/
    /*
        Given the head of a singly linked list, group all the nodes with odd indices 
        together followed by the nodes with even indices, and return the reordered list.

        The first node is considered odd, and the second node is even, and so on.
        Note that the relative order inside both the even and odd groups should remain as 
        it was in the input.

        You must solve the problem in O(1) extra space complexity and O(n) time complexity.
    

        Example 1:
        Input: head = [1,2,3,4,5]
        Output: [1,3,5,2,4]

        Example 2:
        Input: head = [2,1,3,5,6,4,7]
        Output: [2,3,6,7,1,5,4]

        Constraints:
        The number of nodes in the linked list is in the range [0, 104].
        -106 <= Node.val <= 106     
     */

    public static class OddEvenLinkedList
    {
        static ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode odd = head;
            ListNode even = head.next;
            ListNode evenHead = even;

            while (even != null && even.next != null)
            {
                odd.next = odd.next.next;
                even.next = even.next.next;

                odd = odd.next;
                even = even.next;
            }

            odd.next = evenHead;
            return head;
        }

        static void PrintLinkedList(ListNode head)
        {
            var sResult = "";
            while (head != null)
            {
                sResult += head.val + (head.next != null ? ", " : "");
                head = head.next;
            }
            Console.WriteLine("[" + sResult + "]");
        }
        public static void Execute()
        {
            ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            ListNode result1 = OddEvenList(head1);
            PrintLinkedList(result1); // Output: [1,3,5,2,4]
            ListNode head2 = new ListNode(2, new ListNode(1, new ListNode(3, new ListNode(5,new ListNode(6, new ListNode(4, new ListNode(7)))))));
            ListNode result2 = OddEvenList(head2);
            PrintLinkedList(result2); // Output: [1, 2, 4]
        }
    }
}
