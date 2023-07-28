using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulteLendingCenterAutomatedTestRunner
{
    static class Program
    {
        public static IConfiguration Configuration;

        [STAThread]
        static void Main(string[] args)
        {
            Configuration = new ConfigurationBuilder()
              .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true)
              .Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
