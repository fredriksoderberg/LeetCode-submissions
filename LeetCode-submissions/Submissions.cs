using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_submissions
{
    static class Submissions
    {
        static public bool CanWinNim(int i)
        {
            if (i == 0)
                return false;
            else if (i >= 1 || i <= 3)
                return true;
            else
                return (CanWinNim(i - 3) );

        }

    }
}
