using System.Collections.Generic;
using System.Threading.Tasks;
using themovies.Models;

namespace themovies.Services
{
    public interface IMovieService
    {
        Task<List<Movie>> GetUpcoming();
        Task<List<Movie>> GetTopRated();
        Task<List<Movie>> GetPopular();
        Task<MovieDetail> GetMovieDetail(long Id);
        Task<MovieCredits> GetMovieCredits(long Id);
    }
}
