using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_submissions
{
    class Program
    {
        static void Main(string[] args)
        {

            ListNode l1 = new ListNode(1);
            ListNode two = new ListNode(3);
            ListNode three = new ListNode(6);
            ListNode four = new ListNode(7);
            ListNode l2 = new ListNode(2);
            ListNode six = new ListNode(4);
            ListNode seven = new ListNode(6);
            ListNode eight = new ListNode(8);

            l1.next = two;
            two.next = three;
            three.next = four;
            //four.next = null;
            l2.next = six;
            six.next = seven;
            seven.next = eight;



            //ListNode newhead = Submissions.MergeTwoLists(l1, l2);

            //while (newhead != null)
            //{
            //    Console.Out.Write(newhead.val);
            //    newhead = newhead.next;
            //}

            MyQueue queue = new MyQueue();

            queue.Push(1);
            queue.Push(2);
            queue.Push(3);
            Console.Write(queue.Peek()); 
            
            Console.In.ReadLine();
        }
    }
}
