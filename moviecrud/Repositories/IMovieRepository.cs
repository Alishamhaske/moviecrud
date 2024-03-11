using moviecrud.Models;

namespace moviecrud.Repositories
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovieById(int id);
        int AddMovie(Movie movie);
        int UpdateMovie(Movie movie);
        int DeleteMovie(int id);
    }
}
