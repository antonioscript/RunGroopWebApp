using RunGroopWebApp.Data.Enum;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Interfaces
{
    public interface IRaceRepository
    {
        Task<IEnumerable<Race>> GetAll();

        Task<Race> GetByIdAsync(int id); //Pega os clubs de acordo com o Id

        Task<IEnumerable<Race>> GetAllRacesByCity(string city); 

        bool Add(Race race);

        bool Update(Race race);

        bool Delete(Race race);

        bool Save();
    }
}