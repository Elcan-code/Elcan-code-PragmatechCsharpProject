using System;

namespace role
{
    class Program
    {
        static void Main(string[] args)
        {

            #region role
            /*
             * Istifadeciden role(selahiyyet) isteyerek daxil etdiyi role uygun mesaj verin.
             *
             *  Istifadeci selahiyyeti (I.S) :
             *
             * I.S = AA , BB , CC ise "Admin selahiyyetlerine sahibsiniz."
             * I.S = MM "Moderator selahiyyetlerine sahibsiniz."
             * I.S = MH "Muhasib selahiyyetlerine sahibsiniz."
             * I.S = UU "Standart istifadeci selahiyyetlerine sahibsiniz."
             *
             * qeyd edilenlerden ferqli olarsa : "Daxil edilen selahiyyet dogru deyil"
             *
             * switchden istifade edin.
             */


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
        }
    }
}
