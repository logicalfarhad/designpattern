using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainofResponsibility.Demo
{
    public class DemoMain
    {
        //static void Main(string[] args)
        //{
        //    // Build the chain of responsibility
        //    Logger logger, logger1, logger2;
        //    logger = new ConsoleLogger(LogLevel.All);
        //    logger1 = logger.SetNext(new EmailLogger(LogLevel.FunctionalMessage | LogLevel.FunctionalError));
        //    logger2 = logger1.SetNext(new FileLogger(LogLevel.Warning | LogLevel.Error));

        //    // Handled by ConsoleLogger
        //    logger.Message("Entering function ProcessOrder().", LogLevel.Debug);
        //    logger.Message("Order record retrieved.", LogLevel.Info);

        //    // Handled by ConsoleLogger and FileLogger
        //    logger.Message("Customer Address details missing in Branch DataBase.", LogLevel.Warning);
        //    logger.Message("Customer Address details missing in Organization DataBase.", LogLevel.Error);

        //    // Handled by ConsoleLogger and EmailLogger
        //    logger.Message("Unable to Process Order ORD1 Dated D1 For Customer C1.", LogLevel.FunctionalError);

        //    // Handled by ConsoleLogger and EmailLogger
        //    logger.Message("Order Dispatched.", LogLevel.FunctionalMessage);
        //}
    }


    public enum LogLevel
    {
        Info = 1,
        Debug = 2,
        Warning = 4,
        Error = 8,
        FunctionalMessage = 16,
        FunctionalError = 32,
        All = 63
    }

    /// <summary>
    /// Abstract Handler in chain of responsibility Pattern
    /// </summary>
    public abstract class Logger
    {
        protected LogLevel logMask;

        // The next Handler in the chain
        protected Logger next;

        public Logger(LogLevel mask)
        {
            this.logMask = mask;
        }

        /// <summary>
        /// Sets the Next logger to make a list/chain of Handlers
        /// </summary>
        public Logger SetNext(Logger nextlogger)
        {
            next = nextlogger;
            return nextlogger;
        }

        public void Message(string msg, LogLevel severity)
        {
            if ((severity & logMask) != 0)
            {
                WriteMessage(msg);
            }
            if (next != null)
            {
                next.Message(msg, severity);
            }
        }

        abstract protected void WriteMessage(string msg);
    }

    public class ConsoleLogger : Logger
    {
        public ConsoleLogger(LogLevel mask)
            : base(mask)
        { }

        protected override void WriteMessage(string msg)
        {
            Console.WriteLine("Writing to console: " + msg);
        }
    }

    public class EmailLogger : Logger
    {
        public EmailLogger(LogLevel mask)
            : base(mask)
        { }

        protected override void WriteMessage(string msg)
        {
            //Placeholder for mail send logic, usually the email configurations are saved in config file.
            Console.WriteLine("Sending via email: " + msg);
        }
    }

    class FileLogger : Logger
    {
        public FileLogger(LogLevel mask)
            : base(mask)
        { }

        protected override void WriteMessage(string msg)
        {
            //Placeholder for File writing logic
            Console.WriteLine("Writing to Log File: " + msg);
        }
    }
}
