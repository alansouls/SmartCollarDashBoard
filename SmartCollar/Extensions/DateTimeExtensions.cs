using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCollar.Extentions
{
    public static class DateTimeExtensions
    {
        public static bool Between(this DateTime date, DateTime start, DateTime end)
        {
            return date >= start && date <= end;
        }
    }
}
