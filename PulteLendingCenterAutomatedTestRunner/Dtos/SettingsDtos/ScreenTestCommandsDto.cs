using System.Collections.Generic;

namespace PulteLendingCenterAutomatedTestRunner.Dtos.SettingsDtos
{
    public class ScreenTestCommandsDto
    {
        public Dictionary<string, string> ScreenAssetsTestCommandsDictionary { get; set; }
        public Dictionary<string, string> ScreenBorrowerInfoTestCommandsDictionary { get; set; }
        public Dictionary<string, string> ScreenCreditScoreTestCommandsDictionary { get; set; }
        public Dictionary<string, string> ScreenDeclarationsTestCommandsDictionary { get; set; }
        public Dictionary<string, string> ScreenEmploymentAndIncomeTestCommandsDictionary { get; set; }
        public Dictionary<string, string> ScreenLenderLoanInfoTestCommandsDictionary { get; set; }
        public Dictionary<string, string> ScreenLiabilitiesTestCommandsDictionary { get; set; }
        public Dictionary<string, string> ScreenLoanPanelsTestCommandsDictionary { get; set; }
        public Dictionary<string, string> ScreenNavigationTestCommandsDictionary { get; set; }
        public Dictionary<string, string> ScreenQualifyingTheBorrowerTestCommandsDictionary { get; set; }
        public Dictionary<string, string> ScreenReoTestCommandsDictionary { get; set; }
        public Dictionary<string, string> ScreenSavingsPlanTestCommandsDictionary { get; set; }
        public Dictionary<string, string> ScreenSubjectPropertyTestCommandsDictionary { get; set; }
        public string ScreenRunAllTests { get; set; }
        public string ScreenRunAllOneUrlaTests { get; set; }
        public string ScreenRunAllValidationTests { get; set; }
        public string ScreenRunAllValidationOneUrlaTests { get; set; }
        public string ScreenRunAllCrudTests { get; set; }
        public string ScreenRunAllCrudOneUrlaTests { get; set; }
        public string ScreenRunAllTwoUrlaTests { get; set; }
        public string ScreenRunAllValidationTwoUrlaTests { get; set; }
        public string ScreenRunAllCrudTwoUrlaTests { get; set; }
    }
}
