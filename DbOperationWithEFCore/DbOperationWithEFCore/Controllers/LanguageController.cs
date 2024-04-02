using DbOperationWithEFCore.Models;
using Microsoft.AspNetCore.Mvc;
using DbOperationWithEFCore.Data;
using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public LanguageController(AppDbContext appDbContext) 
        {
            this._appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLanguages() 
        {
            var result=await _appDbContext.Languages.ToListAsync();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetLanguagesById([FromRoute] int id)
        {
            var result = await _appDbContext.Languages.FindAsync(id);
            return Ok(result);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetLanguagesByname([FromRoute] string name)
        {
            var result = await _appDbContext.Languages.Where(x=>x.Title==name).FirstOrDefaultAsync();
            return Ok(result);
        }
    }
}
