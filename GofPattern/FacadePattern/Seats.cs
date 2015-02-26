using System;

namespace FacadePattern
{
    public class Seats
    {
        public void AddSeats(int num)
        {
            Console.WriteLine("{0} Seats Added", num.ToString());
        }
    }
}