using System;

namespace week6task
{

        class Muellim
        {
            private static Random random = new Random();
            DateTime date = DateTime.Now;
            bool yas = false;
            public int Id { get; } = random.Next(0, 300);

            public string Ad { get; set; }
            public string Soyad { get; set; }
            private string _vezife;
            public string Vezife
            {
                get
                {
                    return _vezife;
                }

                set
                {
                    if (String.IsNullOrEmpty(value)) { value = "Teacher"; }
                    _vezife = value;

                }
            }
            private DateTime _dogumtarixi;
            public DateTime DogumTarixi
            {
                get
                {
                    return _dogumtarixi;
                }

                set
                {
                    TimeSpan span = DateTime.Now.Subtract(value);
                    if (Convert.ToInt32(span.Days) / 365 >= 23) { yas = true; }
                    _dogumtarixi = value;
                }
            }

            public DateTime BaslamaTarixi
            {
                get
                {
                    if (yas == true)
                    {
                        return DateTime.Now.AddDays(1);
                    }

                    else return DateTime.Now;
                }


            }

            public string Yer { get; set; }
        }
    }
