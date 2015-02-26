using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Builder
{
    public class ComputerShop
    {
        public void MakeComputer(ComputerBuilder computerBuilder)
        {
            computerBuilder.BuildMotherBoard();
            computerBuilder.BuildProcessor();
            computerBuilder.BuildHarddisk();
            computerBuilder.BuildScreen();
        }
    }
}
