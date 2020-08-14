﻿using System;
using System.ComponentModel;
using Newtonsoft.Json;
using themovies.Services;

namespace themovies.Models
{
    public class Movie
    {
        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("vote_count")]
        public long VoteCount { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        private string posterPath;
        [JsonProperty("poster_path")]
        public string PosterPath
        {
            get { return posterPath; }
            set { posterPath = $"{Config.SecureBaseUrl}w92{value}"; }
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("adult")]
        public bool Adult { get; set; }

        private string backdropPath { get; set; }
        [JsonProperty("backdrop_path")]
        public string BackdropPath
        {
            get { return backdropPath; }
            set { backdropPath = $"{Config.SecureBaseUrl}w300{value}"; }
        }

        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("genre_ids")]
        public long[] GenreIds { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("release_date")]
        public DateTimeOffset ReleaseDate { get; set; }
    }
}
