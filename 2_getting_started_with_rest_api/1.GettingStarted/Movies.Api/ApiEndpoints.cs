namespace Movies.Api;

public static class ApiEndpoints
{
    private const string _apiBase = "api";

    public static class Movies
    {
        public const string Base = $"{_apiBase}/movies";
        public const string Create = Base;
        public const string Get = $"{Base}/{{id:guid}}";
        public const string GetAll = Base;
        public const string Update = $"{Base}/{{id:guid}}";
        public const string Delete = $"{Base}/{{id:guid}}";
    }
}
