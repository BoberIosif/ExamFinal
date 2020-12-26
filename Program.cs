using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamFinal.Repositories;

namespace ExamFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            ListPayers lp = new ListPayers();
            lp.Display();
            lp.AddPayer();
            lp.Display();
        }
    }
}
