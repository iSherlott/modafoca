﻿using mf.domain.Entities;

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
