using System;

namespace Core.Entities
{
    public class CurrencyRate
    {
        public int Id { get; set; }
        public Currency BaseCurrency { get; set; }
        public Currency TargetCurrency { get; set; }
        public DateTime RateDate { get; set; }
        public Decimal Rate { get; set; }

    }
}