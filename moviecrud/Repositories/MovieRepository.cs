using moviecrud.Data;
using moviecrud.Models;

namespace moviecrud.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        ApplicationDbContext db;
        public MovieRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddMovie(Movie movie)
        {
            db.Movies.Add(movie);
            int result=db.SaveChanges();
            return result;
            
        }

        public int DeleteMovie(int id)
        {
            int res = 0;
            var result = db.Movies.Where(x => x.Id == id).FirstOrDefault();
            if(result != null)
            {
                db.Movies.Remove(result);
                res = db.SaveChanges();
            }
            return res;

        }

        public Movie GetMovieById(int id)
        {
            var result = db.Movies.Where(x => x.Id == id).SingleOrDefault();
            return result;
        }

        public IEnumerable<Movie> GetMovies()
        {
            var result = from m in db.Movies
                         select m;
            return result;
        }

        public int UpdateMovie(Movie movie)
        {
            int res = 0;
            var result=db.Movies.Where(x=>x.Id == movie.Id).FirstOrDefault();
            if(result!=null)
            {
                result.Name = movie.Name;
                result.Type = movie.Type;
                result.Actor = movie.Actor;
                result.Actress = movie.Actress;
                res = db.SaveChanges();
            }
            return res;
        }
    }
}
