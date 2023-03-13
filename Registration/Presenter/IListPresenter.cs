using Registration.Model;
using System;

namespace Registration.Presenter
{
    public interface IListPresenter:IPresenter
    {
        void SetUser(UserModel user);
        void AddNew();
        void ShowPatient(Guid guid);
        void RemovePatient(Guid guid);
    }
}
