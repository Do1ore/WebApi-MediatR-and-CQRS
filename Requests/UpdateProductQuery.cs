using CleanWebAPI.Models;
using MediatR;

namespace CleanWebAPI.Requests
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
