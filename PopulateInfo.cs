using ExchangeRate.Dtos;
using ExchangeRate.Models;
using System.Collections.Generic;
using System.Linq;

namespace ExchangeRate
{
    public class PopulateInfo
    {
        public InfoDto ReturnInfo(List<DateRate> rates)
        {
            InfoDto info = new InfoDto();
            if (rates.Count > 0)
            {
                rates.Sort(((x, y) => x.Rate.CompareTo(y.Rate)));
                info.MinRateAmount = rates[0].Rate;
                info.MinRateDate = rates[0].Date;
                info.maxRateAmount = rates[rates.Count - 1].Rate;
                info.MaxRateDate = rates[rates.Count - 1].Date;
                info.AverageRate = rates.Average(r => r.Rate);
                info.NumberOfDifferentAmounts = rates.Count;
            }

            return info;
        }
    }
}
