using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcScheduledTestRunner.Dtos.SettingsDtos
{
    public class Root
    {
        public AppSettingsDto AppSettingsDto { get; set; }
        public List<EmailDto> EmailDtos { get; set; }
        public Dictionary<string, string> ConnectionStringDictionary { get; set; }
    }
}
