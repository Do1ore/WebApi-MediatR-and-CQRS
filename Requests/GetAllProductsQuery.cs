using CleanWebAPI.Models;
using MediatR;

namespace CleanWebAPI.Requests
{
    public class GetAllProductsQuery : IRequest<List<Product>>
    {

    }
}
