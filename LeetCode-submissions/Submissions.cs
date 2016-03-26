using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

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
                if (c == '1')
                {
                    count++;
                }
            }

            return count;
        }

        public static int ClimbStairs(int n)
        {
            int sum = 0, a = 1, b = 2;
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 2;
            }
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    sum = a + b;
                    a = b;
                    b = sum;
                }
            }

            return sum;
        }

        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode currentNode = head;

            while (currentNode.next != null)
            {

                if (currentNode.val == currentNode.next.val)
                {
                    currentNode.next = currentNode.next.next;
                }
                else
                {
                    currentNode = currentNode.next;
                }


            }

            return head;
        }

        public static bool IsUgly(int num)
        {

            if (num <= 0)
                return false;

            if (num == 1)
                return true;

            while (num > 1)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                    continue;
                }
                if (num % 3 == 0)
                {
                    num = num / 3;
                    continue;
                }
                if (num % 5 == 0)
                {
                    num = num / 5;
                    continue;
                }
                return false;
            }

            return true;
        }

        public static bool IsHappy(int n)
        {
            char[] digits = n.ToString().ToCharArray();
            double sum = int.MaxValue;

            while (sum > 9)
            {

                sum = 0;

                foreach (char c in digits)
                {
                    sum += Math.Pow((c - 48), 2);
                }

                digits = sum.ToString().ToCharArray();
            }

            if (sum == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool IsPowerOfThree(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            while (n % 3 == 0 || n == 1)
            {
                if (n == 1)
                {
                    return true;
                }
                n /= 3;
            }
            return false;
        }

        public static bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            return (((long)int.MaxValue + 1) % n == 0) ? true : false;
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode current = l1;
            ListNode head = current;
            ListNode temp = null;


            while (l1 != null || l2 != null)
            {
                if (l1 != null && l2 != null)
                {
                    if (l1.val <= l2.val)
                    {
                        current.next = l1;
                        l1 = l1.next;
                    }
                    else
                    {
                        current = l2;
                        l2 = l2.next;
                    }
                }
                else if (l1 != null)
                {
                    current = l1;
                    l1 = l1.next;
                }
                else
                {
                    current = l2;
                    l2 = l2.next;
                }

                current = current.next;
            }

            return head;
        }

        public static bool IsBalanced(TreeNode root)
        {

            if (root == null)
            {
                return true;
            }

            if (Math.Abs(MaxDepth(root.left) - MaxDepth(root.right)) > 1)
            {
                return false;
            }


            return IsBalanced(root.left) && IsBalanced(root.right);

        }

        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            if (IsSameTree(InvertTree(root.left), root.right))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Rob(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            else if (nums.Length == 1)
            {
                return nums[0];
            }
            else if (nums.Length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }

            int[] max = new int[nums.Length];

            max[0] = nums[0];
            max[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                max[i] = Math.Max(nums[i] + max[i - 2], max[i - 1]);
            }

            return max[nums.Length - 1];
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int count = 0, temp = 0;

            for (int i = 0; i < nums.Length - count; i++)
            {
                if (nums[i] == val)
                {
                    while (nums[nums.Length - 1 - count] == val && (nums.Length - 1 - count > i))
                    {
                        count++;
                    }
                    temp = nums[nums.Length - 1 - count];
                    nums[nums.Length - 1 - count] = val;
                    nums[i] = temp;
                    count++;
                }
            }

            return nums.Length - count;
        }

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 1;
            }

            int current = int.MinValue, count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != current)
                {
                    current = nums[i];
                    nums[count] = current;
                    count++;
                }
            }

            return count;

        }

        public static int[] PlusOne(int[] digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[digits.Length - i - 1] != 9)
                {
                    digits[digits.Length - i - 1] += 1;
                    break;
                }
                else
                {
                    if (i != digits.Length - 1)
                    {
                        digits[digits.Length - i - 1] = 0;
                    }
                    else
                    {
                        digits[digits.Length - i - 1] = 0;
                        int[] extradigit = new int[digits.Length + 1];
                        extradigit[0] = 1;
                        Array.Clear(extradigit, 1, extradigit.Length - 1);
                        return extradigit;
                    }
                }
            }

            return digits;

        }

        public static IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> pascallist = new List<IList<int>>();
            var currentrow = new List<int>();
            var previousrow = new List<int>();

            var one = new List<int>() { 1 };

            var two = new List<int>() { 1, 1 };

            if (numRows >= 1)
            {
                pascallist.Add(one);
                previousrow.AddRange(one);
            }

            if (numRows >= 2)
            {
                pascallist.Add(two);
                previousrow.Clear();
                previousrow.AddRange(two);
            }

            if (numRows >= 3)
            {
                for (int curRow = 3; curRow <= numRows; curRow++)
                {
                    for (int i = 0; i < curRow; i++)
                    {
                        if (i == 0 || i == curRow - 1)
                        {
                            currentrow.Add(1);
                        }
                        else
                        {
                            currentrow.Add(previousrow[i] + previousrow[i - 1]);
                        }
                    }

                    pascallist.Add(new List<int>(currentrow));
                    previousrow.Clear();
                    previousrow.AddRange(currentrow);
                    currentrow.Clear();
                }
            }
            return pascallist;
        }

        public static int TrailingZeroes(int n)
        {
            int rs = 0;
            while (n != 0)
            {
                rs += (n / 5);
                n /= 5;
            }
            return rs;
        }

        public static IList<int> GetRow(int rowIndex)
        {
            var currentrow = new List<int>();
            var previousrow = new List<int>();
            var one = new List<int>() { 1 };
            var two = new List<int>() { 1, 1 };

            if (rowIndex >= 0)
            {
                currentrow.AddRange(one);
                previousrow.AddRange(one);
            }

            if (rowIndex >= 1)
            {
                currentrow.Clear();
                currentrow.AddRange(two);
                previousrow.Clear();
                previousrow.AddRange(two);
            }

            if (rowIndex >= 2)
            {
                for (int curRow = 2; curRow <= rowIndex; curRow++)
                {
                    currentrow.Clear();

                    for (int i = 0; i <= curRow; i++)
                    {
                        if (i == 0 || i == curRow)
                        {
                            currentrow.Add(1);
                        }
                        else
                        {
                            currentrow.Add(previousrow[i] + previousrow[i - 1]);
                        }
                    }

                    previousrow.Clear();
                    previousrow.AddRange(currentrow);

                }
            }
            return currentrow;
        }

        public static bool IsPalindrome(int x)
        {
            char[] digits = x.ToString().ToCharArray();

            for (int i = 0; i < digits.Length / 2; i++)
            {
                if (digits[i] != digits[digits.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }

            if (sum - root.val == 0 && root.left == null && root.right == null)
            {
                return true;
            }

            if (sum - root.val != 0 && root.left == null && root.right == null)
            {
                return false;
            }

            return (root.left != null) ? HasPathSum(root.left, sum - root.val) : false || (root.right != null) ? HasPathSum(root.right, sum - root.val) : false;
        }

        public static int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else if (root.left == null && root.right == null)
            {
                return 1;
            }
            else
            {
                return Math.Min(root.left != null ? int.MaxValue + MinDepth(root.left) : int.MaxValue, root.right != null ? 1 + MinDepth(root.right) : int.MaxValue);
            }
        }

        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode curA = headA;
            ListNode curB = headB;
            int lengthA = 0, lengthB = 0;

            if(headA == null || headB == null)
            {
                return null;
            }

            while(curA != null)
            {
                lengthA++;
                curA = curA.next;
            }

            while(curB != null)
            {
                lengthB++;
                curB = curB.next;
            }

            curA = headA;
            curB = headB;

            if(lengthA > lengthB)
            {
                for(int i = 1; i <= lengthA - lengthB; i++)
                {
                    curA = curA.next;
                }
            }
            else if(lengthB > lengthA)
            {
                for (int i = 1; i <= lengthB - lengthA; i++)
                {
                    curB = curB.next;
                }
            }

            while(curA != null || curB != null)
            {
                if(curA == curB)
                {
                    return curA;
                }
                else
                {
                    curA = curA.next;
                    curB = curB.next;
                }
            }

            return null;

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

    public class Queue
    {

        public Stack stack = new Stack();

        // Push element x to the back of queue.
        public void Enqueue(int x)
        {
            Stack temp = new Stack();

            while (stack.Count > 0)
            {
                temp.Push(stack.Pop());
            }

            temp.Push(x);

            while (temp.Count > 0)
            {
                stack.Push(temp.Pop());
            }

        }

        // Removes the element from front of queue.
        public void Pop()
        {
            stack.Pop();
        }

        // Get the front element.
        public int Peek()
        {
            return (int)stack.Peek();
        }

        // Return whether the queue is empty.
        public bool Empty()
        {
            return (stack.Count > 0) ? false : true;
        }
    }

    public class Stack
    {

        Queue<int> queue = new Queue<int>();
        // Push element x onto stack.
        public void Push(int x)
        {
            int temp = 0;

            queue.Enqueue(x);

            for (int i = 1; i < queue.Count; i++)
            {
                temp = queue.Dequeue();
                queue.Enqueue(temp);
            }
        }

        // Removes the element on top of the stack.
        public void Pop()
        {
            queue.Dequeue();
        }

        // Get the top element.
        public int Top()
        {
            return queue.Peek();
        }

        // Return whether the stack is empty.
        public bool Empty()
        {
            return queue.Count == 0 ? true : false;
        }
    }
}
