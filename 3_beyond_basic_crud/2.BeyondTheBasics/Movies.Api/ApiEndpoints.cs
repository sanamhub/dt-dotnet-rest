namespace Movies.Api;

public static class ApiEndpoints
{
    private const string _apiBase = "api";

    public static class Movies
    {
        private const string _base = $"{_apiBase}/movies";

        public const string Create = _base;
        public const string Get = $"{_base}/{{idOrSlug}}";
        public const string GetAll = _base;
        public const string Update = $"{_base}/{{id:guid}}";
        public const string Delete = $"{_base}/{{id:guid}}";
    }
}
