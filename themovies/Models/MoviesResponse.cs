using System.Collections.Generic;
using Newtonsoft.Json;

namespace themovies.Models
{
    public class MoviesResponse
    {
        [JsonProperty("results")]
        public List<Movie> Movies { get; set; }
    }
}
