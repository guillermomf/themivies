using System.Collections.Generic;
using Newtonsoft.Json;
using themovies.Services;

namespace themovies.Models
{
    public class MovieCredits
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("cast")]
        public List<MovieCredit> Cast { get; set; }
    }

    public class MovieCredit
    {
        [JsonProperty("cast_id")]
        public int CastId { get; set; }

        [JsonProperty("character")]
        public string Character { get; set; }

        [JsonProperty("credit_id")]
        public string CreditId { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        private string profilePath;
        [JsonProperty("profile_path")]
        public string ProfilePath
        {
            get { return profilePath; }
            set { profilePath = $"{Config.SecureBaseUrl}w45{value}"; }
        }
    }
}
