using System;

namespace Week4task_With_Metods_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            /*
        * asagida verilen arrayin elementlerini artan sira ile
        * ekrana cap edin
        *
        * qeyd : manual edilecek/ hazir methodlarsiz 
        * int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };
        */


            //int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };
            //foreach (int item in Metod.Myshort(intArray))
            //    Console.WriteLine(item);
            #endregion

            #region 2
            /*
             * asagida verilen arrayin elementlerini azalan sira ile
             * ekrana cap edin
             *
             * qeyd : manual edilecek/ hazir methodlarsiz
             */
            //int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };



            //int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };

            //foreach (int item in Metod.Myreshort(intArray))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3

            // /*
            // * asagida verilen arrayin elementlerini tersine duzerek
            // * ekrana cap edin
            // *
            // * qeyd : manual edilecek/ hazir methodlarsiz
            // */
            //// int[] arr = { 5, 6, 9, 12, 15, 7, 3, 20, 14, 36, 24 };

            // int[] arr = { 5, 6, 9, 12, 15, 7, 3, 20, 14, 36, 24 };

            // Console.WriteLine("Verilen array");
            // foreach (var item in arr)
            // {

            //     Console.Write(item + "  ");
            // }
            // Console.WriteLine("");
            // Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            // Console.WriteLine("Cevrilmis array");
            // foreach (var item in Metod.Myreverse(arr))
            // {

            //     Console.Write(item + "  ");
            // }
            #endregion

            #region 4
            /*
      * istifadeci bankomatdan cixarmaq istediyi meblegi daxil edir(sonsuz sayda, emeliyyati dayandirmagida nezere alin).
      * daxil edilen meblege uygun console-a eskinaslari sayi ile cap edirik.
      *
      * eskinaslar : 200, 100, 50, 20, 10, 5, 1
      *
      * meselen daxil edilen pul miqdari 45 dir:
      * 2 eded 20 azn
      * 1 eded 5 azn
      *
      */
            //-------- brinci hell
            //while (true)
            //{
            //    Console.WriteLine("Bankomatda Olan Esginazlar : (200 , 100 , 50 , 20 , 10 , 5 , 1)");
            //    Console.WriteLine("-------------------------------- ");
            //    Console.Write("Pulu daxil edin : ");
            //    int money = Convert.ToInt32(Console.ReadLine());
            //    Metod.Cash(money);
            //    Console.WriteLine("Cıxmaq üçün X Davam etmek üçün D ");
            //    if (Console.ReadLine().ToLower() == "x")
            //    {
            //        break;
            //    }
            //}
            #endregion

            #region 5
            /*
            * 1-10 qeder tek ededlerin kublarinin cemini yazin.
            */

            //int[] arr = new int[] {1,2,3,4,5,6,7,8,9,10 };
            //Console.WriteLine("Netice: " + Metod.Sum(arr));
            #endregion

            #region 6
            /*
             * dogum tarixini daxil eden istifedecinin
             * yasini hesablayib ekrana cap edin
             */
            //Console.Write("Dogum ilini daxil et :");

            //decimal inyear = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Dogum ayini daxil et :");
            //decimal inmonth = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Dogum gununu daxil et :");
            //decimal inday = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("sizin yasiniz: " + Metod.Birthday(inyear,inmonth,inday));

            #endregion

            #region 7

            /*
 * istifadeci terefinden daxil edilen iki musbet ededin hasilini vurma emeliyyati ile
 * deyil toplama emeliyyati ile ekrana cap edin.
 */
            //Console.Write("Brinici ededi daxil et : ");
            //decimal number1 = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Ikinici ededi daxil et : ");
            //decimal number2 = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Netice : " + Metod.Total(number1,number2));
            #endregion
        }
    }
}
