using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();
            StreamReader fileReader = new StreamReader(filename, Encoding.Default);
            DataStorage d1 = new DataStorage();
            string line;
            while ((line = fileReader.ReadLine()) != null)
            {
                string[] dt = line.Split(';');
                RecCl newRec = new RecCl(Convert.ToUInt32(dt[0]), dt[1], dt[2], DateTime.Now.AddDays(-Convert.ToUInt32(dt[3])),
                                     Convert.ToDouble(dt[4]));

                d1.addRec(newRec);
            }
            fileReader.Close();

            d1.PrintRecords();
            Console.WriteLine();

            d1.SortByDate();
            d1.PrintRecords();
            Console.WriteLine();

            d1.PrintSumsByCards();

            Console.ReadKey();
        }
    }
}
