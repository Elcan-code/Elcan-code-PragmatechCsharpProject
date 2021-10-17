using System;

namespace Mini_login
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Mini login
            /*
             * Username ve password deye deyisenler teyin edin.
             *
             *  Username : admin
             *  Password : 6gH123
             *
             * Istifadeciden  username ve Password daxil etmesini isteyin.
             *
             * Daxil edilen username ve passwordun teyin edilen
             * deyisenlerin deyerine beraber olub olmamasini yoxlayin,
             *
             * Netice olaraq login emeliyyatinin ugurlu ve ya
             *
             *  daxil edilen username ve ya sifrenin dogru olmadigi mesajini verin.
             *
             * ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
             *  qeyd: eyni taski, if, ternary operator ve switch ile yazin
             *
             */


            string Username, Password;
            string myusername = "admin";
            string mypassword = "adminpass";
            Console.Write("Username : ");
            Username = Console.ReadLine();
            Console.Write("Password : ");
            Password = Console.ReadLine();
            #region if
            if (Username == myusername && Password == mypassword)
            {
                Console.WriteLine("Ugurlu Emeliyyat");
            }
            else { Console.WriteLine("Emeliyyat Ugursuz Oldu"); }

            #endregion

            #region ternary
            var yoxla = Username == myusername && Password == mypassword ? "Ugurlu emeliyyat" : "Emeliyyat ugursuz oldu";
            Console.WriteLine(yoxla);
            #endregion
            #region Switch
            switch (Username)
            {
                case "admin" when Password == mypassword:
                    Console.WriteLine("Ugurlu Emeliyyat");
                    break;

            }
            #endregion

            #endregion
        }
    }
}
