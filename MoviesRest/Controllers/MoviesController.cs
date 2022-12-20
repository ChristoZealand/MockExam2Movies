using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesRest.Managers;
using Movies;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;

namespace MoviesRest.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private MoviesManager _manager = new MoviesManager();

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet]
        public ActionResult<IEnumerable<MovieClass>> GetAllMovies()
        {
            IEnumerable<MovieClass> list = _manager.GetAll();
            if (list == null || list.Count() == 0)
            {
                return NoContent();
            }
            else
            {
                return Ok(list);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet("{id}")]
        public ActionResult<MovieClass> GetMovesById(int id)
        {
            MovieClass specificMovie = _manager.GetById(id);
            if (specificMovie == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(specificMovie);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<MovieClass> PostMovies([FromBody] MovieClass newMovie)
        {
            try
            {
                MovieClass createdMovie = _manager.PostMovie(newMovie);
                return Created("/" + createdMovie.Id, createdMovie);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
