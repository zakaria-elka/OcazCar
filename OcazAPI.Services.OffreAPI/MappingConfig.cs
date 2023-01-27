using AutoMapper;
using OcazAPI.Services.OffreAPI.Models;
using OcazAPI.Services.OffreAPI.Models.Dto;

namespace OcazAPI.Services.OffreAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>

            {

                config.CreateMap<OffreDto, Offre>();
                config.CreateMap<Offre, OffreDto>();

            }

                );


            return mappingConfig;

        }
    }
}
