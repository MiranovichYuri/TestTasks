using System;
using System.IO;
using System.Text;
using System.Linq;

namespace Test_task_2
{


    class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();
            StreamReader fileReader = new StreamReader(filename,Encoding.Default);
            DataStorage d1 = new DataStorage();
            string line;
            while ((line=fileReader.ReadLine()) != null)
            {
                string[] dt = line.Split(';');
                Rec newRec=new Rec();
                newRec.cardNumber=Convert.ToUInt32(dt[0]);
                newRec.shopName=dt[1];
                newRec.prodName=dt[2];
                newRec.date=DateTime.Now.AddDays(-Convert.ToUInt32(dt[3]));
                newRec.cost=Convert.ToDecimal(dt[4]);
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
