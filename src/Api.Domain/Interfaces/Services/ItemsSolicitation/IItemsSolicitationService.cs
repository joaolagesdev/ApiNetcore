﻿using Domain.Dtos.ItemsSolicitation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.ItemsSolicitation
{
    public interface IItemsSolicitationService
    {
        Task<ItemsSolicitationDTO> Get(Guid id);
        Task<IEnumerable<ItemsSolicitationDTO>> GetAll();
        Task<ItemsSolicitationCreateResultDTO> Post(ItemsSolicitationCreateDTO product);
    }
}
