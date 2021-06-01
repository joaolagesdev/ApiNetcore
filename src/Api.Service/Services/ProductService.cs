using AutoMapper;
using Domain.Dtos;
using Domain.Dtos.Product;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Product;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        private IRepository<ProductEntity> _repository;

        private readonly IMapper _mapper;


        public ProductService(IRepository<ProductEntity> repository, IMapper mapper) // Injeção 
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ProductDTO> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ProductDTO>(entity);
        }

        public async Task<IEnumerable<ProductDTO>> GetAll()
        {
            var listEntities = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(listEntities);
        }

        public async Task<ProductCreateResultDTO> Post(ProductCreateDTO product)
        {
            var model = _mapper.Map<ProductModel>(product);
            var entity = _mapper.Map<ProductEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<ProductCreateResultDTO>(result);
        }

        public async Task<ProductUpdateResultDTO> Put(ProductUpdateDTO product)
        {
            var model = _mapper.Map<ProductModel>(product);
            var entity = _mapper.Map<ProductEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<ProductUpdateResultDTO>(result);
        }

        public async Task<bool> DebitQuantity(Guid productId, int quantity)
        {
            var product = await _repository.SelectAsync(productId);

            if (product == null) return false;

            if (!product.HasQuantity(quantity)) return false;

            product.DebitQuantity(quantity);

            await _repository.UpdateAsync(product);

            return true;
        }

        public async Task<bool> IncreaseQuantity(Guid productId, int quantity)
        {
            var product = await _repository.SelectAsync(productId);

            if (product == null) return false;

            product.IncreaseQuantity(quantity);

            await _repository.UpdateAsync(product);

            return true;
        }
    }
}
