using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class CalculatorAdapter
    {
        private readonly Calculator _calculator;
        public CalculatorAdapter()
        {
            _calculator =new Calculator();
        }
        
        public int GetTotalSum(List<int> numbers)
        {
            int sum = _calculator.GetSum(numbers.ToArray());
            return sum;
        }
    }
}
