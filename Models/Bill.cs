using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFinal.Models
{
    class Bill
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public float PricePerMinute { get; set; }

        public Time Begin { get; set; } = new Time();
        public Time End { get; set; } = new Time();
        public Time Duration { get; set; } = new Time();

        public void CalculateDuration()
        {
            Duration = End - Begin;
        }

        public override string ToString()
        {
            if (Duration != null)
            {
                Duration.TranserMinutes();
                float a = Duration.Minutes * PricePerMinute;
                return $"{a}$";
            }
            else
            {
                return $"0$";
            }
        }

        public void UseDiscount(int disc)
        {
            PricePerMinute *= (disc / 100);
        }

    }
}
