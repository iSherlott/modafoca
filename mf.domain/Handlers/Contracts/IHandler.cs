using mf.domain.Commands.Contracts;

namespace mf.domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        Task<ICommandResult> Handle(T command);
    }
}
