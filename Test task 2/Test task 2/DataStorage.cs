using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task_2
{
    struct Rec
    {
        public uint cardNumber;
        public string shopName;
        public string prodName;
        public DateTime date;
        public decimal cost;
    }

    class DataStorage
    {
        private List<Rec> records;

        public DataStorage()
        {
            records = new List<Rec>();
        }

        public void addRec(Rec record)
        {
            records.Add(record);
        }

        public void SortByDate()
        {
          records=records.OrderBy(t => t.date).ToList();
        }

        public void PrintSumsByCards()
        {
            var res = records.GroupBy(t=>t.cardNumber,s=>s.cost).Select(g=>new {cardNamber=g.Key, sum=g.Sum()});
            foreach (var t in res)
            {
                Console.WriteLine("{0,-10} {1,5:C}", t.cardNamber, t.sum);
            }
        }

        public void PrintRecords()
        {
            foreach (Rec t in records)
            {
                Console.WriteLine("{0,-10} {1,-13} {2,-13} {3,-14} {4,5:C}", t.cardNumber, t.shopName,
                                                         t.prodName, t.date.ToShortDateString(), t.cost);
            }
        }
    }
}
