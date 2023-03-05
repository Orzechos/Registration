using Registration.Common.Enums;

namespace Registration.Model
{
    public class UserModel
    {
        public string LoginName { get; set; }
        public string Password { get; set; }

        public RoleEnum? Role { get; set; }
    }
}
