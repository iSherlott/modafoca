using mf.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mf.domain.Repositories
{
    public interface IMinecraftRepository
    {
        Task<Minecraft> create(Minecraft minecraft);
        Task<Minecraft> update(Minecraft minecraft);
        Task<Minecraft> delete(Guid id);
        Task<Minecraft> search(Guid id);
    }
}
