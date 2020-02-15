using api.Interfaces;
using Database;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IGetMovie getMovie;

        public MovieController(IGetMovie getMovie)
        {
            this.getMovie = getMovie;
        }

        [HttpGet("{title}")]
        public IEnumerable<Movies> Get(string title) => this.getMovie.GetMovies(title);
        
    }
}