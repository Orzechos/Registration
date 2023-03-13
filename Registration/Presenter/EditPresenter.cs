using Registration.IBLL;
using Registration.Model;
using Registration.View;
using System;
using System.Windows.Forms;

namespace Registration.Presenter
{
    public class EditPresenter : IEditPresenter
    {
        private UserModel _userModel;
        private IEditView _editView;
        private IAddOrUpdatePatientBusinessLogic _addOrUpdatePatientBusinessLogic;

        public EditPresenter(IEditView editView, IAddOrUpdatePatientBusinessLogic addOrUpdatePatientBusinessLogic) { 
            _editView = editView;
            _editView.Presenter = this;
            _addOrUpdatePatientBusinessLogic = addOrUpdatePatientBusinessLogic;
        }


        public void Run()
        {
            (_editView as Form).ShowDialog();
        }

        public void SaveClick()
        {
            if (_editView.Enabled)
            {

                PatientModel patientModel = _editView.Patient;

                if (patientModel.CreationDate == DateTime.MinValue)
                {
                    patientModel.CreationDate = System.DateTime.Now;
                    patientModel.CreationBy = _userModel.LoginName;
                }
                else
                {
                    patientModel.LastModificationDate = System.DateTime.Now;
                    patientModel.LastModificationBy = _userModel.LoginName;
                }

                _addOrUpdatePatientBusinessLogic.Process(patientModel);
                _editView.Close();
            }
            else
            {
                if(_userModel.Role == Common.Enums.RoleEnum.Full)
                {
                    _editView.Enabled = true;
                }
            }
        }

        public void SetData(PatientModel patientModel, UserModel userModel)
        {
            _userModel = userModel;

            if(_userModel.Role == null || (Common.Enums.RoleEnum)_userModel.Role != Common.Enums.RoleEnum.Full)
            {
                _editView.BlockSaveButton();
            }

            
            if(patientModel != null)
            {
                _editView.Enabled = false;
            }
            else
            {
                patientModel = new PatientModel();
            }
           
            _editView.Patient = patientModel;
        }
    }
}
