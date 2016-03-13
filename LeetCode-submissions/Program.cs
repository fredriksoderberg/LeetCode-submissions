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
           
            l2.next = six;
            six.next = seven;
            seven.next = eight;

            TreeNode t1 = new TreeNode(3);
            TreeNode t2 = new TreeNode(9);
            TreeNode t3 = new TreeNode(20);
            TreeNode t4 = new TreeNode(15);
            TreeNode t5 = new TreeNode(7);
            //TreeNode t6 = new TreeNode(6);
            //7TreeNode t7 = new TreeNode(7);
            //TreeNode t8 = new TreeNode(8);

            t1.left = t2;
            t1.right = t3;
            t3.left = t4;
            t3.right = t5;
            //t4.left = t7;
            //t3.right = t6;
            //t6.right = t8;

            int[] nums = new int[] { 9, 9 };

            Console.Write(Submissions.PlusOne(nums));
          
            Console.In.ReadLine();
        }
    }
}
