using CleanWebAPI.Models.MainModels;
using MediatR;

namespace CleanWebAPI.CQRS.Products.Requests
{
    public class GetAllProductsQuery : IRequest<List<Product>>
    {

    }
}
