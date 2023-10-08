using mf.domain.Entities;
using mf.domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

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

        public async Task<bool> delete(Guid id)
        {
            var model = await _context.Minecraft.Where(x => x.id == id).FirstAsync();
            if (model != null) return false;

            _context.Minecraft.Remove(model);

            return true;
        }

        public async Task<List<Minecraft>> getAll()
        {
            var models = await _context.Minecraft.ToListAsync();
            return models;
        }

        public async Task<Minecraft> search(Guid id)
        {
            var model = _context.Minecraft.FirstOrDefault(x => x.id == id);
            return model;
        }

        public async Task<Minecraft> update(Minecraft minecraft)
        {
            _context.Minecraft.Update(minecraft);

            var model = await _context.Minecraft.FirstOrDefaultAsync(x => x.id == minecraft.id);
            return model;
        }
    }
}
