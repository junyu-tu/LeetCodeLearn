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
            ArrayList numArray = p.FindDiagonalOrder(matrix);
            for (int i = 0; i < numArray.Count; i++)
            {
                Console.Write(numArray[i] + "-");
            }
        }

        public ArrayList FindDiagonalOrder(int[][] matrix)
        {
            if (matrix.Length == 0)
            {
                return new ArrayList(0);
            }
            int row = matrix.Length;
            int col = matrix[0].Length;
            ArrayList numArray = new ArrayList(); //创建一个满足空间的 数组
            //对角线的数量 是row+col-1
            //对角线diagonal 单数条 1 3 5...都是朝向右上角    双数条 2 4 6...都是朝向左下角
            //当diagonal<=col时,始终从0开始；
            //当diagonal>col时，每当diagonal+1，起始row也+1 也就是diagonal-col;
            //当diagonal=row时，应该就是跑到最后一个数了，row-1
            int diagonal = row + col - 1; //得到对角线
            int rowStart = 0;//开始的行下标
            int rowEnd = 0;  //结束的行下标
            for (int i = 1; i <= diagonal; i++)
            {
                //首先获取当前应该遍历的下标数据
                if (i <= col)
                {
                    rowStart = 0;
                }
                else
                {
                    rowStart = diagonal - col;
                }

                //也要判断下是不是到最后一个数了
                if (i >= row)
                {
                    rowEnd = row - 1;
                }
                else
                {
                    rowEnd = i;
                }

                //单数是右上  双数是左下
                if (i % 2 == 1)
                {
                    for (int j = rowEnd; j > rowStart; j--)
                    {
                        numArray.Add(matrix[j][i - j]);
                    }
                }
                else
                {
                    for (int j = rowStart; j < rowEnd; j++)
                    {
                        numArray.Add(matrix[j][i - j]);
                    }
                }

            }

            return numArray;
        }
    }
}
