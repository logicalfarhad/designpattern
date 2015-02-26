using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Builder
{
    public class Computer
    {
        private readonly ComputerType _computerType;
       
        public string MotherBoard { get; set; }
        public string Processor { get; set; }
        public string HardDisk { get; set; }
        public string Screen { get; set; }

        public Computer(ComputerType computerType)
        {
            _computerType = computerType;
        }



        public void DisplayConfiguration()
        {
            Console.WriteLine(_computerType);
            Console.WriteLine(MotherBoard);
            Console.WriteLine(Processor);
            Console.WriteLine(HardDisk);
            Console.WriteLine(Screen);
        }
    }
}
