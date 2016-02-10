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

    }

    public class TreeNode
    {
         public int val;
         public TreeNode left;
         public TreeNode right;
         public TreeNode(int x) { val = x; }
    }
}
