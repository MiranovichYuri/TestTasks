using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class RecCl
    {
        public uint cardNumber { get; set;}
        public string shopName { get; set; }
        public string prodName { get; set; }
        public DateTime date { get; set; }
        public double cost { get; set; }

        public RecCl(uint cardNumber, string shopName, string prodName, DateTime date, double cost)
        {
            this.cardNumber = cardNumber;
            this.shopName = shopName;
            this.prodName = prodName;
            this.date = date;
            this.cost = cost;     
        }

        public double calcDiscount()
        {
            return cost * 0.05;
        }
    }
}
