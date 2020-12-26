using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamFinal.Models;
namespace ExamFinal.Repositories
{
    class Payer
    {
        public Bill bill { get; set; } = new Bill();
        public bool Payment { get; set; }
        public Date date { get; set; } = new Date();
        public float price { get; set; }

        public Payer()
        {
            DateTime dt = new DateTime();
            Payment = false;
            date.Day = (uint)dt.Day;
            date.Month = (uint)dt.Month;
            date.Year = (uint)dt.Year;
        }

        public void CountPrice()
        {
            price = bill.PricePerMinute * bill.Duration.Minutes;
        }

        public void Display()
        {
            Console.WriteLine($" {bill.Name} => {bill.Phone}, " +
                $"{date}, Price:  {price}, Status: {Payment}");
        }

    }
}
