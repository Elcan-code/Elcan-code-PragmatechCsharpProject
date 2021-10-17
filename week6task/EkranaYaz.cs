using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6task
{
    class EkranaYaz
    {
        public static void Yaz()
        {
            Console.Clear();
            foreach (var item in Cek.CekList())
            {
                Console.WriteLine($"| Mehsulun adi : {item.Ad}    " + $"| Miqdar  : {item.Miqdar} {item.OlcuNovu}    " + $"| Qiymet : {item.Qiymet} AZN |" + $"| Edv : {item.Edv} % |");
            }

            Console.WriteLine("Umumi Mebleq : " + Math.Round(Cek.UmumiMebleg, 3));
            Console.WriteLine("Edv : " + Math.Round(Cek.UmumiEdv, 3));
            Console.WriteLine("Endrim : " + Math.Round(Cek.UmumiEndrim, 3));
            Console.WriteLine("Yekun Mebleg : " + Math.Round(Cek.YekunMebleg, 3));
            Musteri musteri = new Musteri();
            if (musteri.Endirimkarti == true)
            {
                Console.WriteLine("Bonus kartina gore Endirim : " + Cek.UmumiMebleg / 100 * 2);
            }


        }


    }
}
