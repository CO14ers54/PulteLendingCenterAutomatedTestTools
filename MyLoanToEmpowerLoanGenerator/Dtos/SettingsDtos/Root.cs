using System.Collections.Generic;

namespace MyLoanToEmpowerLoanGenerator.Dtos.SettingsDtos
{
    public class Root
    {
        public AppSettingsDto AppSettingsDto { get; set; }
        public Dictionary<string, string> ConnectionStringDictionary { get; set; }
        public Dictionary<string, string> MyLoanQuestionnaireXmlTemplateFileDictionary { get; set; }
    }
}
