using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using themovies.Models;
using themovies.Services;
using Xamarin.Forms;

namespace themovies.ViewModels
{
    public class HomeViewModel
    {
        private IMovieService movieService;

        public ObservableCollection<Movie> UpcommingList { get; set; }
        public ObservableCollection<Movie> TopRatedList { get; set; }
        public ObservableCollection<Movie> PopularList { get; set; }

        public Movie SelectedMovie { get; set; }

        public HomeViewModel()
        {
            movieService = new MovieService();
            UpcommingList = new ObservableCollection<Movie>();
            TopRatedList = new ObservableCollection<Movie>();
            PopularList = new ObservableCollection<Movie>();
            GetUpcomingList().ConfigureAwait(false);
            GetTopRatedList().ConfigureAwait(false);
            GetPopularList().ConfigureAwait(false);
        }

        public async Task GetUpcomingList()
        {
            var result = await movieService.GetUpcomming();
            UpcommingList.Clear();

            foreach (var item in result)
            {
                UpcommingList.Add(item);
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
