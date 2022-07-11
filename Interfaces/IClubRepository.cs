using RunGroopWebApp.Models;

namespace RunGroopWebApp.Interfaces
{
    public interface IClubRepository
    {   
        Task<IEnumerable<Club>> GetAll();

        Task<Club> GetByIdAsync(int id); //Pega os clubs de acordo com o Id

        Task<Club> GetByIdAsyncNoTracking(int id);

        Task<IEnumerable<Club>> GetClubByCity(string city); // Pega todos os clubs de acordo com a cidade

        bool Add(Club club);

        bool Update(Club club);

        bool Delete(Club club);

        bool Save();
    }
}