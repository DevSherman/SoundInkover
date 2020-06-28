using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static SoundInvoker.MainForm;

namespace SoundInvoker
{
    public static class Extensions
    {
        public static SoundItem Load(string name)
        {
            using (StreamReader r = new StreamReader($"data//{name}.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<SoundItem>(json);
            }
        }
        public static void SaveJsonFile(SoundItem data, string name)
        {
            using (StreamWriter file = File.CreateText($"data//{name}.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                byte[] bytes = Encoding.UTF8.GetBytes(data.ToString());
                serializer.Serialize(file, data);
            }
        }
        public static void SaveOptions(Options data)
        {
            using (StreamWriter file = File.CreateText("options.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                byte[] bytes = Encoding.UTF8.GetBytes(data.ToString());
                serializer.Serialize(file, data);
            }
        }
        public static Options LoadOptions()
        {
            using (StreamReader r = new StreamReader("options.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<Options>(json);
            }
        }
    }
}
