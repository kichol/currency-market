using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class CurrencyExchangeContext : DbContext
    {
        public CurrencyExchangeContext(DbContextOptions<CurrencyExchangeContext> options) : base(options)
        {
        }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyRate> CurrencyRates { get; set; }


    }
}