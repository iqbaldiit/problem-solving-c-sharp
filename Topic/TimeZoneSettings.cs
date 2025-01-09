using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.Topic
{
    public static class TimeZoneSettings
    {
        public static TimeZoneInfo AppTimeZone { get; private set; }
        static TimeZoneSettings()
        {
            AppTimeZone = TimeZoneInfo.FindSystemTimeZoneById("W. Central Africa Standard Time");
        }
        public static DateTime getNigeriaTime() { 
            return TimeZoneInfo.ConvertTimeToUtc(DateTime.UtcNow,AppTimeZone);
        }
    }
}
