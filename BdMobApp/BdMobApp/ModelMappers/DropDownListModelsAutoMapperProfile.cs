using AutoMapper;
using Bd.MobileApi.Data.Management.DtoModels;
using BdMobApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdMobApp.ModelMappers
{
    class DropDownListModelsAutoMapperProfile : Profile
    {
        public DropDownListModelsAutoMapperProfile()
        {
            CreateMap<GenderDto, GenderModel>().ReverseMap();
        }
    }
}
