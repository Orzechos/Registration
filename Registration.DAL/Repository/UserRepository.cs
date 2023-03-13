using Registration.DB;
using Registration.IDAL.Repository;
using Registration.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace Registration.DAL.Repository
{
    public class UserRepository : DbContext, IUserRepository
    {
        public DbSet<UserDB> Users { get; set; }

        public UserRepository():base("RegistrationConnectionString")
        {
        }

        public UserModel GetUserRole(UserModel user)
        {
            var res = Users.SingleOrDefault(u=> u.LoginName == user.LoginName.ToLower() && u.Password == user.Password);

            if (res != null)
            {
                user.Role = res.Role;
            }

            return user;
        }
    }
}
