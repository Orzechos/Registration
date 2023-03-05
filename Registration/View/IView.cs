
using Registration.Presenter;

namespace Registration.View
{
    public interface IView
    {
        IPresenter Presenter { set; }
    }
}
