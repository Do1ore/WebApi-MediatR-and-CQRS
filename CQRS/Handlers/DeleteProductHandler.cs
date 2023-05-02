using CleanWebAPI.Repositories.Interfaces;
using CleanWebAPI.Requests;
using MediatR;

namespace CleanWebAPI.CQRS.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductQuery, int>
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<int> Handle(DeleteProductQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.DeleteProductAsync(request.Id);
        }
    }
}
