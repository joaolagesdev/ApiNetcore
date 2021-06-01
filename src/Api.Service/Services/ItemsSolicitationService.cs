using AutoMapper;
using Domain.Dtos.ItemsSolicitation;
using Domain.Entities;
using Domain.Interfaces.Services.ItemsSolicitation;
using Domain.Models;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ItemsSolicitationService: IItemsSolicitationService
    {
        private IItemsSolicitationRepository _repository;

        private readonly IMapper _mapper;

        public ItemsSolicitationService(IItemsSolicitationRepository repository, IMapper mapper )
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ItemsSolicitationDTO> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ItemsSolicitationDTO>(entity);
        }

        public async Task<IEnumerable<ItemsSolicitationDTO>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ItemsSolicitationDTO>>(listEntity);
        }

        public async Task<ItemsSolicitationCreateResultDTO> Post(ItemsSolicitationCreateDTO product)
        {
            var model = _mapper.Map<ItemsSolicitationModel>(product);
            var entity = _mapper.Map<ItemsSolicitationEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<ItemsSolicitationCreateResultDTO>(result);
        }

        public async Task<bool> CalculateTotalValue(Guid productId, int quantity)
        {
            var itemsSolicitation = await _repository.SelectAsync(productId);

            if (itemsSolicitation == null) return false;

            // if (!product.HasQuantity(quantity)) return false;

            itemsSolicitation.UpdateStock(quantity);

            await _repository.UpdateAsync(itemsSolicitation);

            return true;
        }
    }
}
