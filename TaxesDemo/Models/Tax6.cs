using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesDemo.Models
{
    public class Tax6 : Tax
    {
        public override void CalculateTax(int price, int articles)
        {
            double result = (price * articles) * 1.06;
            Console.WriteLine(result);
        }
    }
}
