using MagicVilla_RestFullApi.Models;

namespace MagicVilla_RestFullApi.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
