using System;
using TW.DeveloperTest.Contracts;

namespace TW.DeveloperTest.WorkLibrary
{
    public class Logger : ILogger
    {
        public string Id { get; set; }
        public void Log(ILogMessage message)
        {
            Console.WriteLine($"LoggerId:{Id}\n" +
                              $"MessageId:{message.Id}\n" +
                              $"Message:{message.Message}");
        }
        
        public Logger()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}