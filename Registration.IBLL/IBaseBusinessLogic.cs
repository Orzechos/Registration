namespace Registration.IBLL
{
    public interface IBaseBusinessLogic<R>
    {
        R Process();
    }

    public interface IBaseBusinessLogic<R,T>
    {
        R Process(T prop);
    }
}
