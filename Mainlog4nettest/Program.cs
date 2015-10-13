using DllThatUsesLog4netTest;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mainlog4nettest
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            log.InfoFormat("Logger started");

            DumbClass dumbInstance = new DumbClass();
            dumbInstance.dumbOperation();

            Console.ReadKey();
        }
    }
}
