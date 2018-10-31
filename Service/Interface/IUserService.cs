using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User Get(Guid Id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(Guid Id);
    }
}
