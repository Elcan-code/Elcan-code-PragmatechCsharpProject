using System;

namespace yekun
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1 Bal Ortalamasinin Hesablanmasi
            int score1, score2, score3, average;
            Console.Write("Netice:");
            score1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            score2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            score3 = Convert.ToInt32(Console.ReadLine());
            average = (score1 + score2 + score3) / 3;
            var result = average >= 45 ? "YES" : "NO";
            Console.WriteLine(result);
            #endregion

            #region 2.Bal Ortalamasinin Hesablanmasi
            string adsoyad1;
            int a1, b1, c1, d1, e1;
            Console.Write("Ad Soyad:");
            adsoyad1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Netice:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            d1 = Convert.ToInt32(Console.ReadLine());
            e1 = (a1 + b1 + c1 + d1) / 4;
            Console.WriteLine();
            Console.WriteLine("Ortalama:" + c);
            #endregion

            #region 3.Bal Ortalamasinin Hesablanmasi
            string adsoyad;
            int a2, b2, c2, d2, e;
            Console.Write("Ad Soyad:");
            adsoyad = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Netice:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            c2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Netice:");
            d2 = Convert.ToInt32(Console.ReadLine());
            e = (a2 + b2 + c2 + d2) / 4;

            if (e > 100 || e < 0) { Console.WriteLine("Neticeleri Dogru Daxil Edin"); }
            else
            {
                Console.WriteLine(adsoyad);
                Console.WriteLine();
                Console.WriteLine(e);
                Console.WriteLine();
                Console.Write("Semestr Yekunu : ");
                if (e < 45)
                {
                    Console.WriteLine("qeyri - kafi Kece bilmediz");
                }
                else if (e >= 45 && e < 70)
                {
                    Console.WriteLine("Meqbul");
                }
                else if (e >= 70 && e < 90)
                {
                    Console.WriteLine("Yaxsi");
                }
                else if (e >= 90 && e <= 100)
                {
                    Console.WriteLine("Ela");
                }
            }

            #endregion

            #region while ile consoledan daxil edilen ededden geriye dogru loop

            int eded;
            Console.Write("Eded daxil et : ");
            eded = Convert.ToInt32(Console.ReadLine());
            while (eded > 0)
            {
                Console.WriteLine(eded);
                eded--;
            }
            #endregion

            #region while ile 0 ile 100 arasindaki tek ededlerin cemi
            int eded1 = 0, cem = 0;

            while (eded1 <= 100)
            {
                if (eded1 % 2 != 0) { cem += eded1; }


                eded1++;
            }
            Console.WriteLine(cem);
            #endregion

            #region while ile faktorialin hesablanmasi
            int number, hasil = 1;
            Console.Write("Eded daxil et : ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                hasil *= number;

                number--;
            }
            Console.WriteLine(hasil);
            #endregion

            #region  Mini login



            string Username, Password;
            string us = "admin";
            string ps = "adminpass";
            Console.Write("Username : ");
            Username = Console.ReadLine();
            Console.Write("Password : ");
            Password = Console.ReadLine();
            #region if
            if (Username == us && Password == ps)
            {
                Console.WriteLine("Ugurlu Emeliyyat");
            }
            else { Console.WriteLine("Emeliyyat Ugursuz Oldu"); }

            #endregion

            #region ternary
            var yoxla = Username == us && Password == ps ? "Ugurlu emeliyyat" : "Emeliyyat ugursuz oldu";
            Console.WriteLine(yoxla);
            #endregion
            #region Switch
            switch (Username)
            {
                case "admin" when Password == ps:
                    Console.WriteLine("Ugurlu Emeliyyat");
                    break;

            }
            #endregion

            #endregion

            #region role
            string input;
            Console.Write("Melumat Daxil Et : ");
            input = Console.ReadLine();
            if (input != "AA" || input != "BB" || input != "CC" || input != "MM" || input != "MH" || input != "UU")
            {
                Console.WriteLine("Daxil edilen selahiyyet dogru deyil");
            }
            else
            {
                switch (input)
                {
                    case "AA":
                        Console.WriteLine("Admin selahiyyetlerine sahibsiniz.");
                        break;
                    case "BB": goto case "AA";
                    case "CC": goto case "AA";
                    case "MM":
                        Console.WriteLine("Moderator selahiyyetlerine sahibsiniz.");
                        break;
                    case "MH":
                        Console.WriteLine("Muhasib selahiyyetlerine sahibsiniz.");
                        break;
                    case "UU":
                        Console.WriteLine("Standart istifadeci selahiyyetlerine sahibsiniz.");
                        break;

                }
            }
            #endregion

            #region calculate 
            decimal ed1, ed2;
            char emeliyyat;
            Console.Write("Eded1 : "); ed1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" Toplama (+) , Cixma (-) , Vurma (x) , Bolme (/)  Daxil edin");
            Console.Write("Emeliyyat : "); emeliyyat = Convert.ToChar(Console.ReadLine());
            Console.Write("Eded2 : "); ed2 = Convert.ToDecimal(Console.ReadLine());
            #region normal switch
            switch (emeliyyat)
            {
                case '+':
                    Console.WriteLine("Netice : " + (ed1 + ed2));
                    break;
                case '-':
                    Console.WriteLine("Netice : " + (ed1 - ed2));
                    break;
                case 'x':
                    Console.WriteLine("Netice : " + (ed1 * ed2));
                    break;
                case '/':
                    Console.WriteLine("Netice : " + (ed1 / ed2));
                    break;
            }
            #endregion
            #region exp switch

            var eml = emeliyyat switch
            {
                '+' => ed1 + ed2,
                '-' => ed1 - ed2,
                '/' => ed1 / ed2,
                'x' => ed1 * ed2,
            };
            Console.WriteLine("Netice : " + eml);
            #endregion

            #endregion

            #region menfi musbet
            decimal in1;
            Console.Write("Eded daxil et : ");
            in1 = Convert.ToDecimal(Console.ReadLine());
            #region if
            if (in1 >= 0) { Console.WriteLine("Musbetdir"); }
            else { Console.WriteLine("Menfidir"); }
            #endregion
            #region ternary
            var vz = in1 < 0 ? "Menfidir" : "Musbetdir";
            Console.WriteLine(vz);
            #endregion
            #endregion

            #region vurma cedveli
            int i, j;

            for (i = 1; i < 10; i++)
            {
                for (j = 1; j < 10; j++)
                {
                    Console.Write(i + "x" + j + "=" + i * j + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #region exam

            /*
             * 1. int num1=10;
             *    int num2=20;
             *    bool result = num1 > num2;
             *
             *  asagidakilardan hansi uygun gelir ?
             *
             *Dogru cavab:  --- num1 deyeri num2 deyerinden kicikdir ve bool tipinde olan result
             *                  deyiseni bu iki deyerin muqayisesinden false deyerini alir.
             *
             * num1 deyeri num2 deyerine beraberdir ve bool tipinde olan result
             *  deyiseni true-dur.
             *
             ********************
             * 2. int num1 = 100;
             *
             *    int num2 = 2;
             *    
             *    int result = (num1 + 10 ) / num2;
             *    
             *    Console.WriteLine(result);
             *
             * Result : 33;
             *Dogru cavab --- Result : 55;
             * Result : 66;
             * ******************
             * 3. Boyuk beraberdir  ve beraber deyildir operatorlari hansilardir.
             *
             * =! , ==
             * == , <=
             * >= , <=
             *Dogru cavab -----  >= , !=
             */

            #endregion
        }
    }
}
