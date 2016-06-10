using System;
using System.Collections.Generic;
using System.Linq;

namespace Monument.Service
{
    public static class DataService
    {
        private static List<Statistic> _statistics { get; set; } = new List<Statistic>();

        public static string GetData(int id, string locale)
        {
            var statistic = new Statistic() { Id = id, Locale = locale.ToUpper(), Time = DateTime.Now };
            var result = string.Empty;
            if (locale.ToLower() == "bg")
            {
                switch (id)
                {
                    case 1:
                        statistic.Latitude = 42.6911707M;
                        statistic.Longtitude = 23.3212481M;
                        result = StaticData.StaticData.NevskiBG;
                        break;
                    case 2:
                        statistic.Latitude = 42.6943839M;
                        statistic.Longtitude = 23.3240113M;
                        result = StaticData.StaticData.VazovBG;
                        break;
                    case 3:
                        statistic.Latitude = 42.684729M;
                        statistic.Longtitude = 23.3167497M;
                        result = StaticData.StaticData.NdkBG;
                        break;
                    case 4:
                        statistic.Latitude = 42.6910288M;
                        statistic.Longtitude = 23.3277433M;
                        result = StaticData.StaticData.SuBG;
                        break;
                    default:
                        result = string.Empty;
                        break;
                }
            }
            else
            {
                switch (id)
                {
                    case 1:
                        statistic.Latitude = 42.6911707M;
                        statistic.Longtitude = 23.3212481M;
                        result = StaticData.StaticData.NevskiBG;
                        break;
                    case 2:
                        statistic.Latitude = 42.6943839M;
                        statistic.Longtitude = 23.3240113M;
                        result = StaticData.StaticData.VazovEN;
                        break;
                    case 3:
                        statistic.Latitude = 42.684729M;
                        statistic.Longtitude = 23.3167497M;
                        result = StaticData.StaticData.NdkEN;
                        break;
                    case 4:
                        statistic.Latitude = 42.6910288M;
                        statistic.Longtitude = 23.3277433M;
                        result = StaticData.StaticData.SuEN;
                        break;
                    default:
                        result = string.Empty;
                        break;
                }
            }
            _statistics.Add(statistic);
            return result;
        }

        public static List<Statistic> GetStats()
        {
            return _statistics.OrderByDescending(x => x.Time).ToList();
        }
    }
}
