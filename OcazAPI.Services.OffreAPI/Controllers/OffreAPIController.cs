using OcazAPI.Services.OffreAPI.Models;
using OcazAPI.Services.OffreAPI.Models.Dto;
using OcazAPI.Services.OffreAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


using ResponseDto = OcazAPI.Services.OffreAPI.Models.Dto.ResponseDto;
using Newtonsoft.Json;
using OcazAPI.Services.AgentAPI.Models.Dto;
using OcazAPI.Services.CarAPI.Models.Dto;


namespace OcazAPI.Services.OffreAPI.Controllers
{
    [Route("api/Offres")]
    public class OffreAPIController : ControllerBase
    {

        protected ResponseDto _response;
        private IOffreRepository _offreRepository;
        private static HttpClient _CLIENT;
        private static HttpClient _CLIENT2;
        

        public OffreAPIController(IOffreRepository offreRepository)
        {
            _offreRepository = offreRepository;
            this._response = new ResponseDto();
            if (_CLIENT == null && _CLIENT2 == null)
            {
                _CLIENT = new HttpClient();
                _CLIENT2 = new HttpClient();              
                _CLIENT.BaseAddress = new Uri("https://localhost:7000/");
                _CLIENT2.BaseAddress = new Uri("https://localhost:7036/");

            }

        }

        [HttpGet]
        public async Task<object> Get()
        {
          try
            {
                
                IEnumerable<OffreDto> offreDtos = await _offreRepository.GetOffres();
                foreach(OffreDto offre in offreDtos)
                {
                     offre.AgentCar = JsonConvert.DeserializeObject<AgentDto>(await _CLIENT.GetStringAsync("api/Agents/"+ offre.AgentId));
                     offre.Car = JsonConvert.DeserializeObject<CarDto>(await _CLIENT2.GetStringAsync("api/Cars/"+ offre.CarId));
       

                }
               
                _response.Result = offreDtos;
               
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
        [Route("/last")]
        public async Task<object> GetLast()
        {
            try
            {

                IEnumerable<OffreDto> offreDtos = await _offreRepository.GetLastOffre();
                /*foreach (OffreDto offre in offreDtos)
                {
                    offre.AgentCar = JsonConvert.DeserializeObject<AgentDto>(await _CLIENT.GetStringAsync("api/Agents/" + offre.AgentId));
                    offre.Car = JsonConvert.DeserializeObject<CarDto>(await _CLIENT2.GetStringAsync("api/Cars/" + offre.CarId));


                }*/

                _response.Result = offreDtos;

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
                OffreDto offreDto = await _offreRepository.GetOffreById(id);
                offreDto.AgentCar = JsonConvert.DeserializeObject<AgentDto>(await _CLIENT.GetStringAsync("api/Agents/" + id));
                offreDto.Car = JsonConvert.DeserializeObject<CarDto>(await _CLIENT2.GetStringAsync("api/Cars/" + id));


                _response.Result = offreDto;
                   
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
        [Route("/find/{price}")]
        public async Task<object> GetbyPrice(string price)
        {
            try
            {
                IEnumerable<OffreDto> offreDto = await _offreRepository.GetOffreByPrice(price);
                foreach (OffreDto offre in offreDto)
                {
                    offre.AgentCar = JsonConvert.DeserializeObject<AgentDto>(await _CLIENT.GetStringAsync("api/Agents/" + offre.AgentId));
                    offre.Car = JsonConvert.DeserializeObject<CarDto>(await _CLIENT2.GetStringAsync("api/Cars/" + offre.CarId));


                }
                

                _response.Result = offreDto;

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
          
            public async Task<object> Post([FromBody] OffreDto offreDto)
            {
                try
                {
                    OffreDto model = await _offreRepository.CreateUpdateOffre(offreDto);
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
            public async Task<object> Put([FromBody] OffreDto offreDto)
            {
                try
                {
                    OffreDto model = await _offreRepository.CreateUpdateOffre(offreDto);
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
                    bool isSuccess = await _offreRepository.DeleteOffre(id);
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

