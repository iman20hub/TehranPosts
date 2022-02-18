
using TehranPosts.Domain.Models;
using TehranPosts.Domain.InterfaceRepositories;
using System.Collections.Generic;
using TehranPosts.Core.InterfaceServices;
using System.Linq;

namespace TehranPosts.Core.Services
{
    public class PostService : IPostService
    {
        protected readonly IBaseRepository<Post> _postRepository;
        public PostService(IBaseRepository<Post> postRepository)
        {
            _postRepository = postRepository;
        }

        public void CreatePost(Post post)
        {
            _postRepository.Insert(post);
        }

        public void DeletePost(int postId)
        {
            _postRepository.DeleteById(postId);

        }

        public IEnumerable<Post> GetAllPosts()
        {
            return _postRepository.GetAll();

        }

        public IEnumerable<Post> GetAllPostsByUserId(int UserId)
        {
            var query = _postRepository.GetAll();
            return query.Where(x => x.UserId == UserId).ToList();
        }

        public Post GetPostById(int PostId)
        {
            return _postRepository.GetById(PostId);
        }

        public void UpdatePost(Post post)
        {
            _postRepository.Update(post);
        }
    }
}