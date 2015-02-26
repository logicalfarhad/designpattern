using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Builder
{
    public class AppleBuilder : ComputerBuilder
    {

        public AppleBuilder()
        {
            Computer = new Computer(ComputerType.Apple);
        }
        public override void BuildMotherBoard()
        {
            Computer.MotherBoard = "iMac G5 PowerPC";
        }

        public override void BuildScreen()
        {
            Computer.Screen = "24 inch (1980*1200)";
        }

        public override void BuildHarddisk()
        {
            Computer.HardDisk = "320GB";
        }

        public override void BuildProcessor()
        {
            Computer.Processor = "Intel Core 2 Duo";
        }
    }
}
