using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8task2
{
    class Bookdb
    {
        public int Id { get; set; }
        public string Kitabad { get; set; }
        public string Yazıçı { get; set; }
        public string Kataqoriya { get; set; }
        public string Şəkil { get; set; }
        public string Haqqında { get; set; }
        public int Stok { get; set; }
        public static List<Bookdb> BookList()
        {

            List<Bookdb> _book = new List<Bookdb>();
            _book.Add(new Bookdb
            {
                Id = 1,
                Kitabad = "Mavi qatarın sirri",
                Yazıçı = "Aqata Kristi",
                Kataqoriya = "Dedektiv",
                Şəkil = "C:\\Users\\elcan\\source\\repos\\Week8task\\Week8task\\maviqatar.jpg",
                Haqqında = "Aqata Kristinin dedektiv əsərlərindən Mavi Qatarın Sirri adlı əsəri uşaqlar və eyni zamanda gənclər tərəfindən olduqca bəyənilərək oxunur.",
                Stok = 3


            });
            _book.Add(new Bookdb
            {
                Id = 2,
                Kitabad = "Əcdadların harayı",
                Yazıçı = "Cek London",
                Kataqoriya = "Macəra",
                Şəkil = "C:\\Users\\elcan\\source\\repos\\Week8task\\Week8task\\əcdad.jpg",
                Haqqında = "Amerika yazıçısı C.London uşaqlıqdan işləməyə məcbur olmuşdur. İlk hekayələri 12 yaşından çap olunsa da, ciddi ədəbi fəaliyyətə 23 yaşından başlamış, 22 roman və povest, 200-ə yaxın hekayə yazmışdır. C.London “Martin İden”, “Bəyaz Diş”, “Dəmir daban”, Dəniz Canavarı” və s. əsərləri ilə bütün dünyada məşhurdur.",
                Stok = 3


            });
            _book.Add(new Bookdb
            {
                Id = 2,
                Kitabad = "Səfillər",
                Yazıçı = "Viktor Hüqo",
                Kataqoriya = "Roman",
                Şəkil = "C:\\Users\\elcan\\source\\repos\\Week8task\\Week8task\\sefiller.jpg",
                Haqqında = "Yazıçı Viktor Hüqonun 1862-ci ildə nəşr olunmuş və XIX əsrin ən mükəmməl nəsri hesab edilən fransız romanı. ",
                Stok = 3


            }); ;
            return _book;

        }
    }
    }
