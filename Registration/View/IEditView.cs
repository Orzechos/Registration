using Registration.Model;

namespace Registration.View
{
    public interface IEditView: IView
    {
        PatientModel Patient { get; set; }
        bool Enabled { get; set; }

        void BlockSaveButton();
        void Close();
    }
}