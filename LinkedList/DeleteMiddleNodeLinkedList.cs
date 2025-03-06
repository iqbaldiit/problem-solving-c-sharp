﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LinkedList
{
    //Source: https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/solutions/6503624/simple-best-solution-beats-100-by-iqbald-fqru/
    /*
     *  You are given the head of a linked list. Delete the middle node, and return the 
     *  head of the modified linked list. The middle node of a linked list of size n is 
     *  the ⌊n / 2⌋th node from the start using 0-based indexing, where ⌊x⌋ denotes the 
     *  largest integer less than or equal to x.
     *  
        For n = 1, 2, 3, 4, and 5, the middle nodes are 0, 1, 1, 2, and 2, respectively. 

        Example 1:
        Input: head = [1,3,4,7,1,2,6]
        Output: [1,3,4,1,2,6]
        Explanation:
        The above figure represents the given linked list. The indices of the nodes are written below.
        Since n = 7, node 3 with value 7 is the middle node, which is marked in red.
        We return the new list after removing this node. 
        
        Example 2:
        Input: head = [1,2,3,4]
        Output: [1,2,4]
        Explanation:
        The above figure represents the given linked list.
        For n = 4, node 2 with value 3 is the middle node, which is marked in red.

        Example 3:
        Input: head = [2,1]
        Output: [2]
        Explanation:
        The above figure represents the given linked list.
        For n = 2, node 1 with value 1 is the middle node, which is marked in red.
        Node 0 with value 2 is the only node remaining after removing node 1. 

        Constraints:
        The number of nodes in the list is in the range [1, 105].
        1 <= Node.val <= 105
     */


    //Definition for singly-linked list.
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
     
    public class DeleteMiddleNodeLinkedList
    {
        static ListNode DeleteMiddle(ListNode head)
        {

            if (head == null || head.next == null)
                return null;

            ListNode slow = head;
            ListNode fast = head;
            ListNode prev = null;

            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            if (prev != null)
            {
                prev.next = slow.next;
            }

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
            Console.WriteLine("["+sResult+"]");
        }
        public static void Execute()
        {
            ListNode head1 = new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(7, new ListNode(1, new ListNode(2, new ListNode(6)))))));
            ListNode result1 = DeleteMiddle(head1);
            PrintLinkedList(result1); // Output: [1, 3, 4, 1, 2, 6]

            ListNode head2 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            ListNode result2 = DeleteMiddle(head2);
            PrintLinkedList(result2); // Output: [1, 2, 4]

            ListNode head3 = new ListNode(2, new ListNode(1));
            ListNode result3 = DeleteMiddle(head3);
            PrintLinkedList(result3); // Output: [2]
        }
    }
}
