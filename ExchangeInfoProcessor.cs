
using ExchangeRate.Models;
using System;
using System.Net.Http;

using System.Threading.Tasks;

namespace ExchangeRate
{
    public class ExchangeInfoProcessor
    {
        public static async Task<ExchangeInfo> LoadData(string from, string to, string date)
        {
            string url = $"https://api.exchangerate.host/convert?from={from}&to={to}&date={date}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<ExchangeInfo>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
