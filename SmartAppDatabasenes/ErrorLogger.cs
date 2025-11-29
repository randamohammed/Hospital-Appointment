using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartAppDatabasenes
{
    public class ErrorLogger
    {

        private const string SourceName = "SmartAppointmentApplication";
        public static void LogErrorToEventLog(string message)
        {
            try
            {
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Application");
                }

                EventLog.WriteEntry(SourceName, message, EventLogEntryType.Error);
            }
            catch (Exception e)
            {
            }
        }
    }
}
