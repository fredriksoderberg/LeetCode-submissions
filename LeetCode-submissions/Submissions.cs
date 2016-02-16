using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_submissions
{
    static class Submissions
    {

        public static bool CanWinNim(int n)
        {
            if (n % 4 == 0)
                return false;
            else
                return true;
        }

        public static int AddDigits(int num)
        {
            if (num < 10)
                return num;
            else
                return AddDigits(AddDigitsSubSum(num));
        }

        public static int AddDigitsSubSum(int num)
        {
            if (num < 10)
                return num;
            else
                return AddDigitsSubSum(num % 10) + AddDigitsSubSum(num / 10);
        }

        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else if (root.left == null && root.right == null)
                return 1;
            else
                return System.Math.Max(MaxDepth(root.right) + 1, MaxDepth(root.left) + 1);
        }

        public static void DeleteNode(ListNode node)
        {
            if (node.next == null)
                return;
            else
            {
                node.val = node.next.val;
                node.next = node.next.next;
            }
        }

        public static TreeNode InvertTree(TreeNode root)
        {
            InvertTreeFromTopNode(root);
            return root;
        }

        public static void InvertTreeFromTopNode(TreeNode root)
        {
            if (root == null)
                return;

            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            InvertTreeFromTopNode(root.left);
            InvertTreeFromTopNode(root.right);
        }

        public static void MoveZeroes(int[] nums)
        {

            int temp = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    for (var j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] != 0)
                        {
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            break;
                        }

                    }
                }
            }
        }

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {

            if (p == null && q == null)
                return true;

            if ((p == null && q != null) || (p != null && q == null))
            {
                return false;
            }

            if (p.val != q.val)
                return false;

            return (IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right));
        }

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var sList = s.ToList<char>();
            var tList = t.ToList<char>();

            foreach (char c in sList)
            {
                if (tList.Contains(c))
                {
                    tList.Remove(c);
                }
            }

            if (tList.Count == 0)
                return true;
            else
                return false;


        }

        public static int TitleToNumber(string s)
        {
            char[] charsInColumnName = s.ToCharArray();
            int columnNumber = 0;

            for (int i = 0; i < charsInColumnName.Length; i++)
            {
                columnNumber += (charsInColumnName[charsInColumnName.Length - 1 - i] - 64) * (int)System.Math.Pow(26, i);
            }

            return columnNumber;
        }

        public static int MajorityElement(int[] nums)
        {
            System.Array.Sort(nums);

            return nums[nums.Length / 2];
        }

        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;

            if (root.val >= p.val && root.val <= q.val)
                return root;

            if (root.val < p.val && root.val < q.val)
                return LowestCommonAncestor(root.right, p, q);
            if (root.val > p.val && root.val > q.val)
                return LowestCommonAncestor(root.left, p, q);

            return root;


        }
        public static ListNode OddEvenList(ListNode head)
        {

            if (head == null)
                return null;

            ListNode currentOddNode = head;
            ListNode currentEvenNode = head.next;
            ListNode evenNodeHead = head.next;

            while (currentOddNode.next != null)
            {
                if (currentOddNode.next.next != null)
                {
                    currentOddNode.next = currentOddNode.next.next;
                    currentOddNode = currentOddNode.next;
                }
                else
                {
                    currentOddNode.next = null;

                }

                if (currentEvenNode.next != null)
                {
                    if (currentEvenNode.next.next != null)
                    {
                        currentEvenNode.next = currentEvenNode.next.next;
                        currentEvenNode = currentEvenNode.next;
                    }
                    else
                    {
                        currentEvenNode.next = null;
                    }

                }


            }

            currentOddNode.next = evenNodeHead;

            return head;
        }

        public static int HammingWeight(uint n)
        {
            string binary = Convert.ToString(n, 2);
            char[] binaryArray = binary.ToCharArray();

            int count = 0;

            foreach (char c in binaryArray)
            {
                if(c == '1')
                {
                    count++;
                }
            }

            return count;
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
