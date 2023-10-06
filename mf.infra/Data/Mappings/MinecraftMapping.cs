using mf.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace mf.infra.Data.Mappings
{
    public class MinecraftMapping : IEntityTypeConfiguration<Minecraft>
    {
        public void Configure(EntityTypeBuilder<Minecraft> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired();
        }
    }
}
