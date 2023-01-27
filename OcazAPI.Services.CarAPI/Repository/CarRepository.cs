using OcazAPI.Services.CarAPI.CarDbContexts;
using OcazAPI.Services.CarAPI.Models;
using OcazAPI.Services.CarAPI.Models.Dto;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace OcazAPI.Services.CarAPI.Repository
{
   
    public class CarRepository : ICarRepository
    {
        private readonly CarDbContext _db;

        private IMapper _mapper;











        public CarRepository(CarDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }



        public async Task<CarDto> CreateUpdateCar(CarDto carDto)
        {
            Cars car = _mapper.Map<CarDto, Cars>(carDto);

            if (car.CarId > 0)
            {
                _db.Cars.Update(car);
            }
            else
            {
    
                _db.Cars.Add(car);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Cars, CarDto>(car);

        }


        public async Task<CarDto> GetCarById(int carId)
        {
            Cars car = await _db.Cars.Where(x => x.CarId == carId).FirstOrDefaultAsync();



            return _mapper.Map<CarDto>(car);
        }




        public async Task<IEnumerable<CarDto>> GetCars()
        {
            List<Cars> carList = await _db.Cars.ToListAsync();

            return _mapper.Map<List<CarDto>>(carList);

        }
    }
}
