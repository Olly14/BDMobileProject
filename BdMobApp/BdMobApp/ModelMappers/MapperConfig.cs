using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdMobApp.ModelMappers
{
    public static class MapperConfig
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg => {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<ProductModelAutoMapperProfile>();
                cfg.AddProfile<AppUserModelAutoMapperProfile>();
                cfg.AddProfile<OrderModelAutoMapperProfile>();
                cfg.AddProfile<DropDownListModelsAutoMapperProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }
}
