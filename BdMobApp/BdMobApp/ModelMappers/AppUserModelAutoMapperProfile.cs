using AutoMapper;
using Bd.MobileApi.Data.Management.DtoModels;
using BdMobApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdMobApp.ModelMappers
{
    public class AppUserModelAutoMapperProfile : Profile
    {
        public AppUserModelAutoMapperProfile()
        {
            CreateMap<AppUserDto, AppUserModel>().ReverseMap();
        }
    }
}
