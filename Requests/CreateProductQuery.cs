using CleanWebAPI.Models;
using MediatR;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace CleanWebAPI.Requests
{
    public class CreateProductQuery : IRequest<Product>
    {
        public Product Product { get; }

        public CreateProductQuery(Product product)
        {
            Product = product;
        }
    }
}
