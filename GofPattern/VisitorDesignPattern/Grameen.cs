using System;

namespace VisitorDesignPattern
{
    public class Grameen : IModem
    {
        public void Connect()
        {
            Console.WriteLine("Grameen Modem Successfully connected");
        }
        public void Disconnect()
        {
            Console.WriteLine("Grameen Modem Successfully disconnected");
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
