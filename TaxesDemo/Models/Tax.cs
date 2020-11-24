using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesDemo.Models
{
    public abstract class Tax
    {
        public abstract void CalculateTax(int price, int articles);
    }
}
