using CleanWebAPI.Models;
using MediatR;

namespace CleanWebAPI.Requests
{
    public class DeleteProductQuery : IRequest<int>
    {
        public int Id { get; }

        public DeleteProductQuery(int id)
        {
            Id = id;
        }
    }
}
