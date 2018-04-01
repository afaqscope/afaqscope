using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class Log
{
    private static string logFile = AppDomain.CurrentDomain.BaseDirectory + "log.txt";

    public Log()
    {
        if (!File.Exists(logFile))
        {
            File.Create(logFile);
        }
    }
    public static void writeToLog(string methodName, string trace, string message)
    {
        string logEntry = " In Method : " + methodName + Environment.NewLine +
            " Trace : " + trace + Environment.NewLine + " Error Message : " + message;

        File.AppendAllText(logFile, logEntry);
    }
}
