using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AWI___Automatische_Tests
{
    public class Resources
    {
        public static string GetDateTodayValue()
        {
            return DateTime.Now.ToString("ddMMyyyy");
        }
        
        public static string GetTimeNowValue()
        {
            return DateTime.Now.ToString("HHmm");
        }
    }
}
