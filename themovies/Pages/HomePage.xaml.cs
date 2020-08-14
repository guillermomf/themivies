using System.Linq;
using themovies.ViewModels;
using Xamarin.Forms;

namespace themovies.Pages
{
    public partial class HomePage : ContentPage
    {
        private readonly HomeViewModel vm;

        public HomePage()
        {
            InitializeComponent();
            vm = (HomeViewModel)BindingContext;
        }

        async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await Navigation.PushAsync(new MovieDetailPage(vm.SelectedMovie));
        }

        void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == null || e.NewTextValue.Length < 3)
            {
                UpcomingCollection.ItemsSource = vm.UpcomingList;
                TopRatedCollection.ItemsSource = vm.TopRatedList;
                PopularCollection.ItemsSource = vm.PopularList;
            }
            else
            {
                var upcomingList = vm.UpcomingList.Where(x => x.Title.ToLower().Contains(e.NewTextValue.ToLower()));
                UpcomingCollection.ItemsSource = upcomingList;
                var topRatedList = vm.TopRatedList.Where(x => x.Title.ToLower().Contains(e.NewTextValue.ToLower()));
                TopRatedCollection.ItemsSource = topRatedList;
                var popularList = vm.PopularList.Where(x => x.Title.ToLower().Contains(e.NewTextValue.ToLower()));
                PopularCollection.ItemsSource = popularList;
            }
            
        }
    }
}
