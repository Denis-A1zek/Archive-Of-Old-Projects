using System.Reflection;

namespace Config.Console.Provider
{
    public class ConfigProvider 
    {
        public ConfigProvider(string path ,Configuration config)
        {
            Config = config;
            Path = path;
            SaveHandler = new ConfigSaveHandler(this);
            ReadHandler = new ConfigReadHandler(this);

        }

        public string Path { get; set; }

        public Configuration Config { get; private set; }

        public IConfigSaveHandler SaveHandler { get; private set; }
        public IConfigReadHandler ReadHandler { get; private set; }
        
    }
}
