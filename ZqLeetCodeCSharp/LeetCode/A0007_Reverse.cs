using System;
using System.Collections.Generic;
using System.Text;

namespace ZqLeetCodeCSharp.LeetCode
{
    /*
     * @lc app=leetcode.cn id=7 lang=csharp
     *
     * [7] 整数反转
     */

    // @lc code=start
    public class A0007_Solution
    {
        public int Reverse(int x)
        {
            int ret = 0;

            checked
            {
                try
                {
                    while (x!=0)
                    {
                        ret = ret * 10 + x % 10;
                        x /= 10;
                    }
                }
                catch (Exception)
                {
                    ret = 0;
                }
            }

            return ret;
        }
    }
    // @lc code=end


}
