namespace Registration.IBLL
{
    public interface IBaseBusinessLogic<T>
    {
        void Process(T prop);
    }

    public interface IBaseBusinessLogic<R,T>
    {
        R Process(T prop);
    }
}
