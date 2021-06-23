using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RateController : ControllerBase
    {
        private readonly CurrencyExchangeContext _context;
        public RateController(CurrencyExchangeContext context)
        {
            _context = context;
        }
    }
}