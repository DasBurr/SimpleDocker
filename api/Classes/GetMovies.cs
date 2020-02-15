using System.Collections.Generic;
using System.Linq;
using api.Interfaces;
using Database;

namespace api.Classes
{
    public class GetMovies : IGetMovie
    {
        private readonly MovieContext context;

        public GetMovies(MovieContext context)
        {
            this.context = context;
        }

        List<Movies> IGetMovie.GetMovies(string title)
        {
            return this.context.Movies.Where(m => m.Primarytitle.Contains(title)).Take(50).ToList();
        }
    }
}
