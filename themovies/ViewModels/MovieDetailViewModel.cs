using System;
using System.ComponentModel;
using themovies.Models;

namespace themovies.ViewModels
{
    public class MovieDetailViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Movie movie;
        public Movie Movie
        {
            set
            {
                if (movie != value)
                {
                    movie = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Movie"));
                }
            }
            get
            {
                return movie;
            }
        }

        public MovieDetailViewModel()
        {
        }
    }
}
