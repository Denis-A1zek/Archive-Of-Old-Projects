using Config.Console.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config.Console.Provider
{
    public class ConfigReadHandler : IConfigReadHandler
    {
        private ConfigProvider _provider;
        public ConfigReadHandler(ConfigProvider provider)
        {
            _provider = provider;
        }
        public Configuration Read()
        {
            var config = new Configuration();

            var configType = config.GetType();

            using (StreamReader reader = new(_provider.Path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    var buffer = line.AsSpan();
                    var propName = new string(line.TakeWhile(x => x != '=').ToArray());
                    var prop = configType.GetProperty(propName);

                    var value = new string(line.SkipWhile(x => x != '=').ToArray()).TrimStart('=').TrimEnd(';');

                    prop?.SetValue(config, GetValidValue(value));
                }
            }

            return config;
        }

        private object GetValidValue(string value)
        {
            if (ConvertToBoolean(value, out bool boolResult))
                return boolResult;
            return value;
        }

        private bool ConvertToBoolean(string value, out bool result)
        {
            return bool.TryParse(value, out result);
        }
    }
}
