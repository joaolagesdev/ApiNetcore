using Data.Context;
using Data.Repository;
using Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class ItemsSolicitationImplementation : BaseRepository<ItemsSolicitationEntity>, IItemsSolicitationRepository
    {
        private DbSet<ItemsSolicitationEntity> dataset;

        public ItemsSolicitationImplementation(MyContext context) : base(context)
        {
            dataset = context.Set<ItemsSolicitationEntity>();
        }

        public async Task<ItemsSolicitationEntity> GetProductById(Guid id)
        {
            return await dataset.Include(i => i.Product)
                .FirstOrDefaultAsync(p => p.Id.Equals(id));
        }
    }
}
