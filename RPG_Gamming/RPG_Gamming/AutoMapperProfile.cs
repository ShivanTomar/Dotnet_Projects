using AutoMapper;
using RPG_Gamming.Dtos.Character;
using RPG_Gamming.Dtos.Skill;
using RPG_Gamming.Dtos.Weapon;

namespace RPG_Gamming
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<Character, AddCharacterDto>().ReverseMap();
            CreateMap<UpdateCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>().ReverseMap();
            CreateMap<Skill, GetSkillDto>();

        }
    }
}
