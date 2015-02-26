using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Builder
{
    public class DesktopBuilder : ComputerBuilder
    {
        public DesktopBuilder()
        {
            Computer = new Computer(ComputerType.Desktop);
        }

        public override void BuildMotherBoard()
        {
            Computer.MotherBoard = "Asus P6X58D Premium";
        }

        public override void BuildScreen()
        {
            Computer.Screen = "1980*1200";
        }

        public override void BuildHarddisk()
        {
            Computer.HardDisk = "2TB";
        }

        public override void BuildProcessor()
        {
            Computer.Processor = "Intel Xeon 7500";
        }
    }
}
