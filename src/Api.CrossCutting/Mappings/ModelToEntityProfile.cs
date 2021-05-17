﻿using AutoMapper;
using Domain.Entities;
using Domain.Models;

namespace CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<ProductModel, ProductEntity>()
                .ReverseMap();

            CreateMap<ItemsSolicitationModel,ItemsSolicitationEntity>()
                .ReverseMap();
        }
    }
}
