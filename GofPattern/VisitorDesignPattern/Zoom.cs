using System;

namespace VisitorDesignPattern
{
    public class Zoom : IModem
    {
        public void Connect()
        {
            Console.WriteLine("Zoom Modem Successfully connected");
        }

        public void Disconnect()
        {
            Console.WriteLine("Zoom Modem Successfully disconnected");
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
