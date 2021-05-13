using AutoMapper;
using Domain.Dtos;
using Domain.Models;

namespace CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<ProductModel, ProductDTO>() // Entrada da Controller - Saída Service
                .ReverseMap();
        }
    }
}
