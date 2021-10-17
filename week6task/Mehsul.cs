using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6task
{
    class Mehsul
    {

        public int Id { get; set; }
        public string Ad { get; set; }
        public double Qiymet { get; set; }
        public string OlcuNovu { get; set; }
        public int Edv { get; set; } = 0;
        public int Endirim { get; set; } = 0;

        public static List<Mehsul> MehsulList()
        {
            List<Mehsul> _mehsul = new List<Mehsul>();
            _mehsul.Add(new Mehsul
            {
                Id = 1,
                Ad = "Qend",
                OlcuNovu = "kq",
                Qiymet = 1.20,
                Endirim = 20
            });
            _mehsul.Add(new Mehsul
            {
                Id = 2,
                Ad = "Cay",
                OlcuNovu = "eded",
                Qiymet = 4.50,
                Edv = 18

            });
            _mehsul.Add(new Mehsul
            {
                Id = 3,
                Ad = "Sud",
                OlcuNovu = "eded",
                Qiymet = 2.30,
                Endirim = 15
            });
            _mehsul.Add(new Mehsul
            {
                Id = 4,
                Ad = "Toyuq",
                OlcuNovu = "kq",
                Qiymet = 5.30,
                Endirim = 20,
                Edv = 18
            });
            _mehsul.Add(new Mehsul
            {
                Id = 5,
                Ad = "Alma",
                OlcuNovu = "kq",
                Qiymet = 1.60,

            }); ;
            return _mehsul;

        }


    }
}
