using log4net;
using Registration.IBLL;
using Registration.Model;
using Registration.View;
using System.Windows.Forms;
using Unity;

namespace Registration.Presenter
{
    public class LoginPresenter : ILoginPresenter
    {
        private readonly ILoginBusinessLogic _loginBusinessLogic;
        private readonly ILoginView _loginForm;
        private readonly ILog _log;

        public LoginPresenter(ILog log,ILoginView form, ILoginBusinessLogic loginBusinessLogic)
        {
            _log = log;
            _loginBusinessLogic = loginBusinessLogic;
            _loginForm = form;

            _loginForm.Presenter = this;
        }

        public void LoginClick()
        {
            _log.Info("User try log");
            UserModel userModel = _loginBusinessLogic.Process(new UserModel()
            {
                LoginName = _loginForm.LoginName,
                Password = _loginForm.Password
            });

            if (userModel.Role == null)
            {
                MessageBox.Show("Wrong username or password.", "Access",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var presenter = UnityConfig.GetContainer().Resolve<IListPresenter>();
                presenter.SetUser(userModel);

                _loginForm.Close();
                presenter.Run();
               
            }
        }

        public void Run()
        {
            Application.Run(_loginForm as Form);
        }
    }
}
