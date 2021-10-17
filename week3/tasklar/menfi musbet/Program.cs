using System;

namespace menfi_musbet
{
    class Program
    {
        static void Main(string[] args)
        {
            #region menfi musbet
            /*
             * Daxil edilen ededin menfi ve ya musbet oldugunu yoxlayin ona uygun geriye deyer qaytarin.
             *
             * qeyd: if ve ternary istifade edin ayri ayri
             */

            decimal num;
            Console.Write("Eded daxil et : ");
            num = Convert.ToDecimal(Console.ReadLine());
            #region if
            if (num >= 0) { Console.WriteLine("Musbetdir"); }
            else { Console.WriteLine("Menfidir"); }
            #endregion
            #region ternary
            var vz = num < 0 ? "Menfidir" : "Musbetdir";
            Console.WriteLine(vz);
            #endregion
            #endregion
        }
    }
}
