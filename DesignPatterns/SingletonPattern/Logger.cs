using System;

namespace SingletonPattern
{
    public class Logger
    {
        private static Logger logger;

        public enum Level
        {
            INFO,
            WARNING,
            CRITICAL
        }
        /// <summary>
        /// Prevents the object from being instantiated outside of this class.
        /// </summary>
        private Logger()
        {

        }

        /// <summary>
        /// Returns the single instance of logger.
        /// </summary>
        /// <returns>The logger instance.</returns>
        public static Logger GetInstance()
        {
            if (logger == null)
            {
                logger = new Logger();
            }
            
            return logger;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void LoggerPrint(Level severity, string message)
        {
            Console.WriteLine("[" + severity.ToString() + "] ".PadRight(10-severity.ToString().Length,' ') + message);
        }
    }
}
