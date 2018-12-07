using System.Threading.Tasks;

namespace Vakacoin.Db
{
    public interface IDbStore
    {
        Task<bool> AddAsync();
        Task<bool> UpdateAsync(string key, string value);
        Task<bool> DeleteAsync(string key);
    }
}