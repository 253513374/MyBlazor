using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazor.Data
{
    public class QueryCriteria
    {
        public QueryCriteria() {

            DateTime utctime = DateTime.UtcNow;

            TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");
             var time = TimeZoneInfo.ConvertTimeFromUtc(utctime, cstZone);
            BeingTime = time.AddDays(-(time.Day-1));
            EndTime = time;
        }
        public DateTime BeingTime { set; get; }

        public DateTime EndTime { set; get; }

        public string  ReprotEnumSelect { set; get; }



    }
}
