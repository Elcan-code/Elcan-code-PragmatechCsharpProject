using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace week6task
{
    class Cek
    {



        public int Id { get; set; }
        public string Ad { get; set; }
        public double Qiymet { get; set; }
        public string OlcuNovu { get; set; }
        public int Edv { get; set; } = 0;
        public int Endirim { get; set; } = 0;
        public int Miqdar { get; set; } = 1;

        public static double UmumiMebleg = 0;
        public static double UmumiEdv = 0;
        public static double UmumiEndrim = 0;
        public static double YekunMebleg = 0;
        public static List<Cek> CekList()
        {
            Cek cek = new Cek();
            int x = Program.hb.Keys.Count;
            List<Cek> _cek = new List<Cek>();
            foreach (var item in Mehsul.MehsulList())
            {
                foreach (int item2 in Program.hb.Keys)
                {

                    if (item.Id == item2)
                    {
                        int miqdar = Convert.ToInt32(Program.hb[item2]);
                        UmumiMebleg += Convert.ToDouble(item.Qiymet) * miqdar;
                        UmumiEdv += (Convert.ToDouble(item.Qiymet) * Convert.ToDouble(item.Edv) * miqdar) / 100;
                        UmumiEndrim += (Convert.ToDouble(item.Qiymet) * Convert.ToDouble(item.Endirim) * miqdar) / 100;
                        _cek.Add(new Cek
                        {
                            Id = item.Id,
                            Ad = item.Ad,
                            OlcuNovu = item.OlcuNovu,
                            Qiymet = item.Qiymet,
                            Endirim = item.Endirim,
                            Edv = item.Edv,
                            Miqdar = miqdar


                        }); ;
                    }
                }
            }
            YekunMebleg = UmumiMebleg - UmumiEndrim;




            return _cek;
        }


    }
}
