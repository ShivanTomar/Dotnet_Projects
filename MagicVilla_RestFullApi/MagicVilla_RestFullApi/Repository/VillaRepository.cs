using MagicVilla_RestFullApi.Data;
using MagicVilla_RestFullApi.Models;
using MagicVilla_RestFullApi.Repository.IRepostiory;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicVilla_RestFullApi.Repository
{
    public class VillaRepository :Repository<Villa>, IVillaRepository
    {

        private readonly ApplicationDBContext _db;
        public VillaRepository(ApplicationDBContext db) :base(db) 
        { 
            _db = db;
        }

      /*    public async Task CreateAsync(Villa enity)
          {
              await _db.VillasDb.AddAsync(enity);
              await SaveAsync();
          }

          public async Task<Villa> GetAsync(Expression<Func<Villa,bool>> filter = null, bool tracked = true)
          {
              IQueryable<Villa> query = _db.VillasDb;
              if (!tracked)
              {
                  query = query.AsNoTracking();
              }
              if (filter != null)
              {
                  query = query.Where(filter);
              }
              return await query.FirstOrDefaultAsync();
          }

          public async Task<List<Villa>> GetAllAsync(Expression<Func<Villa,bool>> filter = null)
          {
              IQueryable<Villa> query = _db.VillasDb;
              if (filter != null)
              { 
              query = query.Where(filter); 
              }
              return await query.ToListAsync();
          }

          public async Task RemoveAsync(Villa enity)
          {
               _db.VillasDb.Remove(enity);
              await SaveAsync();
          }

          public async Task SaveAsync()
          {
              await _db.SaveChangesAsync();
          }
      */
          public async Task<Villa> UpdateAsync(Villa entity)
          {
               entity.UpdateDate = DateTime.Now; 
              _db.VillasDb.Update(entity);
              await _db.SaveChangesAsync();
            return entity;
          }
    }
}
