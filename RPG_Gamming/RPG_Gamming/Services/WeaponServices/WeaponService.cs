﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RPG_Gamming.Data;
using RPG_Gamming.Dtos.Character;
using RPG_Gamming.Dtos.Weapon;
using System.Security.Claims;

namespace RPG_Gamming.Services.WeaponServices
{
    public class WeaponService : IWeaponService
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public WeaponService(DataContext context, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon)
        {
            ServiceResponse<GetCharacterDto> response= new ServiceResponse<GetCharacterDto>();
            try 
            {
                Character character = await _context.Characters
                    .FirstOrDefaultAsync(c => c.Id == newWeapon.CharacterId &&
                    c.User.Id == int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)));
                if (character == null)
                {
                    response.Success = false;
                    response.Message = "Character Not Found";
                    return response;
                }

                Weapon weapon = new Weapon
                { 
                    Name = newWeapon.Name,
                    Damage = newWeapon.Damange,
                    Character = character
                };

                _context.Weapons.Add(weapon);
                await _context.SaveChangesAsync();
                response.Data = _mapper.Map<GetCharacterDto>(character);

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        
    }
}
