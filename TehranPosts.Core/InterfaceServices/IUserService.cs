
using TehranPosts.Domain.Models;
using System.Collections.Generic;
namespace TehranPosts.Core.InterfaceServices
{
    public interface IUserService
    {
        void CreateUser(User User);
        void UpdateUser(User User);
        void DeleteUser(int UserId);
        IEnumerable<User> GetAllUsers();
        User GetUserById(int UserId);
    }
}