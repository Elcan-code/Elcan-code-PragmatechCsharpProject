using System;

namespace calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            #region calculate 
             /*
             * switch istifade ederek calculator yazin
             *
             * qeyd: hem normal switchden istifade edin hem de expressionla olan variantla
             */

            decimal num1, num2;
            char operation;
            Console.Write("Eded1 : "); num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" Toplama (+) , Cixma (-) , Vurma (x) , Bolme (/)  Daxil edin");
            Console.Write("Emeliyyat : "); operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Eded2 : "); num2 = Convert.ToDecimal(Console.ReadLine());
            #region normal switch
            switch (operation)
            {
                case '+':
                    Console.WriteLine("Netice : " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Netice : " + (num1 - num2));
                    break;
                case 'x':
                    Console.WriteLine("Netice : " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Netice : " + (num1 / num2));
                    break;
            }
            #endregion
            #region exp switch

            var result = operation switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '/' => num1 / num2,
                'x' => num1 * num2,
            };
            Console.WriteLine("Netice : " + result);
            #endregion

            #endregion
        }
    }
}
