using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulteLendingCenterAutomatedTestRunner
{
    public sealed class DBLogger
    {
        private static DBLogger instance;
        private static readonly object padlock = new object();

        public static DBLogger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DBLogger();
                    }
                    return instance;
                }
            }
        }

        public void WriteLogMessage(string testSuiteName, string runConfiguration, string reportName, string logMessage, string logMessageType)
        {
         /*
            string connectionString = Settings.Instance.SettingsDto.ConnectionStringDictionary["TestAutomationDb"];
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_WriteLogMessage_insert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@applicationUnderTest", SqlDbType.VarChar).Value = "Pulte Lending Center";
                    cmd.Parameters.Add("@testSuiteName", SqlDbType.VarChar).Value = testSuiteName;
                    cmd.Parameters.Add("@runConfiguration", SqlDbType.VarChar).Value = runConfiguration;
                    cmd.Parameters.Add("@reportName", SqlDbType.VarChar).Value = reportName;
                    cmd.Parameters.Add("@logMessage", SqlDbType.Text).Value = logMessage;
                    cmd.Parameters.Add("@logMessageType", SqlDbType.VarChar).Value = logMessageType;
                    cmd.Parameters.Add("@logMessageTime", SqlDbType.DateTime2).Value = DateTime.Now;
                    cmd.Parameters.Add("@runByUsername", SqlDbType.VarChar).Value = Environment.GetEnvironmentVariable("USERNAME");

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
         */
        }
    }
}
