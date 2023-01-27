using AutoMapper;
using OcazAPI.Services.CarAPI.Models;
using OcazAPI.Services.CarAPI.Models.Dto;

namespace OcazAPI.Services.CarAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>

            {
                config.CreateMap<CarDto, Cars>();
                config.CreateMap<Cars, CarDto>();


            }

                );


            return mappingConfig;

        }
    }
}
