using mf.domain.Entities;
using mf.domain.Repositories;

namespace mf.infra.Data
{
    public class MinecraftRepository : IMinecraftRepository
    {
        private readonly ApplicationDbContext _context;
        public MinecraftRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task create(Minecraft minecraft)
        {
            _context.Minecraft.Add(minecraft);
            await _context.SaveChangesAsync();
        }

        public Task<Minecraft> delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Minecraft> search(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Minecraft> update(Minecraft minecraft)
        {
            throw new NotImplementedException();
        }
    }
}
