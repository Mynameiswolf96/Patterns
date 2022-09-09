namespace State.Scripts
{
    public interface IState
    {
        void Do(Context context);

        string Say();
    }
}