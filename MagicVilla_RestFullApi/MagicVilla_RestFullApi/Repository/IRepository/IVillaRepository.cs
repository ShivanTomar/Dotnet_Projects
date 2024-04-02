using MagicVilla_RestFullApi.Models;
using MagicVilla_RestFullApi.Repository.IRepository;
using System.Linq.Expressions;

namespace MagicVilla_RestFullApi.Repository.IRepostiory
{
    public interface IVillaRepository :IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa enity);
    
    }
}
