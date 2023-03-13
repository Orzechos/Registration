using Registration.Model;

namespace Registration.Presenter
{
    public interface IEditPresenter:IPresenter
    {
        void SaveClick();

        void SetData(PatientModel patientModel, UserModel userModel);
    }
}
