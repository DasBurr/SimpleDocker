using api.Interfaces;
using Database;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Distributed;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IGetMovie getMovie;
        private readonly IGetRedisCache redisCacheGet;
        private readonly ISetRedisCache redisCacheSet;


        public MovieController(IGetMovie getMovie, IGetRedisCache redisCache, ISetRedisCache redisCacheSet)
        {
            this.getMovie = getMovie;
            this.redisCacheGet = redisCache;
            this.redisCacheSet = redisCacheSet;
        }

        [HttpGet("{title}")]
        public IEnumerable<Movies> Get(string title)
        {
            var movies = redisCacheGet.Get<Movies>(title).Result;

            if (movies.Count == 0)
            {
                movies = this.getMovie.GetMovies(title);
                this.redisCacheSet.Set(title, movies);
            }

            return movies;
        }

    }
}