using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    public interface IUserInfoRepo
    {
        IEnumerable<UserInfo> GetAllUsers();
        UserInfo GetUserById(string userId);
        void AddUser(UserInfo user);
    }
}
