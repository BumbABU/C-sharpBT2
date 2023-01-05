using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARPBT2.OOP
{
    internal class MyDate
    {
        private int year;
        private int month;
        private int day;

       public MyDate ()
        {
            this.year= 1900;
            this.month= 1;  
            this.day= 1;   
        }

        public MyDate(int day , int month, int year)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public override string? ToString()
        {
            return day +"/" +month + "/" +year;
        }
    }
}
