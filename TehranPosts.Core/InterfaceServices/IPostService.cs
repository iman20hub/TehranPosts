
using TehranPosts.Domain.Models;
using System.Collections.Generic;
namespace TehranPosts.Core.InterfaceServices
{
    public interface IPostService
    {
        void CreatePost(Post post);
        void UpdatePost(Post post);
        void DeletePost(int postId);
        IEnumerable<Post> GetAllPosts();
        Post GetPostById(int PostId);
        IEnumerable<Post> GetAllPostsByUserId(int UserId);
    }
}