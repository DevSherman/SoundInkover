using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SoundInvoker
{
    public static class Extensions
    {
        public struct TwitchAccount
        {
            public string channel_name;
            public string oauth;
            public bool auto_login;
        }
        public static TwitchAccount LoadAccount()
        {
            if (!File.Exists("account.json")) SaveAccount(new TwitchAccount());

            using (StreamReader r = new StreamReader("account.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<TwitchAccount>(json);
            }
        }
        public static void SaveAccount(TwitchAccount account)
        {
            using (StreamWriter file = File.CreateText($"account.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, account);
            }
        }

        public static List<SoundItem> Load()
        {
            List<SoundItem> list = new List<SoundItem>();

            if (!Directory.Exists("data//")) Directory.CreateDirectory("data//");

            foreach (string file in Directory.EnumerateFiles("data//"))
            {
                using (StreamReader r = new StreamReader(file))
                {
                    string json = r.ReadToEnd();
                    list.Add(JsonConvert.DeserializeObject<SoundItem>(json));
                }
            }
            return list;
        }
        public static void Save(SoundItem data, string name)
        {
            using (StreamWriter file = File.CreateText($"data//{name}.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }
        public static void SaveOptions(Options data)
        {
            using (StreamWriter file = File.CreateText("options.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }
        public static Options LoadOptions()
        {
            if (!File.Exists("options.json")) SaveOptions(new Options());

            using (StreamReader r = new StreamReader("options.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<Options>(json);
            }
        }
        public static string GetValuesBetween(string original, string first, string final)
        {
            int from = original.IndexOf(first) + first.Length;
            int to = original.LastIndexOf(final);

            return original.Substring(from, to - from);
        }
    }
}
