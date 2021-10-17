using System;

namespace while_ile_0_ile_100_arasindaki_tek_ededlerin_cemi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while ile 0 ile 100 arasindaki tek ededlerin cemi
            int num = 0, sum = 0;

            while (num <= 100)
            {
                if (num % 2 != 0) { sum += num; }


                num++;
            }
            Console.WriteLine(sum);
            #endregion
        }
    }
}
