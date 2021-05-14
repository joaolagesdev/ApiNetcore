using Domain.Dtos;
using Domain.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Product
{
   public interface IProductService
    {
        Task<ProductDTO> Get(Guid id);
        Task<IEnumerable<ProductDTO>> GetAll();
        Task<ProductCreateResultDTO> Post(ProductCreateDTO product);
        Task<ProductUpdateResultDTO>Put(ProductUpdateDTO product);
        Task<bool> Delete(Guid id);
    }
}
