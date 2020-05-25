using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;
using System.Configuration;

namespace Hardware_Monitor_Lite
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TaskService ts = new TaskService();
            TaskDefinition td = ts.NewTask();
            td.Principal.RunLevel = TaskRunLevel.Highest;
            td.Triggers.AddNew(TaskTriggerType.Logon);
            //td.Actions.Add(new ExecAction("Path Of your Application File", null));
            td.Actions.Add(new ExecAction(Application.ExecutablePath, null));
            ts.RootFolder.RegisterTaskDefinition("MCU", td);
            if (ConfigurationManager.AppSettings["startTray"].ToString().ToLower().Equals("true"))
            {
                Home fmr = new Home();
                Application.Run();
            }
            else
                Application.Run(new Home());
        }
    }
}
