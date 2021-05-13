using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Solicitation
{
    interface ISolicitationService
    {
        Task<SolicitationEntity> Get(Guid id);
        Task<IEnumerable<ProductEntity>> GetAll();
        Task<SolicitationEntity> Post(SolicitationEntity solicitation);
        Task<SolicitationEntity> Put(SolicitationEntity solicitation);
        Task<bool> Delete(Guid id);
    }
}
