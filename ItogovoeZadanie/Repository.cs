using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItogovoeZadanie
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly List<T> _entities;

        public Repository()
        {
            _entities = new List<T>();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Task.FromResult(_entities.Find(e => e.GetType().GetProperty("Id").GetValue(e).Equals(id)));
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await Task.FromResult(_entities);
        }

        public async Task AddAsync(T entity)
        {
            _entities.Add(entity);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(T entity)
        {
            _entities.Remove(entity);
            await Task.CompletedTask;
        }
    }
}
