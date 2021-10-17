using System;

namespace week6task
{
    class Rectangle
    {

        public static int Sahe(int en, int uzunluq)
        {
            return en * uzunluq;
        }

        private int _en = 0;
        private int _uzunluq = 0;
        public int En
        {
            get
            {
                return _en;
            }

            set
            {
                if (value < 0) { value = 0; }
                _en = value;
            }
        }
        public int Uzunluq
        {
            get
            {
                return _uzunluq;
            }

            set
            {
                if (value < 0) { value = 0; }
                _uzunluq = value;
            }
        }

    }

}