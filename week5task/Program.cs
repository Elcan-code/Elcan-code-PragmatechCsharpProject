using System;

namespace week5task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Havada bulut dimplom isini unut
            /*
             * Telebinin adini soyadini 3 imtahan neticesini
             * (((her hansisa imtahan neticesi daxil edilmezse default deyer 51 verilecek,
             * daxil edilen imtahan neticeleri0-dan kicik 100-den boyuk ola bilmez,
             * eded yerine simvol ve sair daxil edilen zaman xeta mesaji cixmalidir, yeniden emeliyyati duzgun yerine yetirerek davam etmelidir))) daxil edib,
             * ortalamasini hesablayaraq console-da  adi,soyadi, imtahan neticeleri,
             * ortalamasi, Diplom isine dusub dusmediyi yazilacaq(((bunun ucun ortalama 81den boyuk ve ya beraber olmalidir))).
             *
             * Taski mumkun derece kicik methodlara bolerek her methoda verilen adi ehtiva eden isler gorulsun.
             * Student classi yaradaraq method-lari orada yazib Program classi icerisinde Main methodunda istifade edeceksiz.
             */


            //Console.WriteLine("-----------------------");
            //Console.Write("Ad Soyad Daxil edin : ");
            //string fullname = Console.ReadLine();
            //string[] point = new string[3];
            //string[] writevalue = new string[3] { "1-ci imtahan nəticənizi daxil edin : ", "2-ci imtahan nəticənizi daxil edin : ", "3-ci imtahan nəticənizi daxil edin : " };
            //int i = 0;
            //while (true)
            //{
            //    if (i > 2) { break; }

            //    Console.Write(writevalue[i]);
            //    point[i] = Console.ReadLine();
            //    if (Student.Check(point[i]) == 1) { i++; }
            //    else
            //    if (Student.Check(point[i]) == 2) { point[i] = "51"; i++; }
            //    else { Student.Error(); }
            //}
            //int average = Student.Average(point[0], point[1], point[2]);
            //bool result = Student.Diplomisi(average);
            //Student.Print(point[0], point[1], point[2], average, result, fullname); 

            #endregion
            #region 2.Para pul el cirki 2 yakinda sinemalarda

            /*
             * Evvelceden teyin edilen pin vasitesile ATM-ye yaxinlasan vetendas pini daxil edir.
             * Qarsinina cixan menu-dan balansina baxa, negd pul cixarda, ve ya umumi hesabdan cixaris
             * isteye biler.Secilen her hansi bir emeliyyatdan sonra istifadeci yeniden menuya- geri done bilmelidir.
             *
             *
             * login
             *
             * pin:
             * pin sadece reqemlerden ibaret olmalidir // 1234
             * pin sadece 4 reqemden ibaret olmalidir.
             *
             *
             * Menu
             *
             * 1.Balans:
             * (evvelceden standart olaraq balans 1000 azn olaraq nezerde tutulur.)
             *
             * 2.Negd pulun verilmesi:
             *  Istifadeci ATM-den min 1 manat max 1000 manat ceke biler.Balans yoxlamasi olacaq,
             *  daxil edilen mebleg hansi esginasdan nece eded olacaq o sekilde netice olaraq gosterilir.
             *   
             *
             * 3.Balansdan cixaris:
             *   Eger balansdan mexaric olubsa mexaric olunan meblegi ve hemin tarixi cap edin,
             *   Yox eger hele balansdan mexaric olunmayibsa bu haqqda mesaj gosterin.
             *
             *
             * Qeyd: consoledan daxil edilenler yalniz eded ola biler bular yoxlayanacaq ,
             * mumkun derece methodlarla isleyin
             *   
             */



            Console.WriteLine("-----------------------------");
            Console.WriteLine("Xoş Gəlmişsiniz");
            Console.WriteLine("Emeliyyatlar üçün");
            Console.Write("Istifadeci kodunuzu daxil edin : ");

            int pin = Atm.check(Console.ReadLine());
            if (pin > 0)
            {
                bool result = Atm.Login(pin);

                do
                {
                    if (result == true)
                    {



                        Atm.Menu();
                        int value1;

                        value1 = Convert.ToInt32(Console.ReadLine());
                        switch (value1)
                        {
                            case 1:
                                Atm.Cashout();
                                break;
                            case 2:
                                Atm.Balance();
                                break;
                            case 3:
                                Atm.Cıxarıs();
                                break;
                            default:
                                Console.WriteLine("Duzugun deyer daxil edin");
                                break;

                        }


                        Console.WriteLine("Emeliyyati sonlandirmaq ucun X (Enter) daxil edin");
                        Console.WriteLine("Davam etmek ucun (Enter)");
                    }
                    else Console.WriteLine("Emeliyyat sonlandirildi daxil etdiyiniz kod yalnisdir"); break;
                }

                while (Console.ReadLine() != "X");


            }

            else Console.WriteLine("Emeliyyat sonlandirildi daxil etdiyiniz kod yalnisdir");
            #endregion
        }
    }
}
