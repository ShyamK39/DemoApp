using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    public class UserInfoRepo : IUserInfoRepo
    {
        private AppDbContext _appDbContext;

        public UserInfoRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<UserInfo> GetAllUsers()
        {
            return _appDbContext.Users;
        }

        public UserInfo GetUserById(string userId)
        {
            return _appDbContext.Users.FirstOrDefault(u => u.UserID == userId);
        }

        public void AddUser(UserInfo user)
        {
            _appDbContext.Users.Add(user);
            _appDbContext.SaveChanges();
        }
    }
}
