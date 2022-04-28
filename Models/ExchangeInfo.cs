using System.Collections.Generic;

namespace ExchangeRate.Models
{
    public class ExchangeInfo
    {
        public bool Success { get; set; }
        //public string Base { get; set; }
        public string Date { get; set; }
        public double? Result { get; set; }
        //public List<Rate> Rates { get; set; }
        public double ResultDisplay {
            get { return Result == null ? (double)Result : -1; }  
        }
    }
}
