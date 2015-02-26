using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adapter;

namespace Adaptor
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorAdapter calculator = new CalculatorAdapter();
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var sum = calculator.GetTotalSum(numbers);
            Console.WriteLine(sum);
        }
    }
}
