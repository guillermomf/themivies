namespace themovies.Services
{
    public static class Config
    {
        public static string ApiKey = "fac0e363356b7695b0859f8f98a93d60";
        public static string MainEndpoint = "https://api.themoviedb.org/3/movie";
        public static string UpcomingEndpoint = $"{MainEndpoint}/upcoming?api_key={ApiKey}&language=en-US&page=1";
        public static string TopRatedEndpoint = $"{MainEndpoint}/top_rated?api_key={ApiKey}&language=en-US&page=1";
        public static string PopularEndpoint = $"{MainEndpoint}/popular?api_key={ApiKey}&language=en-US&page=1";
        public static string SecureBaseUrl = "https://image.tmdb.org/t/p/";
    }
}
