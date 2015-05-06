using System;
using System.Collections.Generic;
using System.Linq;

namespace Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            String[] arr = { "One", "Two", "Three", "Five" };
            List<String> list = arr.ToList();
            arr.Where(x=>!x.Equals("Five")).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();
            arr.TakeWhile(x => !x.Equals("Five")).ToList().ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
