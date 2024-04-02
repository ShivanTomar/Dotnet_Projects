using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RPG_Gamming.Dtos.Character;
using RPG_Gamming.Dtos.Weapon;
using RPG_Gamming.Services.WeaponServices;

namespace RPG_Gamming.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[Controller]")]
    public class WeaponController : Controller
    {
        private readonly IWeaponService _weaponService;

        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            return Ok(await _weaponService.AddWeapon(newWeapon));
        }

    }
}
