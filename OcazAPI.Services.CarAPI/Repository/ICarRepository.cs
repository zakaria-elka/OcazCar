using OcazAPI.Services.CarAPI.Models.Dto;

namespace OcazAPI.Services.CarAPI.Repository
{
    public interface ICarRepository
    {
        Task<IEnumerable<CarDto>> GetCars();
        Task<CarDto> GetCarById(int carId);
        Task<CarDto> CreateUpdateCar(CarDto carDto);

    }
}
