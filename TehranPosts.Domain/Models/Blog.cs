using System;
namespace TehranPosts.Domain.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int OwnerUserId { get; set; }
        public User User { get; set; }
    }
}
