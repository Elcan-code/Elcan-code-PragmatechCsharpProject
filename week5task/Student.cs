using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace week5task
{
    class Student
    {




        public static int Check(string value)
        {
            int count = 0;
            if (string.IsNullOrWhiteSpace(value))
            {
                return 2;
            }
            else
                foreach (char item in value)
                {
                    if (char.IsDigit(item) == false) { count++; }

                }
            if (count > 0) return 0;
            else if (Convert.ToInt32(value) >= 0 && Convert.ToInt32(value) <= 100) return 1;
            else { return 0; }
        }

        public static int Average(string value1, string value2, string value3)
        {
            int average = 0;

            average = (Convert.ToInt32(value1) + Convert.ToInt32(value2) + Convert.ToInt32(value3)) / 3;
            return average;
        }
        public static bool Diplomisi(int result)
        {
            if (result >= 81)
            {
                return true;
            }
            else return false;
        }
        public static void Error()
        {
            Console.WriteLine("!Zehmet olmasa düzgün deyer daxil edin!");
        }
        public static void Print(string point1, string point2, string point3, int average, bool result, string fullname)
        {

            Console.WriteLine("------------------------------");
            Console.WriteLine("Ad Soyad : {0} ", fullname);
            Console.WriteLine("Netice 1 : {0}", point1);
            Console.WriteLine("Netice 2 : {0}", point2);
            Console.WriteLine("Netice 3 : {0}", point3);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Ortalama : {0}", average);
            if (result == true) Console.WriteLine("Diplom Iseine Dusdunuz.");
            else Console.WriteLine("Diplom Iseine Dusmediniz.");
            Console.WriteLine("------------------------------");
        }

    }
}
