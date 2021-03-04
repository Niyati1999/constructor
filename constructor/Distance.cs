using System;
using System.Collections.Generic;
using System.Text;

namespace constructor
{
    class Distance
    {
        public int inch { get; set; }
        public  int feet { get; set; }
        public Distance()
        {
            inch = 0;
            feet = 0;

        }
        public Distance(int i)
        {
            if (i >= 12)
            {
                inch = i / 12;
                feet = i % 12;
            }

        }
        public Distance(int i,int f)
        {
            
            if (i >= 12)
            {
                inch = i / 12;
                feet = i % 12;
                f = f + feet;
                feet = f;
            }
            else
            {
                inch = i;
                feet = f;
            }
            
        }
        public void printValue()
        {
            Console.WriteLine("Inch = " + inch);
            Console.WriteLine("Feet = " + feet);
        }

    }
}
