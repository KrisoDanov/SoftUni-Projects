using System;
using System.Collections.Generic;
using System.Text;

namespace DateCalc
{
    class DateModifier
    {
        public int GetDaysDiff(string startDateString, string endDateString)
        {
            DateTime startDate = DateTime.Parse(startDateString);
            DateTime endDate = DateTime.Parse(endDateString);
            int totalDays = (int)(startDate - endDate).TotalDays;
            return totalDays;
        }
    }
}
