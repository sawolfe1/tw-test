using System;

namespace TW.DeveloperTest.Contracts
{
    public interface ILogMessage
    {
        string Id { get; set; } 
        string Message { get; set; }
        LogLevel LogLevel { get; set; }
        DateTime TimeStamp { get; set; }
    }
}