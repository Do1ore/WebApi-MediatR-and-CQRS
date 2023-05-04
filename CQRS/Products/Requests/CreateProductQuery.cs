using CleanWebAPI.Models.MainModels;
using MediatR;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace CleanWebAPI.CQRS.Products.Requests
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
