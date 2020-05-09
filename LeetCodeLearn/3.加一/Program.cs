using System;
/*
 给定一个由整数组成的非空数组所表示的非负整数，在该数的基础上加一。
最高位数字存放在数组的首位， 数组中每个元素只存储单个数字。
你可以假设除了整数 0 之外，这个整数不会以零开头。
示例 1:
输入: [1,2,3]
输出: [1,2,4]
解释: 输入数组表示数字 123。
示例 2:
输入: [4,3,2,1]
输出: [4,3,2,2]
解释: 输入数组表示数字 4321。
*/
namespace _3.加一
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = { 0 };
            //int[] s = { 9 };
            //int[] s = { 1, 4, 3, 6, 2, 9 };
            //int[] s = { 9, 9, 9, 9, 9, 9 };  //极端情况
            Program p = new Program();
            int[] numArray = p.PlusOne(s);
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write(numArray[i] + "-");
            }
        }

        public int[] PlusOne(int[] digits)
        {
            int Length = digits.Length;
            int[] answer = Recursive(digits, Length);
            return answer;
        }

        public int[] Recursive(int[] digits, int Length)
        {
            int lastNum = digits[Length - 1];
            lastNum++;
            if (lastNum < 10)
            {
                digits[Length - 1] = lastNum;
                return digits;
            }
            else
            {
                //当前位置为0 下一位加1
                digits[Length - 1] = 0;
                Length--;
                if (Length != 0)
                {
                    return Recursive(digits, Length);
                }
                else
                {
                    //这里表示digits的第一个元素 相加为10  需要进一位  但是digits空间不够 需要重新创建一个数组存储  并把digits数据一一赋值过去
                    int[] digitsTemp = new int[digits.Length + 1];
                    for (int i = 0; i < digits.Length; i++)
                    {
                        digitsTemp[i + 1] = digits[i];
                    }
                    digitsTemp[0] = 0;
                    Length++;
                    return Recursive(digitsTemp, Length);
                }

            }
        }
    }
}
