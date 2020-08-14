using System;
using System.Collections.Generic;
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
            vm.Movie = movie;
        }
    }
}
