using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class SolicitationMap : IEntityTypeConfiguration<SolicitationEntity>
    {
        public void Configure(EntityTypeBuilder<SolicitationEntity> builder)
        {
            builder.ToTable("Solicitation");
            builder.HasKey(s => s.Id);
        }
    }
}
