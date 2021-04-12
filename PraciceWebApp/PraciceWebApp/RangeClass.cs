using System;

namespace PraciceWebApp
{
    public class RangeClass
    {
        public RangeClass(int numb)
        {
            number = numb;
        }
        public int number { get; set; }

        public string GetRange()
        {
            String z=" ";
            for (int i = 0; i < number; i++)
            {
                z = z + i.ToString() + " ";
            }
            return z;
        }
    }
}