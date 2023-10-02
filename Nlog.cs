using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNlog
{
    internal class Nlog
    {
        public static readonly Logger logger =
            LogManager.GetCurrentClassLogger();
        public void LogInfo(string message)
        {
            logger.Info(message);
        }
        public void LogError(string message)
        {
            logger.Error(message);
        }
    }
}
