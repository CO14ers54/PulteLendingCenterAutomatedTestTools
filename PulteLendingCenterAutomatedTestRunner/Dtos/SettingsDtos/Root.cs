using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulteLendingCenterAutomatedTestRunner.Dtos.SettingsDtos
{
    public class Root
    {
        public AppSettingsDto AppSettingsDto { get; set; }
        public NotificationSettingsDto NotificationSettingsDto { get; set; }
        public ScreenTestCommandsDto ScreenTestCommandsDto { get; set; }
        public Dictionary<string, string> ConnectionStringDictionary { get; set; }
        public List<EmailDto> EmailDtos { get; set; }
    }
}
