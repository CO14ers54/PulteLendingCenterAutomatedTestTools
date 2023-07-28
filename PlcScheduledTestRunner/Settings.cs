using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcScheduledTestRunner
{
    public sealed class Settings
    {
        private readonly Dtos.SettingsDtos.Root _settingsDto;
        private static Settings instance;
        private static readonly object padlock = new object();

        private Settings()
        {
            string jsonFile = Directory.GetCurrentDirectory() + @"\appsettings.json";
            string data = File.ReadAllText(jsonFile);

            _settingsDto = JsonConvert.DeserializeObject<Dtos.SettingsDtos.Root>(data);
        }

        public static Settings Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Settings();
                    }
                    return instance;
                }
            }
        }

        public Dtos.SettingsDtos.Root SettingsDto
        {
            get { return _settingsDto; }
        }
    }
}
