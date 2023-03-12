using ItogovoeZadanie;



// Создаем объекты репозиториев


var userRepository = new UserRepository();
var postRepository = new PostRepository();
var blogRepository = new BlogRepository();

// Создаем пользователей
var user1 = new User { Id = 1, Name = "Alice" };
var user2 = new User { Id = 2, Name = "Bob" };
var user3 = new User { Id = 3, Name = "Charlie" };


await userRepository.AddAsync(user1);
await userRepository.AddAsync(user2);
await userRepository.AddAsync(user3);




// Создаем посты


var post1 = new Post { Id = 1, UserId = 1, Content = "Post 1 by Alice" };
var post2 = new Post { Id = 2, UserId = 1, Content = "Post 2 by Alice" };


var post3 = new Post { Id = 3, UserId = 2, Content = "Post 1 by Bob" };
var post4 = new Post { Id = 4, UserId = 2, Content = "Post 2 by Bob" };
await postRepository.AddAsync(post1);
await postRepository.AddAsync(post2);
await postRepository.AddAsync(post3);
await postRepository.AddAsync(post4);

// Создаем блоги
var blog1 = new Blog { User = user1, Posts = new List<Post> { post1, post2 } };
var blog2 = new Blog { User = user2, Posts = new List<Post> { post3, post4 } };
await blogRepository.AddAsync(blog1);
await blogRepository.AddAsync(blog2);

// Выводим все блоги и их посты
var blogs = await blogRepository.GetAllAsync();
foreach (var blog in blogs)
{
    Console.WriteLine($"Blog by {blog.User.Name} with {blog.ViewCount} views:");
    foreach (var post in blog.Posts)
    {
        Console.WriteLine($" - {post.Content}");
    }
    Console.WriteLine();
}

// Выводим посты пользователя с ID = 2
var postsByUser2 = await postRepository.GetByIdAsync(2);
Console.WriteLine("Posts by user with ID = 2:");
foreach (var post in postsByUser2.Content)
{
    Console.Write($"{post}");
}
