using System;

namespace vurma_cedveli
{
    class Program
    {
        static void Main(string[] args)
        {
            #region vurma cedveli
            /*
             * vurma cedveli hazirlayin. (12 vereqli defeterlerin arxasindaki gorunuse sahib olsun.)
             * 
             * netice asagidaki kimi olsun
             *
             * 1 * 1 = 1   1 * 2 = 2  1 * 3 = 3 // belece davam edir
             * 2 * 1 = 2   2 * 2 = 4  2 * 3 = 6
             * 
             */

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

        }
    }
}
