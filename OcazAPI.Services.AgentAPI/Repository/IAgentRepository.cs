using OcazAPI.Services.AgentAPI.Models.Dto;

namespace OcazAPI.Services.AgentAPI.Repository
{
    public interface IAgentRepository
    {
        Task<IEnumerable<AgentDto>> GetAgents();
        Task<AgentDto> GetAgentById(int AgentId);
        Task<AgentDto> CreateUpdateAgent(AgentDto agentDto);
        Task<bool> DeleteAgent(int AgentId);
        Task<string> GetAgentByLogin(AgentDto agentDto);
    }
}
