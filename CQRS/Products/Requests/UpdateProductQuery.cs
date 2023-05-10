using CleanWebAPI.Models.MainModels;
using MediatR;

namespace CleanWebAPI.CQRS.Products.Requests
{
    public class UpdateProductQuery : IRequest<Product>
    {
        public Product Product { get; }

        public UpdateProductQuery(Product proudct)
        {
            Product = proudct;
        }
    }
}
