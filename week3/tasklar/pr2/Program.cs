using System;

namespace pr
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 Bal Ortalamasinin Hesablanmasi
            /*
             * 1. Istifadeciden gelen 3 ferqli imtahan neticelerinin
             * ortalamasinin 45-den  boyuk ve ya beraber olmasini
             * yoxlayin.
             *
             * qeyd : if else istifade etmeyin burada
             * 
             * netice asagidaki kimi olmalidir.
             *
             *
             * Netice : 30
             * Netice : 50
             * Netice : 40
             *
             *
             * "Ortalama 45-e beraber ve ya boyukdurmu?" : "40"(Ortalamadir) : Beli ve ya Xeyr
             */


            int score1, score2, score3,average;
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
        }
    }
}
