using System;
using Registration.IBLL;
using Registration.Model;
using Registration.BLL.LogIn.Validators;

namespace Registration.BLL.LogIn
{
    public class LoginBusinessLogic : BaseBusinessLogic, ILoginBusinessLogic
    {
        public Model.UserModel Process(Model.UserModel prop)
        {
            Validators.Add(new LoginValidator(prop));



            return prop;
        }
    }
}
