using Registration.IBLL;
using log4net;
using Registration.IDAL.Repository;

namespace Registration.BLL.LogIn
{
    public class LoginBusinessLogic : BaseBusinessLogic, ILoginBusinessLogic
    {
        private IUserRepository _userRepository;

        public LoginBusinessLogic(ILog log, IUserRepository userRepository) :base(log) {
            _userRepository = userRepository;
        }

        public Model.UserModel Process(Model.UserModel prop)
        {
            return _userRepository.GetUserRole(prop);
        }
    }
}
