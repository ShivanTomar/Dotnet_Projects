using MagicVilla_RestFullApi.Data;
using MagicVilla_RestFullApi.Models;
using MagicVilla_RestFullApi.Repository.IRepository;
using MagicVilla_RestFullApi.Repository.IRepostiory;

namespace MagicVilla_RestFullApi.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {

        private readonly ApplicationDBContext _db;
        public VillaNumberRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }

        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.VillaNumbers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}