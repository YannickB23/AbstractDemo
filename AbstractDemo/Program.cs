using AbstractDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildCalculate calculate = new ChildCalculate();
            calculate.Add(5, 7);
            calculate.Substract(10, 2);
            calculate.Multiply(10, 10);
            calculate.Divide(12, 6);
        }
    }
}
