using CleanWebAPI.Models;
using CleanWebAPI.Models.Context;
using CleanWebAPI.Repositories.Interfaces;
using CleanWebAPI.Requests;
using MediatR;

namespace CleanWebAPI.Handlers
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly IProductRepository _productRepository;

        public GetAllProductsHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductListAsync();
        }
    }
}
