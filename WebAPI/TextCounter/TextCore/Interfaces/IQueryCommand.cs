

namespace TextCore.Interfaces
{
    public interface IQueryCommand<TResult>
    {
        TResult Execute();
    }
}
