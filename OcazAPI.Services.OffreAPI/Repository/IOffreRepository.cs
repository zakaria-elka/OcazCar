using OcazAPI.Services.OffreAPI.Models.Dto;

namespace OcazAPI.Services.OffreAPI.Repository
{
    public interface IOffreRepository
    {
        Task<IEnumerable<OffreDto>> GetOffres();
        Task<OffreDto> GetOffreById(int offreId);
        Task<IEnumerable<OffreDto>> GetOffreByPrice(string offrePrice);
        Task<OffreDto> CreateUpdateOffre(OffreDto offreDto);
        Task<IEnumerable<OffreDto>> GetLastOffre();
        Task<bool> DeleteOffre(int offreId);
    }
}
