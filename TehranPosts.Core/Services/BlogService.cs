
using TehranPosts.Domain.Models;
using TehranPosts.Domain.InterfaceRepositories;
using System.Collections.Generic;
using TehranPosts.Core.InterfaceServices;
using System.Linq;

namespace TehranPosts.Core.Services
{
    public class BlogService : IBlogService
    {
        protected readonly IBaseRepository<Blog> _blogRepository;
        public BlogService(IBaseRepository<Blog> blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public void Create(Blog blog)
        {
            _blogRepository.Insert(blog);
        }

        public void Deletet(int blogId)
        {
            _blogRepository.DeleteById(blogId);

        }

        public IEnumerable<Blog> GetAll()
        {
            return _blogRepository.GetAll().ToList();
        }

        public Blog GetBlogById(int blogId)
        {
            return _blogRepository.GetById(blogId);
        }

        public Blog GetBlogByUserId(int userId)
        {
            return _blogRepository.GetAll().Where(x => x.OwnerUserId == userId).First();
        }

        public void Update(Blog blog)
        {
            _blogRepository.Update(blog);
        }
    }
}