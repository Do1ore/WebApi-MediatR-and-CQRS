using CleanWebAPI.Models;
using CleanWebAPI.Repositories.Interfaces;
using CleanWebAPI.Requests;
using MediatR;

namespace CleanWebAPI.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IProductRepository _repository;
        public GetProductByIdHandler(IProductRepository repository)
        {
            _repository = repository;
        }
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            Product? result = await _repository.GetProductByIdAsync(request.Id);
            if (result == null)
            {
                return null;
            }
            return result;
        }


    }
}


