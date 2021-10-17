using System;
using System.Collections.Generic;
using System.Collections;

namespace week6task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region rectangle
            /*
             * Console-dan daxil edilen en ve uzunluga gore duzbucaqlinin sahesinin hesablanmasi.
             * class memeber-ler ve encapsulation movuzlarina uygun isleyin.
             * Qeyd: daxil edilnlerden her hansisa birinin menfi olub olmamasini yoxlayin.
             * menfidirse deyeri 0 beraber edin.
             */

            Rectangle rectangle = new Rectangle();
            Console.Write("Duzbucaqlinin enini daxil edin : ");
            rectangle.En = Convert.ToInt32(Console.ReadLine());
            Console.Write("Duzbucaqlinin uzunlugunu daxil edin : ");
            rectangle.Uzunluq = Convert.ToInt32(Console.ReadLine());
            Console.Write("Duzbucaqlinin Sahesi: ");
            Console.WriteLine(Rectangle.Sahe(rectangle.En, rectangle.Uzunluq));
            #endregion
            #region teacher
            /*
             *  Muellim modeli yaradin, id, adi,soyadi,vezifesi,dogum tarixi, ise baslama tarixi, islediyi yer
             *  datalarini saxlasin.
             *  Id: sadece oxuna biler auto yaradilacaq.
             *  Vezife: daxil edilmeyibse nulldursa Teacher deye set edilsin.
             *  Ise Baslama tarixi : Muellimin eger 23 yasi varsa muellim olaraq fealiyyet gostere biler.
             */
            Console.Write("Hal hazirki tarix : ");
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine();
            Muellim muellim = new Muellim();
            Console.Write("Adinizi daxil edin : ");
            muellim.Ad = Console.ReadLine();
            Console.Write("Soyadinizi daxil edin : ");
            muellim.Soyad = Console.ReadLine();
            Console.Write("Vezife daxil edin : ");
            muellim.Vezife = Console.ReadLine();
            Console.Write("Dogum tarxinzi daxil edin : ");
            muellim.DogumTarixi = Convert.ToDateTime((Console.ReadLine() + " 11:00:00 AM"));
            Console.Write("Is yeri : ");
            muellim.Yer = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("___________________________________");
            Console.WriteLine();
            Console.WriteLine(muellim.Id);
            Console.WriteLine(muellim.Ad);
            Console.WriteLine(muellim.Soyad);
            Console.WriteLine(muellim.Vezife);
            Console.WriteLine(muellim.DogumTarixi);
            Console.WriteLine(muellim.Yer);
            TimeSpan span = DateTime.Now.Subtract(muellim.BaslamaTarixi);
            if (Convert.ToInt32(span.Days) >= 1) { Console.WriteLine(muellim.BaslamaTarixi); }
            else { Console.WriteLine("Yasiniz is ucun yeterli deyil"); }

            #endregion
            #region gelende eve corey al
    /*
     *  Online alis veris :
     *  * Console ekaraninda musterini ilk once  menu qarsilamalidir,
     *  mehsullari menudan sececek( qiymetleri de olmalidir) sonra hansindan ne qeder istediyini qeyd edecek
     *  bildiklerinizi tetbiq ederek asagidaki numune cekin hazilanmasi
     *  lazimdir. Mehsul adlari onlarin qiymetleri edv olub olmamasi mehsulda endirim olub olmamasi
     *  siz terefden serbest teyin olunacaq.(burada gosterilenler hayel urunudur hic biri gercegi yansitmamaktadir).
     *
     *  | mehsul adi        |  miqdar  |  qiymet  |EDV  |toplam|
     *  | Un                | 5 kq     |  1       |0 %  |5     |
     *   Sizin qazanciniz=================== 0,495             |
     *  | quzu eti          | 3,5 kq   |  12      |18 % |42    |
     *   Sizin qazanciniz=================== 0,90              |
     *  | cay               | 2   eded |  1,50    |0 %  |      |
     *   Sizin qazanciniz=================== 0,90              |
     *  | alma qirmizi      | 2   kq   |  2,50    |0 %  |      |
     *   Sizin qazanciniz=================== 0,90              |
     *  | alma sari         | 2   kq   |  2       |18 % |      |
     *   Sizin qazanciniz=================== 0,90              |
     *  | goyerti           | 2   eded |  0,15    |0 %  |      |
     *   Sizin qazanciniz=================== 0,90              |
     *  | makaron           | 2   eded |  2       |0 %  |      |
     *   Sizin qazanciniz=================== 0,90              |
     *  | baliq konservasi  | 2   eded |  3,50    |0 %  |      |
     *   Sizin qazanciniz=================== 0,90              |
     *  | lavas             | 1   eded |  1,50    |0 %  |      |
     *   Sizin qazanciniz=================== 0,90              |
     *  | corek             | 2   eded |  0,50    |18 % |      |
     *   Sizin qazanciniz=================== 0,90              |
     *  | pomidor           | 2   kq   |  2,50    |0 %  |      |
     *   Sizin qazanciniz=================== 0,90              |
     *  | xiyar             | 2   kq   |  2       |0 %  |      |
     *   Sizin qazanciniz=================== 0,90              |
     *  | toyuq             | 2   eded |  2,50    |0 %  |      |
     *   Sizin qazanciniz=================== 0,90
     * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
     * Endirim                                          | 2,48 |
     * vergi edv                                        | 5,02 |
     * yekun mebleg                                     | 54,50|
     * odenis novu: kartla odenib                        
     * tarix 20:04:21
     * qebz nomresi : 12
     *
     * Musterinin hesabinda umumi 450 azn pul var,
     * elave olaraq musteri bravo endirim kartina sahib oldugu ucun her alis verishinde
     * umumi meblegin 2% qeder endirim elde edir. Musteri odenisi kartla ederse 0,18 elave deyer vergisinin
     * 10 % qederini , negd pulla ederse 15 % qederini yeniden musterinin hesabina kocurulur.
     *
     * sizin qazanciniz :
     * | Un                | 5 kq     |  1       |0 %  | 5
     *  Sizin qazanciniz=================== 0,495 ( 5 % endirim olub bu mehsulda digerlerinde de bu sekilde endrim olarsa hesablanmalidir.)
     *  0,495 qaliqlarda yuvarlasdirmada edersiz 
     * EDV :
     *  asagida gosterildiyi kimi bezi mehsullarda 0% bezilerinde 18% edv olmalidir.
     *  Sonda elave deyer vergisi-de hansi mehsullarda varsa toplanib yekun meblegin
     *  uzerine gelmelidir. Musteri odenisi kart-la  edibse 10% negd yolla odenis edibse
     *  15 % umumi edv-den musterinin hesabina pul qayidacaq.
     *
     *  | mehsul adi        |  miqdar  |  qiymet  |EDV  |toplam
     *  | Un                | 5 kq     |  1       |0 %  |5
     *   Sizin qazanciniz=================== 0,495
     *  | quzu eti          | 3,5 kq   |  12      |18 % |42
     *
     *
     *  alis veris 15 azn den azdirsa catdirilma ucun 4,50 azn teleb olunacaq.
     */

    class Program
    {
        public static Hashtable hb = new Hashtable();
        static void Main(string[] args)
        {
           
            Console.WriteLine("--------------------------------- XOS GELMISINIZ ------------------------------------");
            Console.WriteLine("Bravo Endrim Karti olanlara 2% elave endirim");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("Odenisi Kartla edenlere Edv nin 10%  Negd edenler ucun Edv nin 15% geri qaytarilir");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine();

           foreach(var item in Mehsul.MehsulList())
            {   Console.WriteLine();
                Console.WriteLine($"Id {item.Id} |  Mehsulun adi   {item.Ad} |  Qiymeti   {item.Qiymet}");
            }
            
                Console.WriteLine();
            while(true)
            {
                Console.Write("Almaq istediyiniz mehsulun id sini daxil edin : "); int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("QEYD : miqdarin sonuna eded ve ya kq yazmaga ehtiyyac yoxdur...");
                Console.Write("Miqdarini daxil edin : "); int miqdar = Convert.ToInt32(Console.ReadLine());
                hb.Add(id, miqdar);
                Console.WriteLine("Odenis etmek ve ceki almaq X basin alis-verise davam etmek ucun her hansi duymeye toxunun");
                
                if (Console.ReadLine() == "X") 
                { 
                    Musteri musteri = new Musteri();
                    Console.Write("Bonus Kartiniz varmi varsa B yoxsa Y  toxunun ");
                    if (Console.ReadLine().ToUpper() == "B") { musteri.Endirimkarti = true; }
                    else { musteri.Endirimkarti = false; }
                    Console.WriteLine("Odenis usulunu secin Kart(K)  Negd(N)");
                    string odenisusulu;
                   odenisusulu= Console.ReadLine(); EkranaYaz.Yaz();
                    if (odenisusulu.ToUpper() == "K")
                    {

                        Console.WriteLine("Balansiniz :"+ Math.Round(((musteri.Pul - Cek.YekunMebleg)+Cek.UmumiEdv/10),3));
                        Console.WriteLine("Kartla odenis etdiyiniz ucun edv nin 10% kartiniza qaytarildi");
                    }
                    if (odenisusulu.ToUpper() == "N")
                    {Console.WriteLine("Negd odenis etdiyiniz ucun edv nin 15% size qaytarilacaq");
                        Console.WriteLine("Qaytarilacaq mebleg : " + Math.Round(Cek.UmumiEdv / 100 * 15,2));
                        
                    }
                    Console.WriteLine("---------------------------------------------------------------------------");
                   

                    break; 
                }

            }



            #endregion
        }
    }
}
