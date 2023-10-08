using mf.domain.Commands;
using mf.domain.Commands.Contracts;
using mf.domain.Entities;
using mf.domain.Handlers.Contracts;
using mf.domain.Repositories;
using System.Net;

namespace mf.domain.Handlers
{
    public class MinecraftHandler : IHandler<CreateMinecraftCommand>
    {
        public readonly IMinecraftRepository _minecraftRepository;
        public MinecraftHandler(IMinecraftRepository minecraftRepository) 
        {
            _minecraftRepository = minecraftRepository;
        }

        public async Task<ICommandResult> Handle(CreateMinecraftCommand command)
        {
            command.isCommandvalid();

            if (!command.isValid)
            {
                return new CommandResult(command, HttpStatusCode.BadRequest, "Data was not saved");
            }

            Minecraft model = new Minecraft(command.id, command.name);
            _ = _minecraftRepository.create(model);

            return new CommandResult(model);
        }
    }
}
