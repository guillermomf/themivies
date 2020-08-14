using themovies.Models;
using themovies.ViewModels;
using Xamarin.Forms;

namespace themovies.Pages
{
    public partial class MovieDetailPage : ContentPage
    {
        public MovieDetailPage(Movie movie)
        {
            InitializeComponent();
            var vm = (MovieDetailViewModel)BindingContext;
            vm.GetMovieDetail(movie.Id).ConfigureAwait(false);
            vm.GetMovieCredits(movie.Id).ConfigureAwait(false);
        }

        async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
