using System.ComponentModel.DataAnnotations;

namespace MagicVilla_RestFullApi.Models.Dto
{
    public class VillaNumberCreate
    {
        [Required]
        public int VillaNo { get; set; }
        public string SpecialDetails { get; set; }
        public int VillaID { get; set; }

    }
}
