using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxesDemo.Models;

namespace TaxesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tax21 total21 = new Tax21();
            Console.Write("2 T-Shirts= ");
            total21.CalculateTax(25, 2);
            Console.WriteLine("-----------------------");
            Tax6 total6 = new Tax6();
            Console.Write("2 Boeken= ");
            total6.CalculateTax(25, 2);
            Console.ReadLine();
        }
    }
}
