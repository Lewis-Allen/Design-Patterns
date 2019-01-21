namespace SingletonPattern
{
    public class Client
    {
        public static void Main()
        {
            Logger logger = Logger.GetInstance();
            logger.LoggerPrint(Logger.Level.INFO, "Starting program.");

            logger.LoggerPrint(Logger.Level.WARNING, "Approaching dangerous levels of code spaghetti");

            logger.LoggerPrint(Logger.Level.CRITICAL, "This code is unsalvageable");
        }
    }
}
