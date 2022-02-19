using System;
namespace TehranPosts.Domain.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? LikesCount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
