using AutoMapper;
using MagicVilla_RestFullApi.Models;
using MagicVilla_RestFullApi.Models.Dto;
using Microsoft.Identity.Client;

namespace MagicVilla_Web
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            
            CreateMap<VillaDTO, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaDTO, VillaUpdateDTO>().ReverseMap();

            
            CreateMap<VillaNumberDTO, VillaNumberUpdate>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaNumberUpdate>().ReverseMap();

            
        } 
    }
}
