using moviecrud.Models;
using moviecrud.Repositories;

namespace moviecrud.Services
{
    public class MovieServices : IMovieServices
    {
        private readonly IMovieRepository repo;

        public MovieServices(IMovieRepository repo)
        {
           this.repo = repo;
        }
        public int AddMovie(Movie movie)
        {
            return repo.AddMovie(movie);
        }

        public int DeleteMovie(int id)
        {
            return repo.DeleteMovie(id);
        }

        public Movie GetMovieById(int id)
        {
            return repo.GetMovieById(id);
        }

        public IEnumerable<Movie> GetMovies()
        {
           return repo.GetMovies();
        }

        public int UpdateMovie(Movie movie)
        {
           return repo.UpdateMovie(movie);
        }
    }
}
