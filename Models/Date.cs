using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFinal.Models
{
    class Date
    {
        public uint Day { get; set; }
        public uint Month { get; set; }
        public uint Year { get; set; }

        public override string ToString()
        {
            return $"{Day}.{Month}.{Year}";
        }
    }
}
