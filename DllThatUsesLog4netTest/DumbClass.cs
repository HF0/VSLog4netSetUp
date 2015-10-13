using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllThatUsesLog4netTest
{
    public class DumbClass
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(DumbClass));

        public DumbClass()
        {


        }

        public void dumbOperation()
        {
            log.InfoFormat("This is a message from a dll");
        }

    }
}
