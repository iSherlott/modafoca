using mf.domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace mf.infra.Data.Mappings
{
    public class DiscordMapping : IEntityTypeConfiguration<Discord>
    {
        public void Configure(EntityTypeBuilder<Discord> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.username).IsRequired();
            builder.Property(x => x.tag);
            builder.Property(x => x.wallet).HasDefaultValue(0);
            builder.Property(x => x.active).HasDefaultValue(true);
        }
    }
}
