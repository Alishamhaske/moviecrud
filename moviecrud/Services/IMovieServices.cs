using moviecrud.Models;

namespace moviecrud.Services
{
    public interface IMovieServices
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovieById(int id);

        int AddMovie(Movie movie);
        int UpdateMovie(Movie movie);
        int DeleteMovie(int id);

        
    }
}
