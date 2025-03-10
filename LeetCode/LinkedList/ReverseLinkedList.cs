using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.LinkedList
{
    // Source: https://leetcode.com/problems/reverse-linked-list/solutions/6519588/simple-best-solution-by-iqbaldiit-086x/
    /*
        Given the head of a singly linked list, reverse the list, and return the reversed list.

        Example 1:
        Input: head = [1,2,3,4,5]
        Output: [5,4,3,2,1]

        Example 2:
        Input: head = [1,2]
        Output: [2,1]

        Example 3:
        Input: head = [1]
        Output: [1]
 

        Constraints:

        The number of nodes in the list is the range [0, 5000].
        -5000 <= Node.val <= 5000
 

        Follow up: A linked list can be reversed either iteratively or recursively. Could you implement both?     
     */
    public static class ReverseLinkedList
    {
        static ListNode ReverseList(ListNode head)
        {
            ////Approach : Iterative
            //ListNode prev = null;
            //ListNode current = head;

            //while (current != null)
            //{
            //    ListNode nextNode = current.next;  // Save the next node
            //    current.next = prev;              // Reverse the link
            //    prev = current;                   // Move 'prev' forward
            //    current = nextNode;               // Move 'current' forward
            //}

            //return prev; // New head of the reversed list

            // Approach: Recursive
            if (head == null || head.next == null)
                return head;  // Base case: if the list is empty or contains one node

            ListNode newHead = ReverseList(head.next); // Recursively reverse the rest of the list
            head.next.next = head;  // Point next node back to the current node
            head.next = null;       // Break the forward link

            return newHead;         // Return the new head

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
            ListNode head1 = new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(7, new ListNode(1, new ListNode(2, new ListNode(6)))))));
            ListNode result1 = ReverseList(head1);
            PrintLinkedList(result1); 

            ListNode head2 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            ListNode result2 = ReverseList(head2);
            PrintLinkedList(result2); 

            ListNode head3 = new ListNode(1);
            ListNode result3 = ReverseList(head3);
            PrintLinkedList(result3); 
        }
    }
}
