using CleanWebAPI.CQRS.Movies.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {

        private readonly IMediator _mediator;

        public MovieController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetMovie([AsParameters]string searchTerm)
        {
            GetMovieQuery getMovieQuery = new GetMovieQuery(searchTerm);
            var result = await _mediator.Send(getMovieQuery);
            return Ok(result);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> SearchMovie([AsParameters] string searchTerm)
        {
            GetMoviesListQuery getMovieListQuery = new GetMoviesListQuery(searchTerm);
            var result = await _mediator.Send(getMovieListQuery);
            return Ok(result);
        }
    }
}
