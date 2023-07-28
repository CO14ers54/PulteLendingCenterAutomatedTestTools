using MyLoanToEmpowerLoanGenerator.Dtos.SettingsDtos;
using Newtonsoft.Json;
using System.IO;

namespace MyLoanToEmpowerLoanGenerator
{
    public sealed class Settings
    {
        private readonly Root _settingsDto;
        private static Settings instance;
        private static readonly object padlock = new object();

        private Settings()
        {
            string jsonFile = Directory.GetCurrentDirectory() + @"\appsettings.json";
            string data = File.ReadAllText(jsonFile);

            _settingsDto = JsonConvert.DeserializeObject<Root>(data);
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

        public Root SettingsDto
        {
            get { return _settingsDto; }
        }
    }
}
