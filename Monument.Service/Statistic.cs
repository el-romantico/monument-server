using System;

namespace Monument.Service
{
    public class Statistic
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longtitude { get; set; }
        public string Locale { get; set; }
    }
}
