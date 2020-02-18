using api.Interfaces;
using Database;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis.Extensions.Core.Abstractions;
using System.Collections.Generic;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IGetMovie getMovie;
        private readonly IRedisCacheClient redis;

        public MovieController(IGetMovie getMovie, IRedisCacheClient redis)
        {
            this.getMovie = getMovie;
            this.redis = redis;
        }

        [HttpGet("{title}")]
        public IEnumerable<Movies> Get(string title) { 

            return this.getMovie.GetMovies(title); 
        }

    }
}