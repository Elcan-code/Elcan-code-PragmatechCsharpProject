using System;

namespace while_ile_faktorialin_hesablanmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while ile faktorialin hesablanmasi
            int number, total = 1;
            Console.Write("Eded daxil et : ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                total *= number;

                number--;
            }
            Console.WriteLine(total);
            #endregion
        }
    }
}
