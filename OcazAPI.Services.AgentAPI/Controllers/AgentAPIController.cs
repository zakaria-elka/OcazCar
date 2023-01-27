using OcazAPI.Services.AgentAPI.Models.Dto;
using OcazAPI.Services.AgentAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OcazAPI.Services.AgentAPI.Controllers
{
    [Route("api/Agents")]
    public class AgentAPIController : ControllerBase
    {

        protected ResponseDto _response;
        private IAgentRepository _agentRepository;
       
        public AgentAPIController(IAgentRepository agentRepository)
        {
            _agentRepository = agentRepository;
         

            this._response = new ResponseDto();
        }

        [HttpGet]
        public async Task<object> Get()
        {
          try
            {
                IEnumerable<AgentDto> agentDtos = await _agentRepository.GetAgents();
             
                _response.Result = agentDtos;
               
            }
                catch (Exception ex)
                 {
                   _response.IsSuccess = false;
                  _response.ErrorMessages
                      = new List<string>() { ex.ToString() };
                   }
            return _response;
        }

            [HttpGet]
            [Route("{id}")]
            public async Task<object> Get(int id)
            {
              try
               {
                    AgentDto agentDto = await _agentRepository.GetAgentById(id);
               
                    _response.Result = agentDto;
                   
               }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.ErrorMessages
                         = new List<string>() { ex.ToString() };
                }
            return _response.Result;
        }



        [HttpPost]
        [Route("/log")]
        public async Task<object> PostLog([FromBody] AgentDto agentDto)
        {
            try
            {
                 string model = await _agentRepository.GetAgentByLogin(agentDto);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }




        [HttpPost]
 
            public async Task<object> Post([FromBody] AgentDto agentDto)
            {
                try
                {
                    AgentDto model = await _agentRepository.CreateUpdateAgent(agentDto);
                    _response.Result = model;
                }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.ErrorMessages
                         = new List<string>() { ex.ToString() };
                }
                return _response;
            }


            [HttpPut]
            [Authorize]
            public async Task<object> Put([FromBody] AgentDto agentDto)
            {
                try
                {
                    AgentDto model = await _agentRepository.CreateUpdateAgent(agentDto);
                    _response.Result = model;
                }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.ErrorMessages
                         = new List<string>() { ex.ToString() };
                }
                return _response;
            }



            [HttpDelete]
            [Authorize(Roles = "Admin")]
            [Route("{id}")]
            public async Task<object> Delete(int id)
            {
                try
                {
                    bool isSuccess = await _agentRepository.DeleteAgent(id);
                    _response.Result = isSuccess;
                }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.ErrorMessages
                         = new List<string>() { ex.ToString() };
                }
                return _response;
            }
        }
    }

