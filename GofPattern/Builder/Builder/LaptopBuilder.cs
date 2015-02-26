namespace Builder.Builder
{
    public class LaptopBuilder : ComputerBuilder
    {
        public LaptopBuilder()
        {
            Computer = new Computer(ComputerType.Laptop);
        }

        public override void BuildMotherBoard()
        {
            Computer.MotherBoard = "Dell Motherboard";
        }

        public override void BuildScreen()
        {
            Computer.Screen = "1280*800";
        }

        public override void BuildHarddisk()
        {
            Computer.HardDisk = "250GB";
        }

        public override void BuildProcessor()
        {
            Computer.Processor = "Intel Core 2 Duo";
        }
    }
}
