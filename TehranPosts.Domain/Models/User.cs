
using System;
using System.Collections.Generic;
namespace TehranPosts.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime birthDate { get; set; }
        public int Degree { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
        public int OwnedBlogId { get; set; }
        public Blog blog { get; set; }
    }
}
