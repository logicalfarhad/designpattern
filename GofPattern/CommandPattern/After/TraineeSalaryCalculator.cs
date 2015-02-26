namespace CommandPattern.After
{
    public class TraineeSalaryCalculator : ISalaryCalculator
    {
        public double Calculate(double baseSalary)
        {
            return CalculateTraineeSalary(baseSalary);
        }

        private static double CalculateTraineeSalary(double baseSalary)
        {
            return baseSalary / 2;
        }
    }
}