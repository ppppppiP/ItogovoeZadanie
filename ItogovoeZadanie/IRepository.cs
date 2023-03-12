using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItogovoeZadanie
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
    }

}
