using AutoMapper;
using Bd.MobileApi.Data.Management.DtoModels;
using BdMobApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdMobApp.ModelMappers
{
    class ProductModelAutoMapperProfile : Profile
    {
        public ProductModelAutoMapperProfile()
        {
            CreateMap<ProductDto, ProductModel>().ReverseMap();
        }
    }
}
