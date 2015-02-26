using System;

namespace VisitorDesignPattern
{
    public class Teletalk : IModem
    {
        public void Connect()
        {
            Console.WriteLine("Teletalk Modem Successfully connected");
        }

        public void Disconnect()
        {
            Console.WriteLine("Teletalk Modem Successfully disconnected");
        }
        public void ConfigureForUnix()
        {

        }

        public void ConfigureForWindows()
        {
            
        }

        public void ConfigureForMacOs()
        {
            
        }
    }
}
