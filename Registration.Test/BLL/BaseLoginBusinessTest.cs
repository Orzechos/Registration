using Registration.BLL.LogIn;
using Registration.IBLL;
using Registration.Presenter;
using Registration.View;
using System.ComponentModel;
using Unity;
using Unity.log4net;

namespace Registration.Test.BLL
{
    public class BaseLoginBusinessTest
    {
        protected IUnityContainer _container = new UnityContainer();


        public BaseLoginBusinessTest() {
            _container = new UnityContainer();

            _container.RegisterType<ILoginPresenter, LoginPresenter>()
                .RegisterType<ILoginBusinessLogic, LoginBusinessLogic>();

            _container.AddNewExtension<Log4NetExtension>();
        }
    }
}
