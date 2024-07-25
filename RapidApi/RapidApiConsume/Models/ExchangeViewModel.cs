namespace RapidApiConsume.Models
{
    public class ExchangeViewModel
    {
        public Exchange_Rates[] exchange_rates { get; set; }
        public string base_currency_date { get; set; }
        public string base_currency { get; set; }
        public int rating { get; set; } // Yeni eklenen özellik
    }

    public class Exchange_Rates
    {
        public string currency { get; set; }
        public string exchange_rate_buy { get; set; }
    }
}
