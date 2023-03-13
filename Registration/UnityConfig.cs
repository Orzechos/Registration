using Registration.BLL.LogIn;
using Registration.IBLL;
using Registration.Presenter;
using Registration.View;
using Unity.log4net;
using Unity;
using Registration.IDAL.Repository;
using Registration.DAL.Repository;
using Registration.BLL.List;
using Unity.Injection;
using Registration.BLL.Edit;

namespace Registration
{
    public static class UnityConfig
    {
        private static IUnityContainer _unityContainer;


        public static IUnityContainer GetContainer()
        {

            if (_unityContainer == null)
            {
                _unityContainer = new UnityContainer();

                Register();
            }

            return _unityContainer;
        }

        public static void Register()
        {
            _unityContainer.RegisterType<ILoginPresenter, LoginPresenter>()
                .RegisterType<IListPresenter, ListPresenter>()
                .RegisterType<IEditPresenter, EditPresenter>()

                .RegisterType<ILoginView, LoginForm>()
                .RegisterType<IListView, ListForm>()
                .RegisterType<IEditView, EditForm>()

                .RegisterType<ILoginBusinessLogic, LoginBusinessLogic>()
                .RegisterType<IGetPatientsBusinessLogic, GetPatientsBusinessLogic>()
                .RegisterType<IAddOrUpdatePatientBusinessLogic, AddOrUpdatePatientBusinessLogic>()
                .RegisterType<IGetPatientByIdBusinessLogic, GetPatientByIdBusinessLogic>()
                .RegisterType<IRemovePatientByIdBusinessLogic, RemovePatientByIdBusinessLogic>()

                .RegisterType<IUserRepository, UserRepository>()
                .RegisterType<IPatientRepository, PatientRepository>();
            _unityContainer.AddNewExtension<Log4NetExtension>();
            _unityContainer.AddExtension(new Diagnostic());
        }
    }
}



