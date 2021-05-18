using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class ItemsSolicitationMap : IEntityTypeConfiguration<ItemsSolicitationEntity>
    {
        // Como já implementamos required na entity, não precisamos mapear aqui
        public void Configure(EntityTypeBuilder<ItemsSolicitationEntity> builder)
        {
            builder.ToTable("ItemsSolicitation");
            builder.HasKey(i => i.Id);

            builder.HasOne(p => p.Product)
                .WithMany(i => i.ItemsSolicitation);

            builder.HasOne(s => s.Solicitation)
                 .WithMany(i => i.ItemsSolicitation);
        }
    }
}
