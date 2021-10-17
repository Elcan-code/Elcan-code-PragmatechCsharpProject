using System;
using System.Collections.Generic;
using System.Text;

namespace Week4task_With_Metods_
{
    class Metod
    {
        public static int[] Myshort(params int[] num)
        {
            int[] intArray2 = new int[num.Length];
            int value1, value2, index = -1, max = 0;

            for (value1 = num.Length - 1; value1 >= 0; value1--)
            {
                for (value2 = 0; value2 < num.Length; value2++)
                {
                    if (max < num[value2]) { max = num[value2]; index = value2; }

                }
                num[index] = 0;

                intArray2[value1] = max;
                index = -1;
                max = 0;
            }
            return intArray2;

        }

        public static int[] Myreshort(params int[] num)
        {
            int[] intArray2 = new int[num.Length];
            int value1, value2, index = -1, max = 0;

            for (value1 = 0; value1 < num.Length; value1++)
            {
                for (value2 = 0; value2 < num.Length; value2++)
                {
                    if (max < num[value2]) { max = num[value2]; index = value2; }

                }
                num[index] = 0;

                intArray2[value1] = max;
                index = -1;
                max = 0;
            }
            return intArray2;
        }

        public static int[] Myreverse(params int[] arr)
        {
            int length = arr.Length;
            int[] arr2 = new int[length];
            int j = length;
            for (int i = 0; i < length; i++)
            {
                arr2[j - 1] = arr[i];
                j--;
            }
            return arr2;
        }



        public static void Cash(int money)
        {
            int[] cash = new int[] { 200, 100, 50, 20, 10, 5, 1 };
            Console.WriteLine("-------------------------------- ");
            foreach (int item in cash)
            {
                if (money >= item)
                {
                    Console.WriteLine(money / item + " Eded " + item + " Manat");
                    money = money % item;
                }
            }
            Console.WriteLine("-------------------------------- ");
        }

        public static double Sum(params int[] arr)
        {
            double value = 0;
            for (int i = 0; i <= 9; i += 2)
            {
                value += Math.Pow(arr[i], 3);
            }
            return value;
        }
        public static decimal Birthday(decimal inyear, decimal inmonth, decimal inday)
        {
            decimal day = 5;
            decimal month = 4;
            decimal year = 2021;

            if (inday < day)
            {


                if (inmonth < month)
                {
                    year = year - inyear;
                }
                else
                {
                    year = year - inyear - 1;
                }
            }
            else
            {
                if (inmonth < month)
                {
                    year = year - inyear - 1;
                }
                else
                {
                    year = year - inyear - 1;
                }
            }
            return year;
        }
        public static decimal Total(decimal number1, decimal number2)
        {
            decimal value = 0;
            if (number1 > number2)
            {
                for (int i = 1; i <= number2; i++)
                {
                    value += number1;
                }

            }
            else
            {
                for (int i = 1; i <= number2; i++)
                {
                    value += number1;
                }
            }
            return value;
        }



    }
}
