using Registration.Presenter;

namespace Registration.View
{
    public interface ILoginView:IView
    {
        string LoginName { get; set; }
        string Password { get; set; }


        void Close();
    }
}
