using log4net;
using Registration.IBLL;
using Registration.Model;
using Registration.View;
using System;
using System.Windows.Forms;
using Unity;

namespace Registration.Presenter
{
    public class ListPresenter : IListPresenter
    {
        private IListView _listView;
        private UserModel _user;

        private IGetPatientsBusinessLogic _getPatientsBusinessLogic;
        private IGetPatientByIdBusinessLogic _getPatientByIdBusinessLogic;
        private IRemovePatientByIdBusinessLogic _removePatientByIdBusinessLogic;

        public ListPresenter(IListView listView, IGetPatientsBusinessLogic getPatientsBusinessLogic, IGetPatientByIdBusinessLogic getPatientByIdBusinessLogic, IRemovePatientByIdBusinessLogic removePatientByIdBusinessLogic)
        {
            _listView = listView;
            _getPatientsBusinessLogic = getPatientsBusinessLogic;
            _getPatientByIdBusinessLogic = getPatientByIdBusinessLogic;

            _listView.Presenter = this;
            _removePatientByIdBusinessLogic = removePatientByIdBusinessLogic;
        }

        public void AddNew()
        {
            OpenEditForm(null);
        }

        public void RemovePatient(Guid guid)
        {
            _removePatientByIdBusinessLogic.Process(guid);
            LoadData();
        }

        public void Run()
        {
            LoadData();
            (_listView as Form).Show();
        }

        public void SetUser(UserModel user)
        {
            _user = user;

            if(_user.Role == null || !_user.Role.Equals(Common.Enums.RoleEnum.Full))
            {
                _listView.BlockEdit();
            }
        }

        public void ShowPatient(Guid guid)
        {
            PatientModel patientModel = _getPatientByIdBusinessLogic.Process(guid);

            OpenEditForm(patientModel);
        }

        private void LoadData()
        {
            _listView.Patient = _getPatientsBusinessLogic.Process();            
        }

        private void OpenEditForm(PatientModel patientModel)
        {
            var presenter = UnityConfig.GetContainer().Resolve<IEditPresenter>();
            presenter.SetData(patientModel, _user);
            presenter.Run();

            LoadData();
        }
    }
}
