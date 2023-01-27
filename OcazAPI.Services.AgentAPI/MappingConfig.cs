using AutoMapper;
using OcazAPI.Services.AgentAPI.Models;
using OcazAPI.Services.AgentAPI.Models.Dto;

namespace OcazAPI.Services.AgentAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>

            {

                config.CreateMap<AgentDto, Agent>();
                config.CreateMap<Agent, AgentDto>();

            }

                );


            return mappingConfig;

        }

    }
}
