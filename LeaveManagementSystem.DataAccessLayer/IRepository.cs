using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSystem.DataAccessLayer
{
    public interface  IRepository<T>
    {
        IQueryable<T> GetAll();
        Task<T> GetById(int id);
        Task Add(T t);
        Task<T> Delete(int id);
        Task Update(T t);
        Task SaveChangesAsync();
    }
}
