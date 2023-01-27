using OcazAPI.Services.CarAPI.Models.Dto;
using OcazAPI.Services.CarAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OcazAPI.Services.CarAPI.Controllers
{
    [Route("api/Cars")]
    public class CarAPIController : ControllerBase
    {

        protected ResponseDto _response;
        private ICarRepository _carRepository;
       
        public CarAPIController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
         

            this._response = new ResponseDto();
        }

        [HttpGet]
        public async Task<object> Get()
        {
          try
            {
                IEnumerable<CarDto> CarDtos = await _carRepository.GetCars();
             
                _response.Result = CarDtos;
               
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
                CarDto carDto = await _carRepository.GetCarById(id);

                _response.Result = carDto;

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

            public async Task<object> Post([FromBody] CarDto carDto)
            {
                try
                {
                    CarDto model = await _carRepository.CreateUpdateCar(carDto);
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


           

            
        }
    }

