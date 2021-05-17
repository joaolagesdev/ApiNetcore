using AutoMapper;
using Domain.Dtos;
using Domain.Dtos.ItemsSolicitation;
using Domain.Dtos.Product;
using Domain.Entities;

namespace CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            // Data - Grava a Entidade - Devolve o Resultado 

            CreateMap<ProductDTO, ProductEntity>() // Get
                .ReverseMap();

            CreateMap<ProductCreateResultDTO, ProductEntity>() // Insert
                .ReverseMap();

            CreateMap<ProductUpdateResultDTO, ProductEntity>() // Update
                .ReverseMap();

            CreateMap<ItemsSolicitationDTO, ItemsSolicitationEntity>() 
                .ReverseMap();

            CreateMap<ItemsSolicitationCreateResultDTO, ItemsSolicitationEntity>() 
                .ReverseMap();
        }
    }
}
