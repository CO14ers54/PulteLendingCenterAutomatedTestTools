namespace PlcScheduledTestRunner.Dtos.SettingsDtos
{
    public class AppSettingsDto
    {
        public string Environment { get; set; }
        public string RanorexReportsDirectoryName { get; set; }
        public string PlcIntegrationTestsExecutablesRootPath { get; set; }
        public int TotalNumberOfTests { get; set; }
    }
}
