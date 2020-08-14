using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using themovies.Models;
using themovies.Services;

namespace themovies.ViewModels
{
    public class MovieDetailViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly IMovieService movieService;

        MovieDetail movieDetail;
        public MovieDetail MovieDetail
        {
            set
            {
                if (movieDetail != value)
                {
                    movieDetail = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MovieDetail"));
                }
            }
            get
            {
                return movieDetail;
            }
        }

        public ObservableCollection<MovieCredit> MovieCreditList { get; set; }

        public MovieDetailViewModel()
        {
            movieService = new MovieService();
            MovieCreditList = new ObservableCollection<MovieCredit>();
        }

        public async Task GetMovieDetail(long id)
        {
            MovieDetail = await movieService.GetMovieDetail(id);
        }

        public async Task GetMovieCredits(long id)
        {
            var movieCredits = await movieService.GetMovieCredits(id);
            foreach (var item in movieCredits.Cast)
            {
                MovieCreditList.Add(item);
            }
        }
    }
}
