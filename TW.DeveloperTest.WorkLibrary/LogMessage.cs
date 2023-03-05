using System;
using TW.DeveloperTest.Contracts;

namespace TW.DeveloperTest.WorkLibrary
{
    public class LogMessage : ILogMessage
    {
        public LogMessage()
        {
            Id = new Guid().ToString();
        }

        public string Id { get; set; }
        public string Message { get; set; }
        public LogLevel LogLevel { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}