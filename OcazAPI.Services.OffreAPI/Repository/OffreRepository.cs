using OcazAPI.Services.OffreAPI.offreDbContexts;
using OcazAPI.Services.OffreAPI.Models;
using OcazAPI.Services.OffreAPI.Models.Dto;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OcazAPI.Services.CarAPI.Models.Dto;

namespace OcazAPI.Services.OffreAPI.Repository
{
   
    public class OffreRepository : IOffreRepository
    {
        private readonly OffreDbContext _db;

        private IMapper _mapper;











        public OffreRepository(OffreDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<OffreDto> CreateUpdateOffre(OffreDto offreDto)
        {
            Offre offre = _mapper.Map<OffreDto, Offre>(offreDto);
            if (offre.OffreId > 0)
            {
                _db.Offres.Update(offre);
            }
            else
            {
                _db.Offres.Add(offre);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Offre, OffreDto>(offre);
        }

        public async Task<bool> DeleteOffre(int offreId)
        {
            try
            {
                Offre offre = await _db.Offres.FirstOrDefaultAsync(u => u.OffreId == offreId);
                if (offre == null)
                {
                    return false;
                }
                _db.Offres.Remove(offre);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<OffreDto>> GetLastOffre()
        {
            List<Offre> offre = await _db.Offres.OrderByDescending(x => x.OffreId).Take(2).ToListAsync();

            return _mapper.Map<List<OffreDto>>(offre);

        }

        public async Task<OffreDto> GetOffreById(int offreId)
        {
            Offre offre = await _db.Offres.Where(x => x.OffreId == offreId).FirstOrDefaultAsync();



            return _mapper.Map<OffreDto>(offre);

        }

        public async Task<IEnumerable<OffreDto>> GetOffreByPrice(string offrePrice)
        {
            double price = Convert.ToDouble(offrePrice);
            List<Offre> offreList = await _db.Offres.Where(x => x.Price < price).ToListAsync();



            return _mapper.Map<List<OffreDto>>(offreList);
        }




        public async Task<IEnumerable<OffreDto>> GetOffres()
        {
            List<Offre> offreList = await _db.Offres.ToListAsync();

            return _mapper.Map<List<OffreDto>>(offreList);

        }

        
    }
}
