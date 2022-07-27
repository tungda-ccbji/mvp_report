using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MVP.Generate.Excel.Entities
{
    public class DateRangeInput
    {
        public string DateRange
        {
            get
            {
                return $"{Start:yyyy年MM月dd日} - {End:yyyy年MM月dd日}";
            }
        }
        [JsonProperty("start_date")]
        public string StartDate { set; get; }
        [JsonProperty("end_date")]
        public string EndDate { set; get; }

        public DateTime Start
        {
            get
            {
                if (DateTime.TryParseExact(StartDate, "yyyy/MM/dd", null, DateTimeStyles.None,
                    out DateTime date))
                {
                    return date;
                }

                return DateTime.MinValue;
            }
        }

        public DateTime End
        {
            get
            {
                if (DateTime.TryParseExact(EndDate, "yyyy/MM/dd", null, DateTimeStyles.None,
                    out DateTime date))
                {
                    return date;
                }

                return DateTime.MinValue;
            }
        }
    }
}
