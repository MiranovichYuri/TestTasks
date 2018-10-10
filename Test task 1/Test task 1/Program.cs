using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace Test_task_1
{
    public class DataStorage
    {
        string data;

        public DataStorage(string s)
        {
            data = s;
        }

        public string chooseNumbers()
        {
            Regex rx = new Regex(@"(\D )|\D$");
            return rx.Replace(data, "");
        }

        public string sortData()
        {
            string tmp = data.Replace(" ", "");
            char[] chars = tmp.ToArray();
            Array.Sort(chars);
            Array.Reverse(chars);
            return String.Join(" ",chars);
        }

        public string delRepeats()
        {
            string tmp = data.Replace(" ", "");
            return String.Join(" ",tmp.Distinct().ToArray<char>());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filename=Console.ReadLine();
            StreamReader fileReader = new StreamReader(filename);
            DataStorage d1 = new DataStorage(fileReader.ReadToEnd());
            fileReader.Close();
            Console.WriteLine(d1.chooseNumbers());
            Console.WriteLine(d1.sortData());
            Console.WriteLine(d1.delRepeats());
            Console.ReadKey();
        }
    }
}
