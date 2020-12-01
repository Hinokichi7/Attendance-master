using System.Configuration;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_APP
{
    public static class AppConfigUtil
    {
        static DateTime StartTime { get; set; } 
        static DateTime endTime { get; set; }
        private static void GetBaseTime()
        {
            //StartTime = ConfigurationManager.AppSettings.Get("Key0");
        }
    }
}
