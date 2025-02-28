//**Thread - Safe Singleton Pattern for Configuration Management**

//Implement a Singleton class `ConfigurationManager` that prevents multiple instances.
//Ensure it is thread-safe.



using System;

namespace c__Assignment
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager _instance = null;
        private static readonly object _lock = new object();

        public string Configuration { get; private set; }

        private ConfigurationManager()
        {
            Configuration = "Default Configuration";
        }

        public static ConfigurationManager Instance
        {
            get
            {
                // thread safety
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

    class Program18
    {
        static void Main(string[] args)
        {
            ConfigurationManager configManager1 = ConfigurationManager.Instance;
            Console.WriteLine(configManager1.Configuration);

            configManager1.SetConfiguration("New Configuration");

            ConfigurationManager configManager2 = ConfigurationManager.Instance;
            Console.WriteLine(configManager2.Configuration);
        }
    }
}



