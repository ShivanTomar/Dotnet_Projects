using MagicVilla_RestFullApi.Models.Dto;

namespace MagicVilla_RestFullApi.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList= new List<VillaDTO> {
           new VillaDTO {Id=1, Name="Pool View",sqft=100,Occupancy=4 },
           new VillaDTO {Id=2, Name="Beach View",sqft=100,Occupancy=3 }
           };
    }
}
