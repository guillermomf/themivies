using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using themovies.Models;

namespace themovies.Services
{
    public class MovieService : IMovieService
    {
        private HttpClient httpClient;

        public MovieService()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<Movie>> GetUpcoming()
        {
            return await GetMovies($"{Config.UpcomingEndpoint}");
        }

        public async Task<List<Movie>> GetTopRated()
        {
            return await GetMovies($"{Config.TopRatedEndpoint}");
        }

        public async Task<List<Movie>> GetPopular()
        {
            return await GetMovies($"{Config.PopularEndpoint}");
        }

        private async Task<List<Movie>> GetMovies(string url)
        {
            var result = await httpClient.GetStringAsync(url);

            var response = JsonConvert.DeserializeObject<MoviesResponse>(result);

            return response.Movies;
        }

        public async Task<MovieDetail> GetMovieDetail(long Id)
        {
            var url = $"{Config.MainEndpoint}/{Id}?api_key={Config.ApiKey}&language=en-US";
            var result = await httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<MovieDetail>(result);
        }

        public async Task<MovieCredits> GetMovieCredits(long Id)
        {
            var url = $"{Config.MainEndpoint}/{Id}/credits?api_key={Config.ApiKey}&language=en-US";
            var result = await httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<MovieCredits>(result);
        }
    }
}
