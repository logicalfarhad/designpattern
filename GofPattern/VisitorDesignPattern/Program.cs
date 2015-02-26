using System;

namespace VisitorDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IModem modem; //the modem interface

            /*For Citycell modem*/
            modem = new Zoom();
            modem.Connect();
            modem.Disconnect();

            /*For Teletalk modem*/
            modem = new Teletalk();
            modem.Connect();
            modem.Disconnect();

            /*For Grameen modem*/
            modem = new Grameen();
            modem.Connect();
            modem.Disconnect();

            Console.ReadLine();
        }
    }
}
