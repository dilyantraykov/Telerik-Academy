using System;
using log4net;
using log4net.Config;

namespace TestingLog4Net
{
    class Log4NetTest
    {
        private static readonly ILog Logger =
           LogManager.GetLogger(typeof(Log4NetTest));

        static void Main(string[] args)
        {
            XmlConfigurator.Configure();

            // User login attempt

            try
            {
                throw new ArgumentException("Wrong username!");
                Console.WriteLine("Logging in...");
                // log in user
                Logger.Info("User successfully logged!");
                Console.WriteLine("User successfully logged!");
            }
            catch(Exception e)
            {
                Console.WriteLine("Wrong user credentials!");
                // failed login
                Logger.Error("Wrong user credentials!", e);
            }

        }
    }
}
