using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registration.IBLL;
using Registration.Model;
using Unity;

namespace Registration.Test.BLL
{
    [TestClass]
    public class LoginBusinessLogicTest: BaseLoginBusinessTest
    {
        public LoginBusinessLogicTest() { }


        [TestMethod]
        public void Login_EmptyLoginEmptyPassword()
        {
            ILoginBusinessLogic loginBusinessLogic = _container.Resolve<ILoginBusinessLogic>();

            var res = loginBusinessLogic.Process(new UserModel()
            {
               LoginName = string.Empty, Password = string.Empty
            });

        }
    }
}
