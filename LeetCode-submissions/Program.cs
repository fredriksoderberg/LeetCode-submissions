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

            string s = "anagram";
            string t = "nagaram";

            Console.Out.Write(Submissions.IsAnagram(s,t));
            Console.In.ReadLine();
        }
    }
}
