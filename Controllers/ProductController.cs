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

        // GET api/<ProductController>/5
        [HttpGet]
        [Route("GetProductById/{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var query = new GetProductByIdQuery(id);
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }

        // POST api/<ProductController>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            var query = new UpdateProductQuery(product);
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> CreateProduct([FromBody] Product product)
        {
            var query = new CreateProductQuery(product);
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var query = new DeleteProductQuery(id);
            var result = await _mediator.Send(query);
            return result == 1 ? Ok(result) : NotFound();
        }
    }
}
