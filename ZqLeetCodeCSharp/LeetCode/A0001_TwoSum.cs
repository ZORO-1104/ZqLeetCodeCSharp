using System;
using System.Collections.Generic;
using System.Text;

namespace ZqLeetCodeCSharp.LeetCode
{
    /*
     * @lc app=leetcode.cn id=1 lang=csharp
     *
     * [1] 两数之和
     */

    // @lc code=start
    public class A0001_Solution
    {
        //暴力破解
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (target == nums[i] + nums[j])
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { };
        }
    }
    // @lc code=end
}
