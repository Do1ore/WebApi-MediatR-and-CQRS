using CleanWebAPI.Models.MainModels;
using MediatR;

namespace CleanWebAPI.CQRS.Products.Requests
{
    public class UpdateProductQuery : IRequest<Product>
    {
        public Product Proudct { get; }

        public UpdateProductQuery(Product proudct)
        {
            Proudct = proudct;
        }
    }
}
