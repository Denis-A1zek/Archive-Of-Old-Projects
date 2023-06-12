using Diplom.EasyTest.App.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.EasyTest.Infrastructure.File
{
    public class JsonFileBuilder : IQuizFileBuilder
    {
        public async void Build(Quiz quiz,string path)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                var task = Task.Factory.StartNew(() => serializer.Serialize(writer, quiz));
                task.Wait();
            }
        }

        public async Task<Quiz> Load(string path)
        {
            Quiz quiz;
            using (StreamReader sw = new StreamReader(path))
            {
                 quiz = JsonConvert.DeserializeObject<Quiz>(sw.ReadToEnd());

            }

            return quiz;
        }
    }
}
