namespace ExchangeRate.Dtos
{
    public class InfoDto
    {
        public double MinRateAmount { get; set; }
        public string MinRateDate { get; set; }
        public double maxRateAmount { get; set; }
        public string MaxRateDate { get; set; }
        public double AverageRate { get; set; }
        public int NumberOfDifferentAmounts { get; set; }
    }
}
