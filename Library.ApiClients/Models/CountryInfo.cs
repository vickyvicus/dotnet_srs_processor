using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ApiClients.Models
{
    public class CountryInfo
    {
        public int DigitsInPhNo { get; set; }
        public string CountryName { get; set; }
        public string CurrencySymbol { get; set; }
        public int TimeZoneOffsetMinutes { get; set; }
        public string CurrencyName { get; set; }
        public string Language { get; set; }
        public string PhNoPrefix { get; set; }
        public int numberSystem { get; set; }
        public int pinCodeLength { get; set; }

        [NotMapped]
        public TimeSpan TimeZoneOffset
        {
            get
            {
                return TimeSpan.FromMinutes(TimeZoneOffsetMinutes);
            }
            set
            {
                TimeZoneOffsetMinutes = (int)value.TotalMinutes;
            }
        }
    }
}
