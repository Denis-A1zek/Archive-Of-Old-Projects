using Config.Console.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Config.Console.Provider
{
    public class ConfigSaveHandler : IConfigSaveHandler
    {
        private ConfigProvider _provider;
        public ConfigSaveHandler(ConfigProvider provider)
        {
            _provider = provider;
        }

        public void Save()
        {
            var properties = GetPropertiesInfo();

            using (StreamWriter write = new(_provider.Path, false))
            {
                foreach (var property in properties)
                {
                    write.WriteLine($"{property.Name}={property.GetValue(_provider.Config)};");
                }
            }
        }

        private PropertyInfo[] GetPropertiesInfo()
        {
            Type configType = _provider.Config.GetType();
            PropertyInfo[] properties = configType.GetProperties();

            return properties;
        }
    }
}
