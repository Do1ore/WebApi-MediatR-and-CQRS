using CleanWebAPI.Models;
using MediatR;

namespace CleanWebAPI.Requests
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
