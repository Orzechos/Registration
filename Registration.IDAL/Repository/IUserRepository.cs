using Registration.Model;

namespace Registration.IDAL.Repository
{
    public interface IUserRepository
    {
        UserModel GetUserRole(UserModel user);
    }
}
