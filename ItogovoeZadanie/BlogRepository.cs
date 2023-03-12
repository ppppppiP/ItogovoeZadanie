using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItogovoeZadanie
{
    public class BlogRepository : IRepository<Blog>
    {
        private List<Blog> _blogs;

        public BlogRepository()
        {
            _blogs = new List<Blog>();
        }

        public async Task<Blog> GetByIdAsync(int id)
        {
            return await Task.FromResult(_blogs.Find(b => b.User.Id == id));
        }

        public async Task<List<Blog>> GetAllAsync()
        {
            return await Task.FromResult(_blogs);
        }

        public async Task AddAsync(Blog blog)
        {
            _blogs.Add(blog);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(Blog blog)
        {
            _blogs.Remove(blog);
            await Task.CompletedTask;
        }
    }
}
