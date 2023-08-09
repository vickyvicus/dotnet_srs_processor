using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Utils
{
    public class DateRange
    {
        public DateRange(DateTime fromDate, DateTime toDate)
        {
            FromDate = fromDate;
            ToDate = toDate;
        }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
