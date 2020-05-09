using System;
/*
 在一个给定的数组nums中，总是存在一个最大元素 。
查找数组中的最大元素是否至少是数组中每个其他数字的两倍。
如果是，则返回最大元素的索引，否则返回-1。
示例 1:
输入: nums = [3, 6, 1, 0]
输出: 1
解释: 6是最大的整数, 对于数组中的其他整数,
6大于数组中其他元素的两倍。6的索引是1, 所以我们返回1.
 
示例 2:
输入: nums = [1, 2, 3, 4]
输出: -1
解释: 4没有超过3的两倍大, 所以我们返回 -1.
 
提示:
nums 的长度范围在[1, 50].
每个 nums[i] 的整数范围在 [0, 100].
*/
namespace _2.至少是其他数字两倍的最大数
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 4, 3, 15, 2, 6 };
            Program p = new Program();
            int num = p.DominantIndex(s);
            Console.WriteLine("输出的数字为：" + num);
        }

        public int DominantIndex(int[] nums)
        {
            int FirstMax = 0;
            int FirstMaxIndex = 0;
            int SecondMax = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (0 == i)
                {
                    FirstMax = nums[i];
                    FirstMaxIndex = i;
                    continue;
                }
                if (FirstMax < nums[i])
                {
                    SecondMax = FirstMax;
                    FirstMax = nums[i];
                    FirstMaxIndex = i;
                }
                else
                { //拿当前值 和 第二大值 做比较就好
                    if (SecondMax < nums[i])
                    {
                        SecondMax = nums[i];
                    }
                }
            }

            if (FirstMax >= SecondMax * 2)
            {
                return FirstMaxIndex;
            }

            return -1;
        }
    }
}
