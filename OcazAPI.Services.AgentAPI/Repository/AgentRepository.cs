using OcazAPI.Services.AgentAPI.agentDbContext;
using OcazAPI.Services.AgentAPI.Models;
using OcazAPI.Services.AgentAPI.Models.Dto;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace OcazAPI.Services.AgentAPI.Repository
{
   
    public class AgentRepository : IAgentRepository
    {
        private readonly AgentDbContext _db;

        private IMapper _mapper;











        public AgentRepository(AgentDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }



        public async Task<AgentDto> CreateUpdateAgent(AgentDto agentDto)
        {
            Agent agent = _mapper.Map<AgentDto, Agent>(agentDto);
            if (agent.AgentId > 0)
            {
                 
                 _db.Agents.Update(agent);
            }
            else
            {
                
                _db.Agents.Add(agent);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Agent, AgentDto>(agent);
        }



        public async Task<bool> DeleteAgent(int AgentId)
        {
            try
            {
                Agent agent = await _db.Agents.FirstOrDefaultAsync(u => u.AgentId == AgentId);
                if (agent == null)
                {
                    return false;
                }
                _db.Agents.Remove(agent);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<AgentDto> GetAgentById(int AgentId)
        {
            Agent agent = await _db.Agents.Where(x => x.AgentId == AgentId).FirstOrDefaultAsync();
           
            

            return _mapper.Map<AgentDto>(agent);
        }

        public async Task<string> GetAgentByLogin(AgentDto agentDto)
        {

            Agent agent = await _db.Agents.Where(x => x.AgentPhone.Equals(agentDto.AgentPhone)
            && x.AgentPas.Equals(agentDto.AgentPas)
            ).FirstOrDefaultAsync();

            if (agent!=null)
            {
                string id = Convert.ToString(agent.AgentId);
                return id ;
            }
            else
            {

                return "-1";
            }


        }






        public async Task<IEnumerable<AgentDto>> GetAgents()
        {
            List<Agent> agentList = await _db.Agents.ToListAsync();

            return _mapper.Map<List<AgentDto>>(agentList);

        }
    }
}
