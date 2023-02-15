namespace Interfaces
{
    internal class Program
    {
        /// <summary>
        /// Simulate getting <see cref="ILogger"/> from DI
        /// </summary>
        /// <returns></returns>
        static ILogger GetLogger()
        {
            return new ConsoleLogger
            {
                LogLevel = LogLevel.Debug
            };
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Replaced with real DI
            var logger = GetLogger();

            logger.OnLogMessage += (message, level) =>
            {
                Console.WriteLine("We listen to a message about to be logged...");
                Console.WriteLine($"    '{message}' > {level}");
            };

            var a = new string[3];
            var b = a[2];

            // Log It
            logger.LogMessage("Say something verbose");
            logger.LogMessage("Say something Debug", LogLevel.Debug);
        }
        /// <summary>
        /// Example of an interface/ A logger Interface
        /// </summary>
        public interface ILogger
        {
            
            #region Public Properties
            /// <summary>
            /// Defines the log output level
            /// </summary>
            LogLevel LogLevel { get; set; }
            #endregion
            public event Action<string, LogLevel> OnLogMessage;
            /// <summary>
            /// Logs the specified message
            /// </summary>
            /// <param name="message">The message</param>
            /// <param name="level">The log level of the message</param>
            void LogMessage(string message, LogLevel level = LogLevel.Verbose);
        }
        public enum LogLevel 
        {
            Verbose = 0,
            Debug = 1,
            Critical = 2
        }
        /// <summary>
        /// A Logger that writes to the console
        /// </summary>
        public class ConsoleLogger : ILogger
        {
            #region Public Properties
            /// <summary>
            /// Defines the log output level
            /// </summary>
            public LogLevel LogLevel { get; set; }
            #endregion
            #region Public Events
            /// <summary>
            /// The event that is fired when a message is to be loged
            /// </summary>
            public event Action<string, LogLevel> OnLogMessage = (message, level) => { };
            #endregion
            #region Public Methods
            /// <summary>
            /// Logs the message to the console
            /// </summary>
            /// <param name="message">The message</param>
            public void LogMessage(string message, LogLevel level)
            {
                // If this message is important enough
                if (level >= LogLevel)
                    {
                        //Inform listeners
                        OnLogMessage(message, level);
                        // Log it
                        Console.WriteLine($"Console logger says: '{message}'");
                    }
            }
            #endregion
        }
        /// <summary>
        /// A Logger that writes to a file
        /// </summary>
        public class FileLogger : ILogger
        {
            #region Private members
            /// <summary>
            /// The path to log to
            /// </summary>
            private readonly string mlogPath;
            #endregion
            #region Public Properties
            /// <summary>
            /// Defines the log output level
            /// </summary>
            public LogLevel LogLevel { get; set; }
            #endregion
            #region Public Events
            /// <summary>
            /// The event that is fired when a message is to be loged
            /// </summary>
            public event Action<string, LogLevel> OnLogMessage = (message, level) => { };
            #endregion
            #region Constructor
            /// <summary>
            /// Default constructor
            /// </summary>
            ///<param name="logPath">The path to log</param>
            public FileLogger(string logPath)
            {
                // Set the log path
                mlogPath = logPath;

                // Get the folder of a log path
                var directory = Path.GetDirectoryName(mlogPath);

                //Enshure the folder exists
                Directory.CreateDirectory(directory);
            }
            #endregion
            /// <summary>
            /// Writes the message to the end of file
            /// </summary>
            /// <param name="message">The message</param>
            /// <param name="level">The message log level</param>
            public void LogMessage(string message, LogLevel level)
            {
                // If this message is important enough
                if (level >= LogLevel)
                {
                    //Inform listeners
                    OnLogMessage(message, level);
                    //Open log file
                    using (var fileStream = new StreamWriter(File.OpenWrite(mlogPath)))
                    {
                        //Move to the end of file
                        fileStream.BaseStream.Seek(0, SeekOrigin.End);
                        //Write a new line
                        fileStream.WriteLine(message);
                    }
                }
            }
        }
    }
}