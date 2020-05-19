using System;
using System.Collections;
/*
给定一个含有 M x N 个元素的矩阵（M 行，N 列），请以对角线遍历的顺序返回这个矩阵中的所有元素，对角线遍历如下图所示。

示例:
输入:
[
[ 1, 2, 3 ],
[ 4, 5, 6 ],
[ 7, 8, 9 ]
]

输出:  [1,2,4,7,5,3,6,8,9]

说明:
给定矩阵中的元素总数不会超过 100000 。

分析：实际上是找规律 对规律的不同情况进行处理
连线：分为右上和左下
右上：最右边：下一个点  正下方
      最上边：下一个点  正右方
左下：最左边：下一个点  正下方
      最下边：下一个点  正右方
*/
namespace _4.对角线遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][]{
                new int[]{ 1, 2, 3 },
                new int[]{ 4, 5, 6 },
                new int[]{ 7, 8, 9 }
            };
            Program p = new Program();
            int[] numArray = p.FindDiagonalOrder(matrix);
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write(numArray[i] + "-");
            }
        }

        public int[] FindDiagonalOrder(int[][] matrix)
        {
            //如果是空数组直接返回一个空数组
            if (matrix.Length == 0 || matrix == null)
            {
                return new int[] { };
            }

            int m = matrix.Length;     //行数
            int n = matrix[0].Length;  //列数
            int[] ans = new int[m * n];//新建数组，大小为二维数组元素个数
            int Flag = 0;//flag是标志位，0代表右上，1代表左下
            //a、b是当前遍历点的行列坐标，a为行，b为列
            int rowIndex = 0; 
            int colIndex = 0;

            for (int i = 0; i < m * n; i++)
            {
                //每一次遍历先保存该点的数值
                ans[i] = matrix[rowIndex][colIndex];
                //遍历到了最后一个点，就退出循环
                if (rowIndex == m - 1 && colIndex == n - 1)
                {
                    break;
                }

                if (Flag == 0)
                {//方向是右上
                    if (colIndex == n - 1)
                    {//当前遍历点在右边界上
                        ++rowIndex;
                        Flag = 1;
                    }
                    else if (rowIndex == 0)
                    {//当前点在上边界且不在右边界上
                        ++colIndex;
                        Flag = 1;
                    }
                    else
                    {//当前点不在边界上
                        --rowIndex;
                        ++colIndex;
                    }
                }
                else
                {//方向是左下
                    if (rowIndex == m - 1)
                    {//当前点在下边界上
                        ++colIndex;
                        Flag = 0;
                    }
                    else if (colIndex == 0)
                    {//当前点在左边界上且不在下边界上
                        ++rowIndex;
                        Flag = 0;
                    }
                    else
                    {//当前点不在边界上
                        ++rowIndex;
                        --colIndex;
                    }
                }
            }
            return ans;
        }
    }
}
