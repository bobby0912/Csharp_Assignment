//df/**Decorator Pattern in a Logger System**

//using c__Assignment;

//Implement an `ILogger` interface and `FileLogger` class. Use the **Decorator Pattern** to add extra logging features like timestamp and error categorization.




using System;

namespace c__Assignment
{
    interface ILogger
    {
        void Log(string message);
    }

    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"FileLogger: {message}");
        }
    }

    abstract class LoggerDecorator : ILogger
    {
        protected ILogger _logger;

        public LoggerDecorator(ILogger logger)
        {
            _logger = logger;
        }

        public virtual void Log(string message)
        {
            _logger.Log(message);
        }
    }

    class TimestampLogger : LoggerDecorator
    {
        public TimestampLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            string timestampedMessage = $"{DateTime.Now}: {message}";
            base.Log(timestampedMessage);
        }
    }

    class ErrorCategorizationLogger : LoggerDecorator
    {
        public ErrorCategorizationLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            string categorizedMessage = $"[Error]: {message}";
            base.Log(categorizedMessage);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new FileLogger();

            // Add timestamp feature
            logger = new TimestampLogger(logger);

            // Add error categorization feature
            logger = new ErrorCategorizationLogger(logger);

            logger.Log("This is a log message."); // Output: [Error]: 2023-10-10 10:10:10: This is a log message.
        }
    }
}


