using mf.domain.Entities;

namespace mf.domain.Repositories
{
    public interface IMinecraftRepository
    {
        Task create(Minecraft minecraft);
        Task<Minecraft> update(Minecraft minecraft);
        Task<bool> delete(Guid id);
        Task<Minecraft> search(Guid id);
        Task<List<Minecraft>> getAll();

    }
}
