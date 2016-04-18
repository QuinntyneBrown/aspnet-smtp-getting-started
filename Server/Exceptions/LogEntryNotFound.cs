using System;

namespace Chloe.Server.Exceptions
{
    public class LogEntryNotFoundException: NotFoundException
    {
        public LogEntryNotFoundException()
            :base("Log Entry Not Found")
        {
        }

        public LogEntryNotFoundException(string message)
            :base(message)
        {

        }

        public LogEntryNotFoundException(string message, Exception inner)
        {

        }
    }
}
