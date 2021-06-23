using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurrencyController : ControllerBase
    {
        private readonly CurrencyExchangeContext _context;
        public CurrencyController(CurrencyExchangeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Currency>>> GetCurrencies()
        {
            var currencies = await _context.Currencies.ToListAsync();
            return Ok(currencies);
        }

        // [HttpGet]
        // public string GetRate()
        // {
        //     return "this will be the list of rates";
        // }

        [HttpGet("{id}")]
        public async Task<ActionResult<Currency>> GetCurrency(int id)
        {
            var currency = await _context.Currencies.FindAsync(id);
            return currency;
        }



        [HttpGet("{code}")]
        public async Task<ActionResult<Currency>> GetCurrencyByCode(string code)
        {
            var currency = await _context.Currencies.SingleOrDefaultAsync(c => c.Code == code);
            return currency;
        }
    }
}