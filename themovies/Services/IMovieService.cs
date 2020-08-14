using System.Collections.Generic;
using System.Threading.Tasks;
using themovies.Models;

namespace themovies.Services
{
    public interface IMovieService
    {
        Task<List<Movie>> GetUpcomming();
        Task<List<Movie>> GetTopRated();
        Task<List<Movie>> GetPopular();
    }
}
