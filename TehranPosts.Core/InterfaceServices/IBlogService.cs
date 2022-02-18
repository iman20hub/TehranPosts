
using TehranPosts.Domain.Models;
using System.Collections.Generic;
namespace TehranPosts.Core.InterfaceServices
{
    public interface IBlogService
    {
        void Create(Blog blog);
        void Update(Blog blog);
        void Deletet(int blogId);
        IEnumerable<Blog> GetAll();
        Blog GetBlogById(int blogId);
        Blog GetBlogByUserId(int userId);
    }
}