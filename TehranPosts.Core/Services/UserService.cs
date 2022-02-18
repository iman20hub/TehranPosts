
using TehranPosts.Domain.Models;
using TehranPosts.Domain.InterfaceRepositories;
using System.Collections.Generic;
using TehranPosts.Core.InterfaceServices;
using System.Linq;

namespace TehranPosts.Core.Services
{
    public class UserService : IUserService
    {
        protected readonly IBaseRepository<User> _userRepository;
        public UserService(IBaseRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(User User)
        {
            _userRepository.Insert(User);
        }

        public void DeleteUser(int UserId)
        {
            _userRepository.DeleteById(UserId);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAll().ToList();
        }

        public User GetUserById(int UserId)
        {
            return _userRepository.GetById(UserId);
        }

        public void UpdateUser(User User)
        {
            _userRepository.Update(User);
        }
    }
}