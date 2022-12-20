using Movies;


namespace MoviesRest.Managers
{
    public class MoviesManager
    {
        private static int _incrementId = 1;
        private static readonly List<MovieClass> movieClasses = new List<MovieClass>()
        {
            new MovieClass{Id = _incrementId++, MovieName = "Terminator", LenghtInMinutes = 190, CountryOfOrigin = "USA"},
            new MovieClass{Id = _incrementId++, MovieName = "Doom", LenghtInMinutes = 170, CountryOfOrigin = "Somalia"},
            new MovieClass{Id = _incrementId++, MovieName = "Weird", LenghtInMinutes = 75, CountryOfOrigin = "Peru"},
        };

        public IEnumerable<MovieClass> GetAll()
        {
            List<MovieClass> movies = new List<MovieClass>(movieClasses);
            return movies;
        }

        public MovieClass? GetById(int id)
        {
            return movieClasses.Find(movie => movie.Id == id);
        }

        public MovieClass PostMovie(MovieClass newMovie)
        {
            newMovie.Id = _incrementId++;
            movieClasses.Add(newMovie);
            return newMovie;
        }
    }
}
