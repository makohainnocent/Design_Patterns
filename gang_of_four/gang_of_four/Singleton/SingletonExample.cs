using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gang_of_four.Singleton
{
    public static class SingletonExample
    {

        public static void SingletonExample1()
        {
            var logger1 = Logger.GetInstance();
            var logger2 = Logger.GetInstance();
            Console.WriteLine(logger1 == logger2);
        }
    }

    public class Logger
    {
        public static Logger instance;

        private Logger() {
         
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }
}
