using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamFinal.Models;
namespace ExamFinal.Repositories
{
    class ListPayers
    {
        public List<Payer> payers { get; set; } = new List<Payer>();
        public Date date { get; set; } = new Date();
        public int Count { get; set; }

        public void AddPayer()
        {
            Payer p = new Payer();
            Console.WriteLine("Input Payer Name: ");
            p.bill.Name = Console.ReadLine();
            Console.WriteLine("Input Payer Phone: ");
            p.bill.Phone = Console.ReadLine();
            Console.WriteLine("Input Payer Price per minute: ");
            p.bill.PricePerMinute = float.Parse(Console.ReadLine());
            Console.WriteLine("Input discount(for cancel, input 100): ");
            int a = Int32.Parse(Console.ReadLine());
            p.bill.UseDiscount(a);
            Console.WriteLine("Input begin hour: ");
            p.bill.Begin.Hours = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input begin minutes: ");
            p.bill.Begin.Minutes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input begin seconds: ");
            p.bill.Begin.Seconds = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input end hour: ");
            p.bill.End.Hours = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input end minutes: ");
            p.bill.End.Minutes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input end seconds: ");
            p.bill.End.Seconds = Int32.Parse(Console.ReadLine());
            p.bill.CalculateDuration();
            payers.Add(p);
        }
        public void DelPayer()
        {
            Console.WriteLine("Input Payer Name: ");
            string name = Console.ReadLine();
            int count = -1;
            for(int i = 0; i < payers.Count; i++)
            {
                if(payers[i].bill.Name == name)
                {
                    count = i;
                    break;
                }
            }
            if(count != -1)
            {
                payers.RemoveAt(count);
            }
            else
            {
                Console.WriteLine("Del complete!");
            }
        }
        public void SearchByPhone()
        {
            Console.WriteLine("Input phone: ");
            string phone = Console.ReadLine();
            Payer res = payers.Single(x => x.bill.Phone == phone);
            if (res != null)
            {
                res.Display();
            }

        }
        public void SearchByName()
        {
            Console.WriteLine("Input name: ");
            string name = Console.ReadLine();
            Payer res = payers.Single(x => x.bill.Name == name);
            if (res != null)
            {
                res.Display();
            }
        }
        public void SearchByDate()
        {
            Console.WriteLine("Input date day: ");
            uint date = UInt32.Parse(Console.ReadLine());
            Payer res = payers.Single(x => x.date.Day == date);
            if (res != null)
            {
                res.Display();
            }
        }        
        public void Display()
        {
            if (payers.Count != 0)
                foreach (Payer p in payers)
                    p.Display();
            else
                Console.WriteLine("No payers yet!");
            
        }
    }
}
