using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_test.Utils
{
    public class TimeHelper
    {
        public double GetDayOfTheYear(System.DateTime date)
        {
            var yearOnly = DateTime.ParseExact(date.Year.ToString("0000"),"yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var result = Math.Floor((date - yearOnly).TotalDays);
            //result=date.DayOfYear;
            return result;
        }
    }
}
