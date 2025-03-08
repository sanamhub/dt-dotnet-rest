using Movies.Application.Models;

namespace Movies.Application.Services
{
    public interface IMovieService
    {
        Task<bool> CreateAsync(Movie movie, CancellationToken token);

        Task<Movie?> GetByIdAsync(Guid id, CancellationToken token);

        Task<Movie?> GetBySlugAsync(string slug, CancellationToken token);

        Task<IEnumerable<Movie>> GetAllAsync(CancellationToken token);

        Task<Movie?> UpdateAsync(Movie movie, CancellationToken token);

        Task<bool> DeleteByIdAsync(Guid id, CancellationToken token);
    }
}
