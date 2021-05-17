using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IItemsSolicitationRepository : IRepository<ItemsSolicitationEntity>
    {
        Task<ItemsSolicitationEntity> GetProductById(Guid id);
    }
}
