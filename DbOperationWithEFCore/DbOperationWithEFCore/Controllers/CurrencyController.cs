using DbOperationWithEFCore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public CurrencyController(AppDbContext appDbContext)
        { 
            this._appDbContext=appDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCurrencies() 
        {
            //var result= _appDbContext.Currencies.ToList();
            //var result= (from Currencies in _appDbContext.Currencies select Currencies).ToList
            
            var result=await _appDbContext.Currencies.ToListAsync();
            //var result=await (from Currencies in _appDbContext.Currencies select Currencies).ToListAsync();

            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCurrenciesById([FromRoute] int id)
        {   
            var result = await _appDbContext.Currencies.FindAsync(id);
            return Ok(result);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetCurrenciesByname([FromRoute] string name)
        {
            var result = await _appDbContext.Currencies.Where(x => x.Title == name).FirstOrDefaultAsync();
            return Ok(result);
        }
    }
}
