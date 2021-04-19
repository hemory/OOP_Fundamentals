using System;
using System.Collections.Generic;

namespace ACM.Common
{
    public static class LoggingService
    {
        public static string WriteToFile(List<ILoggable> itemsToLog) // refactor to write to a text file
        {
            var result = string.Empty;
            foreach (var item in itemsToLog)
            {
                result += $"{item} ";
            }

            result = result.Trim();
            return result;
        }
    }
}