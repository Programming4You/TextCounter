

namespace TextCore.Interfaces
{
    public interface IActionCommand<TRequest,TResult>
    {
        TResult Execute(TRequest dto);
    }
}
