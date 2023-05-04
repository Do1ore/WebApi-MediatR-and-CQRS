using CleanWebAPI.CQRS.Products.Requests;
using CleanWebAPI.Models.MainModels;
using CleanWebAPI.Repositories.Interfaces;
using MediatR;

namespace CleanWebAPI.CQRS.Products.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductQuery, Product>
    {
        private readonly IProductRepository _repository;

        public UpdateProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Product> Handle(UpdateProductQuery request, CancellationToken cancellationToken)
        {
            await _repository.UpdateProductAsync(request.Proudct);

            return request.Proudct;
        }
    }
}
