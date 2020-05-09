using System;
/*
 给定一个整数类型的数组 nums，请编写一个能够返回数组“中心索引”的方法。
我们是这样定义数组中心索引的：数组中心索引的左侧所有元素相加的和等于右侧所有元素相加的和。
如果数组不存在中心索引，那么我们应该返回 -1。如果数组有多个中心索引，那么我们应该返回最靠近左边的那一个。
示例 1:
输入: 
nums = [1, 7, 3, 6, 5, 6]
输出: 3
解释: 
索引3 (nums[3] = 6) 的左侧数之和(1 + 7 + 3 = 11)，与右侧数之和(5 + 6 = 11)相等。
同时, 3 也是第一个符合要求的中心索引。
示例 2:
输入: 
nums = [1, 2, 3]
输出: -1
解释: 
数组中不存在满足此条件的中心索引。
说明:
nums 的长度范围为 [0, 10000]。
任何一个 nums[i] 将会是一个范围在 [-1000, 1000]的整数。
*/
namespace _1.寻找数组的中心索引
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 4, 3, 6, 2, 6 };
            Program p = new Program();
            int num = p.PivotIndex(s);
            Console.WriteLine("中心索引为：" + num);
        }

        public int PivotIndex(int[] nums)
        {
            int length = nums.Length;
            int leftcount = 0;
            int rightcount = 0;
            for (int i = 0; i < length; i++)
            {
                //第一个值 和 最后一个值  需要判断 另外一边是否为0 即可
                if (i == 0)
                {
                    rightcount = 0;
                    for (int j = 1; j < length; j++)
                    {
                        rightcount += nums[j];
                    }
                    if (rightcount == 0)
                    {
                        return i;
                    }
                }

                if (i == length - 1)
                {
                    leftcount = 0;
                    for (int j = 0; j < length - 1; j++)
                    {
                        leftcount += nums[j];
                    }
                    if (leftcount == 0)
                    {
                        return i;
                    }
                }

                leftcount = 0;
                rightcount = 0;
                for (int l = 0; l < i; l++)
                {
                    leftcount += nums[l];
                }
                for (int r = i + 1; r < length; r++)
                {
                    rightcount += nums[r];
                }

                if (leftcount == rightcount)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
