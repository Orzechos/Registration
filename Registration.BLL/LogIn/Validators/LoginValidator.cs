using System;
using Registration.Model;

namespace Registration.BLL.LogIn.Validators
{
    public class LoginValidator : IValidator
    {
        private UserModel _userModel;
        
        public LoginValidator(UserModel userModel)
        {
            _userModel = userModel;
        }

        public void Valid()
        {
            if (string.IsNullOrEmpty(_userModel.LoginName))
            {
                throw new Exception(Common.ErrorMessages.LoginIsNullError);
            }

            if (string.IsNullOrEmpty(_userModel.Password))
            {
                throw new Exception(Common.ErrorMessages.PasswordIsNullError);
            }
        }
    }
}
