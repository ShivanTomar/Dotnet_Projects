using AutoMapper;
using MagicVilla_RestFullApi.Models;
using MagicVilla_RestFullApi.Models.Dto;
using Microsoft.Identity.Client;

namespace MagicVilla_RestFullApi
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<Villa, VillaDTO>().ReverseMap();
            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();

            CreateMap<VillaNumber, VillaNumberDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberUpdate>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberUpdate>().ReverseMap();

            
        } 
    }
}
