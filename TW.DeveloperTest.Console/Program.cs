using System;
using System.Threading;
using TW.DeveloperTest.Contracts;
using TW.DeveloperTest.WorkLibrary;

namespace TW.DeveloperTest.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            IWorker worker = Ioc.Resolve<IWorker>();
            var logger = Ioc.Resolve<ILogger>();

            do
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Modifiers.HasFlag(ConsoleModifiers.Control)
                        && key.Key == ConsoleKey.X)
                    {
                        run = false;
                    }
                }

                try
                {
                    var result = worker.GetResult();

                    //TODO replace with logging library
                    logger.Log(new LogMessage
                    {
                        Message = $"output - {result}",
                        LogLevel = LogLevel.Information,
                        TimeStamp = DateTime.Now
                    });
                    //Console.WriteLine($"output - {result}");
                }
                catch (Exception e)
                {
                    //TODO replace with logging library
                    logger.Log(new LogMessage
                    {
                        Message = $"error - {e.Message}",
                        LogLevel = LogLevel.Error,
                        TimeStamp = DateTime.Now
                    });
                    //Console.WriteLine($"error - {e.Message}");
                }
                
                Thread.Sleep(500);
            } while (run);
        }
    }
}
