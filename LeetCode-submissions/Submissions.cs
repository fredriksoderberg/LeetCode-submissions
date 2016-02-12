using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_submissions
{
    static class Submissions
    {

        static public bool CanWinNim(int n)
        {
            if (n % 4 == 0)
                return false;
            else
                return true;
        }

        static public int AddDigits(int num)
        {
            if (num < 10)
                return num;
            else
                return AddDigits(AddDigitsSubSum(num));
        }

        static public int AddDigitsSubSum(int num)
        {
            if (num < 10)
                return num;
            else
                return AddDigitsSubSum(num % 10) + AddDigitsSubSum(num / 10);
        }

        static public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else if (root.left == null && root.right == null)
                return 1;
            else
                return System.Math.Max(MaxDepth(root.right) + 1, MaxDepth(root.left) + 1);
        }

        static public void DeleteNode(ListNode node)
        {
            if (node.next == null)
                return;
            else
            {
                node.val = node.next.val;
                node.next = node.next.next;
            }
        }

        static public TreeNode InvertTree(TreeNode root)
        {
            InvertTreeFromTopNode(root);
            return root;
        }

        static public void InvertTreeFromTopNode(TreeNode root)
        {
            if (root == null)
                return;

            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            InvertTreeFromTopNode(root.left);
            InvertTreeFromTopNode(root.right);
        }

        static public void MoveZeroes(int[] nums)
        {

            int numberOfZeros = 0;

            for (int i = 0, j = 0; j < nums.Length; i++, j++)
            {
                if (nums[i] == 0)
                {
                    j++;
                    numberOfZeros++;
                }

                nums[i] = nums[j];

            }

            for(int i = 1; i <= numberOfZeros; i++)
            {
                nums[nums.Length - i] = 0;
            }
        }




    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

    }
}
