using System.Collections.ObjectModel;
using System.Threading.Tasks;
using themovies.Models;
using themovies.Services;

namespace themovies.ViewModels
{
    public class HomeViewModel
    {
        private readonly IMovieService movieService;

        public ObservableCollection<Movie> UpcomingList { get; set; }
        public ObservableCollection<Movie> TopRatedList { get; set; }
        public ObservableCollection<Movie> PopularList { get; set; }

        public Movie SelectedMovie { get; set; }

        public HomeViewModel()
        {
            movieService = new MovieService();
            UpcomingList = new ObservableCollection<Movie>();
            TopRatedList = new ObservableCollection<Movie>();
            PopularList = new ObservableCollection<Movie>();
            GetUpcomingList().ConfigureAwait(false);
            GetTopRatedList().ConfigureAwait(false);
            GetPopularList().ConfigureAwait(false);
        }

        public async Task GetUpcomingList()
        {
            var result = await movieService.GetUpcoming();
            UpcomingList.Clear();

            foreach (var item in result)
            {
                UpcomingList.Add(item);
            }
        }

        public async Task GetTopRatedList()
        {
            var result = await movieService.GetTopRated();
            TopRatedList.Clear();

            foreach (var item in result)
            {
                TopRatedList.Add(item);
            }
        }

        public async Task GetPopularList()
        {
            var result = await movieService.GetPopular();
            PopularList.Clear();

            foreach (var item in result)
            {
                PopularList.Add(item);
            }
        }
    }
}
