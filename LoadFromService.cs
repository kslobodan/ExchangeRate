using ExchangeRate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeRate
{
    public class LoadFromService
    {
        List<DateRate> _results;
        public async Task<List<DateRate>> LoadData(string[] dates, string from, string to)
        {
            ApiHelper.InitializeClient();
            _results = new List<DateRate>();

            var tasks = dates.Select(date => LoadDataFromService(from, to, date));
            await Task.WhenAll(tasks);

            return _results;

        }

        private async Task LoadDataFromService(string from, string to, string date)
        {
            DateTime testDate;
            if (DateTime.TryParse(date, out testDate))
            {

                var info = await ExchangeInfoProcessor.LoadData(from, to, date);
                if (info != null && info.Success && info.Result != null)
                {
                    double rate = (double)info.Result;
                    DateRate dateRate = new DateRate { Date = date, Rate = rate };
                    _results.Add(dateRate);
                }
            }
        }
    }
}
