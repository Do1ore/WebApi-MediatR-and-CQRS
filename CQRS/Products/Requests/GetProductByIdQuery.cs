using CleanWebAPI.Models.MainModels;
using MediatR;

namespace CleanWebAPI.CQRS.Products.Requests
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
