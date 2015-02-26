namespace Singleton
{
    public class Singleton
    {
        private static Singleton uniqueInstance;
        private static readonly object _lock = new object();
        private Singleton() { }
        public static Singleton CreateInstance()
        {
            if (uniqueInstance == null)//double checked lock
            {
                lock (_lock)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new Singleton();
                    }
                }
            }
            return uniqueInstance;
        }
    }
}