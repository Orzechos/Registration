using Registration.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Registration.DB
{
    public class UserDB
    {
        [Key]
        public string LoginName { get; set; }
        public string Password { get; set; }
        public RoleEnum Role { get; set; }
    }
}
