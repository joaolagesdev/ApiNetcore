using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Solicitation
{
    interface ISolicitationService
    {
        Task<ItensSolicitationEntity> Get(Guid id);
        Task<IEnumerable<ProductEntity>> GetAll();
        Task<ItensSolicitationEntity> Post(ItensSolicitationEntity solicitation);
        Task<ItensSolicitationEntity> Put(ItensSolicitationEntity solicitation);
        Task<bool> Delete(Guid id);
    }
}
