using RPG_Gamming.Dtos.Character;
using RPG_Gamming.Dtos.Weapon;
using RPG_Gamming.Migrations;

namespace RPG_Gamming.Services.WeaponServices
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
       
    }
}
