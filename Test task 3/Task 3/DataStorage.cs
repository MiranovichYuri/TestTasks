using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class DataStorage
    {
        private List<RecCl> records;

        public DataStorage()
        {
            records = new List<RecCl>();
        }

        public void addRec(RecCl record)
        {
            records.Add(record);
        }

        public void SortByDate()
        {
            records = records.OrderBy(t => t.date).ToList();
        }

        public void PrintSumsByCards()
        {
            var res = records.GroupBy(t => t.cardNumber, s => s.cost).Select(g => new { cardNamber = g.Key, sum = g.Sum() });
            foreach (var t in res)
            {
                Console.WriteLine("{0,-10} {1,5:C}", t.cardNamber, t.sum);
            }
        }

        public void PrintRecords()
        {
            foreach (RecCl t in records)
            {
                Console.WriteLine("{0,-10} {1,-13} {2,-13} {3,-14} {4,-8:C} {5,-8:C}", t.cardNumber, t.shopName,
                                                         t.prodName, t.date.ToShortDateString(), t.cost,t.calcDiscount());
            }
        }
    }
}
