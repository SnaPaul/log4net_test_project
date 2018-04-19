using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace log4net_test_project
{
    class Program
    {
        //private static readonly log4net.ILog log = LogHelper.GetLogger(); //log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        static void Main(string[] args)
        {

            log.Debug("Developer: Tutorial was run.");

            log.Info("Maintanance: the water pump turned on.");

            log.Warn("Maintanance: the water pump is getting hot.");

            var i = 0;

            try
            {
                var x = 10 / i;
            }
            catch(DivideByZeroException ex)
            {
                log.Error("Developer: we tried to divide by zero, ...again!!!");
            }

            log.Fatal("Maintanance: water pumb exploded!!!");

        }
    }
}
