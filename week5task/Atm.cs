using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace week5task
{

    class Atm
    {
        public static int pul = 1000;
        public static Hashtable cashdate = new Hashtable();
        public static bool Login(int pin)
        {
            int log = 0;
            int[] pinArray = new int[] { 2312, 7665, 8712, 1923, 9987 };
            foreach (int item in pinArray)
            {
                if (item == pin) { log++; }
            }
            if (log > 0) return true;
            else return false;
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("MENU");
            Console.WriteLine("Negd pulun verilmesi üçün: 1");
            Console.WriteLine("Balansı yoxlamaq üçün : 2");
            Console.WriteLine("Balansdan cixaris üçün : 3");
            Console.WriteLine("--------------------------");
        }

        public static void Balance()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Sizin balansınızda {0} Azn var.", pul);
            Console.WriteLine("--------------------------");
        }

        public static void Cashout()
        {
            int cash;
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Min mebleg : 1 , Max mebleg : 1000");
            Console.Write("Meblegi daxil edin : ");
            cash = check(Console.ReadLine());
            if (cash > 0 && cash < 1000)
            {

                int[] cashout = new int[] { 100, 50, 20, 10, 5, 1 };
                if (pul >= cash)
                {
                    string date = DateTime.Now.ToString();
                    cashdate.Add(date, cash);
                    pul = pul - cash;
                    for (int i = 0; i < cashout.Length; i++)
                    {
                        if (cash >= cashout[i]) { Console.WriteLine(cash / cashout[i] + " Eded " + cashout[i] + " Azn"); cash = cash % cashout[i]; }
                    }
                    Console.WriteLine("--------------------------");
                }
                else Console.WriteLine("Daxil etdiyiniz mebleg balansinizda yoxdur");


            }
            else Console.WriteLine("Daxil etdiyiniz mebleg yalnisdir");
        }





        public static void Cıxarıs()
        {


            Console.WriteLine("--------------------------");
            foreach (var item in cashdate.Keys)
            {
                Console.WriteLine("Pulun cixarilma tarixi : {0}", item);
                Console.WriteLine("Cixarilan pulun meblegi : {0}", cashdate[item]);
            }
            Console.WriteLine("--------------------------");


        }

        public static int check(string value)
        {
            int result = 0;
            foreach (char item in value)
            {
                if (char.IsDigit(item) != true)
                {
                    result++;

                }
            }
            if (result == 0) return Convert.ToInt32(value);
            else return -1;

        }
    }
}

