using themovies.ViewModels;
using Xamarin.Forms;

namespace themovies.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var vm = (HomeViewModel)BindingContext;
            await Navigation.PushAsync(new MovieDetailPage(vm.SelectedMovie));
        }
    }
}
