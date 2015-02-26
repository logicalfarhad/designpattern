using System.Linq;
namespace Adapter
{
    public class Calculator
    {
        public int GetSum(int[] numbers)
        {
            int sum = numbers.Sum();
            return sum;
        }
    }
}
