using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Builder
{
    public abstract class ComputerBuilder
    {
        public Computer Computer { get; set; }
        public abstract void BuildMotherBoard();
        public abstract void BuildScreen();
        public abstract void BuildHarddisk();
        public abstract void BuildProcessor();

    }
}
