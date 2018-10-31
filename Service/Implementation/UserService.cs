using Model;
using Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> repo;
        public UserService(IRepository<User> repo)
        {
            this.repo = repo;
        }

        public void AddUser(User user)
        {
            repo.Add(user);
        }

        public void DeleteUser(Guid Id)
        {
            var user = repo.Get(Id);
            if(user == null)
            {
                throw new Exception("user doesn't exist");
            }
            repo.Remove(user);
        }

        public User Get(Guid Id)
        {
            return repo.Get(Id);
        }

        public IEnumerable<User> GetUsers()
        {
            return repo.GetAll();
        }
                
        public void UpdateUser(User user)
        {
            repo.Update(user);
        }
    }
}
