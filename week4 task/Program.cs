using System;

namespace week4_task
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1.
            /*
             * asagida verilen arrayin elementlerini artan sira ile
             * ekrana cap edin
             *
             * qeyd : manual edilecek/ hazir methodlarsiz
             */
            //int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };

            //int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };
            //int[] intArray2 = new int[intArray.Length];
            //int value1,value2,index=-1, max = 0;

            //for (value1 = intArray.Length-1; value1 >= 0; value1--)
            //{
            //    for (value2 = 0; value2 < intArray.Length; value2++)
            //    {
            //        if (max < intArray[value2]) { max = intArray[value2]; index = value2; }

            //    }
            //    intArray[index] = 0;

            //    intArray2[value1] = max;
            //    index = -1;
            //    max = 0;
            //}
            //foreach(var item in intArray2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2.
            /*
             * asagida verilen arrayin elementlerini azalan sira ile
             * ekrana cap edin
             *
             * qeyd : manual edilecek/ hazir methodlarsiz
             */
            //int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };



            //int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };
            //int[] intArray2 = new int[intArray.Length];
            //int value1, value2, index = -1, max = 0;

            //for (value1=0;value1<intArray.Length; value1++)
            //{
            //    for (value2 = 0; value2 < intArray.Length; value2++)
            //    {
            //        if (max < intArray[value2]) { max = intArray[value2]; index = value2; }

            //    }
            //    intArray[index] = 0;

            //    intArray2[value1] = max;
            //    index = -1;
            //    max = 0;
            //}
            //foreach (var item in intArray2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. geriden geriden
            /*
             * asagida verilen arrayin elementlerini tersine duzerek
             * ekrana cap edin
             *
             * qeyd : manual edilecek/ hazir methodlarsiz
             */
            //int[] arr = { 5, 6, 9, 12, 15, 7, 3, 20, 14, 36, 24 };
            //int length;
            //int[] arr = { 5, 6, 9, 12, 15, 7, 3, 20, 14, 36, 24 };
            //length = arr.Length;
            //int[] arr2 = new int[length];
            //int j = length;
            //for(int i = 0; i < length;i++)
            //{
            //    arr2[j - 1] = arr[i];
            //    j--;
            //}
            //Console.WriteLine("Verilen array");
            //foreach (var item in arr)
            //{

            //    Console.Write(item + "  ");
            //}
            //Console.WriteLine("");
            //Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            //Console.WriteLine("Cevrilmis array");
            //foreach (var item in arr2)
            //{

            //    Console.Write(item + "  ");
            //}


            #endregion

            #region 4. para pul el cirki
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
             while (true)
            {
                Console.WriteLine("Bankomatda Olan Esginazlar : (200 , 100 , 50 , 20 , 10 , 5 , 1)");
                Console.WriteLine("-------------------------------- ");
                int[] cash = new int[] { 200, 100, 50, 20, 10, 5, 1 };
                Console.Write("Pulu daxil edin : ");
                int money = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine("Cıxmaq üçün X Davam etmek üçün D ");
                if (Console.ReadLine().ToLower() == "x")
                {
                    break;
                }
            }



             //----------  ikinci hell




            //   string value; int result= 0;
            //int cash1 = 0, cash2 = 0, cash3 = 0, cash4 = 0, cash5 = 0, cash6 = 0; ;
            //   Console.WriteLine("Eskinazlar : 1 , 5 , 10 , 20 , 50 , 100 , 200 Emeliyyati sonlandirmaq ucun E daxil edin ");
            //   while (true)
            //   {
            //          Console.Write("Meblegi daxil edin : ");
            //       value=Console.ReadLine();
            //       if (value == "E") { break; }
            //       else result = Convert.ToInt32(value);
            //       if (result >= 200)
            //       {
            //           cash1 = result / 200;
            //           result -= cash1 * 200;
            //           Console.WriteLine(cash1 + " Eded 200 manat");
            //       }
            //       if (result>=100) {
            //           cash2 = result / 100;
            //           result -= cash2 * 100;
            //           Console.WriteLine(cash2 + " Eded 100 manat");
            //       }
            //       if (result >= 50)
            //       {
            //           cash3 = result / 50;
            //           result -= cash3 * 50;
            //           Console.WriteLine(cash3 + " Eded 50 manat");
            //       }
            //       if (result >=10)
            //       {
            //           cash4 = result / 10;
            //           result -= cash4 * 10;
            //           Console.WriteLine(cash4 + " Eded 10 manat");
            //       }
            //       if (result >=5)
            //       {
            //           cash5 = result / 5;
            //           result -= cash5 * 5;
            //           Console.WriteLine(cash5 + " Eded 5 manat");
            //       }
            //       if (result >= 1 && result<5)
            //       {
            //           cash6 = result;
            //           Console.WriteLine(cash6 + " Eded 1 manat");

            //       }


            //   }
      

           







            #endregion

            #region 5. tek ededlerin kublari cemi
            /*
             * 1-10 qeder tek ededlerin kublarinin cemini yazin.
             */
            //double value=0;
            // for(int i = 1; i <= 10; i += 2)
            // {
            //     value+= Math.Pow(i, 3);
            // }
            // Console.WriteLine("Netice: " + value);
            #endregion

            #region 6. yas hesablanmasi
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

            //decimal day = 5;
            //decimal month = 4;
            //decimal year = 2021;

            //if (inday < day)
            //{


            //    if (inmonth < month)
            //    {
            //        year = year - inyear;
            //    }
            //    else
            //    {
            //        year = year - inyear-1;
            //    }
            //}
            //else
            //{
            //    if (inmonth < month)
            //    {
            //        year = year - inyear-1;
            //    }
            //    else
            //    {
            //        year = year - inyear - 1;
            //    }
            //}
            //Console.WriteLine("sizin yasiniz: " + year);
            #endregion

            #region 7.
            //Console.Write("Brinici ededi daxil et : ");
            //decimal number1 = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Ikinci ededi daxil et : ");
            //decimal number2 = Convert.ToDecimal(Console.ReadLine());
            //decimal value=0;
            //if (number1 > number2)
            //{
            //    for (int i = 1; i <= number2; i++)
            //    {
            //        value += number1;
            //    }

            //}
            //else
            //{
            //    for (int i = 1; i <= number2; i++)
            //    {
            //        value += number1;
            //    }
            //}
            //Console.WriteLine("Netice : "+value);
            #endregion
        }
    }
}
