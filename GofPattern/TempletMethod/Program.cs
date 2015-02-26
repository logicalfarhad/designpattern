using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TempletMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffee = new Coffee();
            coffee.PrepareRecipe();
            var tea = new Tea();
            tea.PrepareRecipe();
        }
    }
}
