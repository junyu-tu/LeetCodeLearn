﻿using System;
using System.Collections.Generic;
/*
给定一个包含 m x n 个元素的矩阵（m 行, n 列），请按照顺时针螺旋顺序，返回矩阵中的所有元素。

示例 1:
输入:
[
[ 1, 2, 3 ],
[ 4, 5, 6 ],
[ 7, 8, 9 ]
]
输出: [1,2,3,6,9,8,7,4,5]

示例 2:
输入:
[
[1, 2, 3, 4],
[5, 6, 7, 8],
[9,10,11,12]
]
输出: [1,2,3,4,8,12,11,10,9,5,6,7]
*/
namespace _5.螺旋矩阵
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public IList<int> SpiralOrder(int[][] matrix)
        {
            //如果是空数组直接返回一个空数组
            if (matrix.Length == 0 || matrix == null)
            {
                return new int[] { };
            }


            return null;
        }
    }
}
