using Database;
using System.Collections.Generic;

namespace api.Interfaces
{
    public interface IGetMovie
    {
        List<Movies> GetMovies(string title);
    }
}
