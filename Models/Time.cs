using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFinal.Models
{
    class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Time()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }


        static public Time operator -(Time t1, Time t2)
        {
            Time t3 = new Time();
            t3.Seconds = t1.Hours * 60 * 60 + t1.Minutes * 60 + t1.Seconds - t2.Hours * 60 * 60 - t2.Minutes * 60 - t2.Seconds;

            return t3;
        }   

        public void TranserMinutes()
        {
            
            Minutes += Hours * 60;
            if (Seconds != 0)
            {
                Minutes += 1;
            }            
        }

    }
}
