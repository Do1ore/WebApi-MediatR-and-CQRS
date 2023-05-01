using CleanWebAPI.Handlers;
using CleanWebAPI.Models;
using CleanWebAPI.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<ProductController>
        [HttpGet]
        [Route("GetAllProducts")]
        public async Task<IActionResult> ProductListAsync()
        {
            var query = new GetAllProductsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        // GET api/<ValuesController>/5
        [HttpGet]
        [Route("GetProductById/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetProductByIdQuery(id);
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
