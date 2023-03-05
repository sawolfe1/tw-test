using System;

namespace TW.DeveloperTest.Contracts
{
    public interface ILogger
    {
        string Id { get; set; }
        void Log(ILogMessage message);
    }
}