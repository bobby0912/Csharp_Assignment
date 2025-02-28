//**Thread - Safe Singleton Pattern for Configuration Management**

//Implement a Singleton class `ConfigurationManager` that prevents multiple instances. Ensure it is thread-safe.



using System;

namespace c__Assignment
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager _instance = null;
        private static readonly object _lock = new object();

        public string Configuration { get; private set; }

        // Private constructor to prevent instantiation
        private ConfigurationManager()
        {
            // Initialize configuration settings
            Configuration = "Default Configuration";
        }

        public static ConfigurationManager Instance
        {
            get
            {
                // Double-checked locking to ensure thread safety
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ConfigurationManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public void SetConfiguration(string config)
        {
            Configuration = config;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Access the singleton instance
            ConfigurationManager configManager1 = ConfigurationManager.Instance;
            Console.WriteLine(configManager1.Configuration); // Output: Default Configuration

            // Modify the configuration
            configManager1.SetConfiguration("New Configuration");

            // Access the singleton instance again
            ConfigurationManager configManager2 = ConfigurationManager.Instance;
            Console.WriteLine(configManager2.Configuration); // Output: New Configuration
        }
    }
}



