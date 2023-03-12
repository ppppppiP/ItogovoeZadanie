using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItogovoeZadanie
{
    public class UserRepository : IRepository<User>
    {
        private List<User> _users;

        public UserRepository()
        {
            _users = new List<User>();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await Task.FromResult(_users.Find(u => u.Id == id));
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await Task.FromResult(_users);
        }

        public async Task AddAsync(User user)
        {
            _users.Add(user);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(User user)
        {
            _users.Remove(user);
            await Task.CompletedTask;
        }
    }
}
