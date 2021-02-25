using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfromanceMonitor.WinForms
{
    public class Configuration
    {
        public static Configuration Instance { get; private set; } = new Configuration();
        public static string DefaultFilePath { get; set; }

        static Configuration()
        {
            DefaultFilePath = Path.Combine(Environment.CurrentDirectory, "config.json");
        }

        public List<(string category, string instance, string counter)> Counters { get; set; }
        public TimeSpan SamplingInterval { get; set; } = TimeSpan.FromSeconds(10);
        public TimeSpan VisibleTimeRange { get; set; } = TimeSpan.FromMinutes(5);

        public static void LoadIfExists()
        {
            LoadIfExists(DefaultFilePath);
        }

        public static void Load()
        {
            Load(DefaultFilePath);
        }

        public static void LoadIfExists(string path)
        {
            if (File.Exists(path))
                Load(path);
        }

        public static void Load(string path)
        {
            Instance = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(path));
        }

        public void Save()
        {
            Save(DefaultFilePath);
        }

        public void Save(string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(this));
        }
    }
}
