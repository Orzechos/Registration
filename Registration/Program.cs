using System;
using System.Windows.Forms;
using Registration.View;
using Unity;
using Registration.Presenter;
using Registration.BLL.LogIn;
using Registration.IBLL;
using Unity.log4net;

namespace Registration
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IUnityContainer container = new UnityContainer();

            container.RegisterType<ILoginPresenter, LoginPresenter>()
                .RegisterType<ILoginView, LoginForm>()
                .RegisterType<ILoginBusinessLogic, LoginBusinessLogic>();
            container.AddNewExtension<Log4NetExtension>();

            var presenter = container.Resolve<ILoginPresenter>();

            presenter.Run();
        }
    }
}
