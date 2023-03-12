using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItogovoeZadanie
{
    public class PostRepository : IRepository<Post>
    {
        private List<Post> _posts;

        public PostRepository()
        {
            _posts = new List<Post>();
        }

        public async Task<Post> GetByIdAsync(int id)
        {
            return await Task.FromResult(_posts.Find(p => p.Id == id));
        }

        public async Task<List<Post>> GetAllAsync()
        {
            return await Task.FromResult(_posts);
        }

        public async Task AddAsync(Post post)
        {
            _posts.Add(post);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(Post post)
        {
            _posts.Remove(post);
            await Task.CompletedTask;
        }
    }
}
